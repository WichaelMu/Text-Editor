//#define WITH_ANIMATIONS

using static global::UForm;
using static global::MUser;
using static IO.LoginParser;
using Engine;

namespace MTextEditor
{
	public partial class FLogin : Form, IFormClass
#if WITH_ANIMATIONS
,ITick<FLogin>
#endif
	{
		public string __CLASS__ => "FLogin";

#if WITH_ANIMATIONS
		public bool bCanTick => true;

		public bool bIsTicking { get; set; }

		float T = 0f;

		bool bIsSigningUp;
		V2 LoginGroupStartPos;
		V2 SignUpGroupStartPos;
		V2 LoginOutOfBounds;
		V2 SignupInboundOffset;
#endif

		public FLogin()
		{
			InitializeComponent();
#if WITH_ANIMATIONS
			GetTickComponent().InitialiseTickComponent();
#endif
		}

		void Start(object Sender, EventArgs E)
		{
			LoadLogins();

			Size = new Size(840, 500);
#if WITH_ANIMATIONS
			LoginGroupStartPos = LoginGroup.Location;

			SignUpGroup.Location = new V2(GetBounds(this).X, SignUpGroup.Location.Y);
			SignUpGroupStartPos = SignUpGroup.Location;

			LoginOutOfBounds = new V2(-LoginGroup.Size.Width, LoginGroupStartPos.Y);
			SignupInboundOffset = new V2(SignUpGroup.Size.Width * .25f, 0);

			EUserType.Items.Add(EUserTypes.View);
			EUserType.Items.Add(EUserTypes.Edit);
			EUserType.SelectedIndex = 0;
#endif

			UpdateTheme();
		}

		public void Tick(float DeltaTime)
		{
#if WITH_ANIMATIONS
			LTitle.Text = "Delta Time: " + DeltaTime.ToString("F3");

			InterpGroups(bIsSigningUp, DeltaTime);

			Invalidate();
#endif
		}

		void LoadLogins()
		{
			if (ReadLogins(this, out AllUsers))
			{
				Print(this, LoadLogins, AllUsers.Count + " Logins were found!");

				//foreach (var User in FUser.AllUsers)
				//	Print(this, LoadLogins, User.Value);
			}
			else
			{
				Print(this, LoadLogins, "No Valid Logins!");
			}
		}

		#region Func Login

		void OnClick_Login(object Sender, EventArgs E) => CheckLogin();

		void CheckLogin()
		{
			string NUsername = TLoginUsername.Text;
			string NPassword = TLoginPassword.Text;

			Print(this, OnClick_Login, NUsername + " " + NPassword);

			if (IsValidLogin(NUsername, NPassword, out MUser LoggedIn))
			{
				LoginSuccess(LoggedIn);
			}
			else
			{
				LLoginFailMessage.Visible = true;
				LLoginFailMessage.Text = "Incorrect Username or Password!";

				TLoginPassword.Text = string.Empty;
			}
		}

		bool IsValidLogin(string UN, string PW, out MUser ValidUser)
		{
			if (AllUsers.ContainsKey(UN))
			{
				MUser Login = AllUsers[UN];

				if (Login.Password == PW)
				{
					Print(this, OnClick_Login, "Successful");
					ValidUser = Login;

					return true;
				}
			}

			Print(this, OnClick_Login, "Unsuccessful");
			ValidUser = null;

			return false;
		}

		void LoginSuccess(MUser LoggedIn)
		{
			SetUser(LoggedIn);
			ShowHide<FEditor>(this);
		}

		#endregion

		#region Func Signup

		void OnClick_Signup(object Sender, EventArgs E)
		{
#if WITH_ANIMATIONS
			ESignupResponse Response = ValidateSignup(out MUser NewUser);
			LSignupUsernameFailMessage.Visible = false;
			LSignupPasswordFailMessage.Visible = false;

			if (Response == ESignupResponse.OK)
			{
				LoginSuccess(NewUser);
				AllUsers.Add(NewUser.Username, NewUser);
			}
			else
			{
				if ((Response & ESignupResponse.UsernameExists) == ESignupResponse.UsernameExists)
				{
					LSignupUsernameFailMessage.Visible = true;
					LSignupUsernameFailMessage.Text = "That Username already exists!";
				}

				if ((Response & ESignupResponse.PasswordNonMatch) == ESignupResponse.PasswordNonMatch)
				{
					LSignupPasswordFailMessage.Visible = true;
					LSignupPasswordFailMessage.Text = "Passwords don't match!";
				}

				if ((Response & ESignupResponse.UsernameEmpty) == ESignupResponse.UsernameEmpty)
				{
					LSignupUsernameFailMessage.Visible = true;
					LSignupUsernameFailMessage.Text = "This field cannot be empty!";
				}

				if ((Response & ESignupResponse.PasswordEmpty) == ESignupResponse.PasswordEmpty)
				{
					LSignupPasswordFailMessage.Visible = true;
					LSignupPasswordFailMessage.Text = "This field cannot be empty!";
				}

				if ((Response & ESignupResponse.NameEmpty) == ESignupResponse.NameEmpty)
				{
					LSignupNameFailMessage.Visible = true;
					LSignupNameFailMessage.Text = "This field cannot be empty!";
				}
			}
#endif
		}

#if WITH_ANIMATIONS
		ESignupResponse ValidateSignup(out MUser NewUser)
		{
			ESignupResponse Response = ESignupResponse.OK;
			NewUser = null;

			if (AllUsers.ContainsKey(TSignupUsername.Text))
				Response |= ESignupResponse.UsernameExists;

			if (TSignupPasswordBase.Text != TSignupPasswordComparison.Text)
				Response |= ESignupResponse.PasswordNonMatch;

			if (TSignupUsername.Text.Length == 0)
				Response |= ESignupResponse.UsernameEmpty;

			if (TSignupPasswordBase.Text.Length == 0)
				Response |= ESignupResponse.PasswordEmpty;

			if (TFirstName.Text.Length == 0 || TLastName.Text.Length == 0)
				Response |= ESignupResponse.NameEmpty;

			if (Response != 0)
				return Response;

			string Username = TSignupUsername.Text;
			string Password = TSignupPasswordBase.Text;
			EUserTypes Type = GetUType(EUserType.Text);
			string FN = TFirstName.Text;
			string LN = TLastName.Text;
			DateTime DoB = DBirthday.Value;

			NewUser = new MUser(Username, Password, Type, FN, LN, DoB);
			NewUser.Write();

			return ESignupResponse.OK;
		}
#endif

		#endregion
#if WITH_ANIMATIONS
		public ITick<FLogin> GetTickComponent() => (ITick<FLogin>)this;

		//V2 RefLoginGroupVelocity;
		//V2 RefSignUpGroupVelocity;

		void InterpGroups(bool bIsSigningUp, float DeltaTime)
		{
			if (T <= 1f)
			{
				T += DeltaTime;

				if (bIsSigningUp)
				{
					LoginGroup.Location = V2.Interp(LoginGroup.Location, LoginOutOfBounds, .15f);
					SignUpGroup.Location = V2.Interp(SignUpGroup.Location, LoginGroupStartPos - SignupInboundOffset, .15f);
					//LoginGroup.Location = V2.Smooth(LoginGroup.Location, LoginOutOfBounds, ref RefLoginGroupVelocity, 1f, 5f, DeltaTime);
					//SignUpGroup.Location = V2.Smooth(SignUpGroup.Location, LoginGroupStartPos - SignupInboundOffset, ref RefSignUpGroupVelocity, 1f, 5f, DeltaTime);
				}
				else
				{
					LoginGroup.Location = V2.Interp(LoginGroup.Location, LoginGroupStartPos, .15f);
					SignUpGroup.Location = V2.Interp(SignUpGroup.Location, SignUpGroupStartPos, .15f);
					//LoginGroup.Location = V2.Smooth(LoginGroup.Location, LoginGroupStartPos, ref RefLoginGroupVelocity, 1f, 5f, DeltaTime);
					//SignUpGroup.Location = V2.Smooth(SignUpGroup.Location, SignUpGroupStartPos, ref RefSignUpGroupVelocity, 1f, 5f, DeltaTime);
				}
			}

			LoginGroup.Enabled = !bIsSigningUp;
			SignUpGroup.Enabled = bIsSigningUp;
		}
#endif

		void OnClick_ShowLogin(object Sender, EventArgs E)
		{
#if WITH_ANIMATIONS
			T = 0f;
			bIsSigningUp = false;

			LSignupUsernameFailMessage.Visible = false;
			LSignupPasswordFailMessage.Visible = false;
			LSignupNameFailMessage.Visible = false;
#endif
		}

		void OnClick_ShowSignup(object sender, EventArgs e)
		{
#if WITH_ANIMATIONS
			T = 0f;
			bIsSigningUp = true;

			LLoginFailMessage.Visible = false;
#else
			ShowHide<FSignup>(this);
#endif
		}

		void FLogin_OnKeyDown(object Sender, KeyEventArgs E)
		{
			if (E.KeyCode == Keys.Enter)
			{
				CheckLogin();
			}
		}

		void FLogin_Closed(object Sender, FormClosedEventArgs E)
		{
			Application.Exit();
		}

		void UpdateTheme()
		{
			if (MFormSettings.bIsLightTheme)
			{
				BackColor = LoginGroup.BackColor = SignUpGroup.BackColor = TLoginUsername.BackColor = TLoginPassword.BackColor = MFormSettings.LightThemeColour;
				ForeColor = LoginGroup.ForeColor = SignUpGroup.ForeColor = TLoginUsername.ForeColor = TLoginPassword.ForeColor = BLogin.ForeColor = MFormSettings.LightThemeForeColour;

#if WITH_ANIMATIONS
				TSignupUsername.BackColor = TSignupPasswordBase.BackColor = TSignupPasswordComparison.BackColor = TFirstName.BackColor = TLastName.BackColor = DBirthday.CalendarTitleBackColor = EUserType.BackColor = MFormSettings.LightThemeColour;
				TSignupUsername.ForeColor = TSignupPasswordBase.ForeColor = TSignupPasswordComparison.ForeColor = TFirstName.ForeColor = TLastName.ForeColor = DBirthday.CalendarTitleForeColor = EUserType.ForeColor = MFormSettings.LightThemeForeColour;
#endif
			}
			else
			{
				BackColor = LoginGroup.BackColor = SignUpGroup.BackColor = TLoginUsername.BackColor = TLoginPassword.BackColor = MFormSettings.DarkThemeColour;
				ForeColor = LoginGroup.ForeColor = SignUpGroup.ForeColor = TLoginUsername.ForeColor = TLoginPassword.ForeColor = MFormSettings.DarkThemeForeColour;
				BLogin.ForeColor = MFormSettings.LightThemeForeColour;

#if WITH_ANIMATIONS
				TSignupUsername.BackColor = TSignupPasswordBase.BackColor = TSignupPasswordComparison.BackColor = TFirstName.BackColor = TLastName.BackColor = DBirthday.CalendarTitleBackColor = EUserType.BackColor = MFormSettings.DarkThemeColour;
				TSignupUsername.ForeColor = TSignupPasswordBase.ForeColor = TSignupPasswordComparison.ForeColor = TFirstName.ForeColor = TLastName.ForeColor = DBirthday.CalendarTitleForeColor = EUserType.ForeColor = MFormSettings.DarkThemeForeColour;

				BCancel.ForeColor = BSignup.ForeColor = MFormSettings.LightThemeForeColour;
#endif
			}
		}
	}
}