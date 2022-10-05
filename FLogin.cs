using static global::UForm;
using static global::MUser;
using static IO.LoginParser;
using Engine;

namespace Text_Editor
{
	public partial class FLogin : Form, IFormClass, ITick<FLogin>
	{
		public string __CLASS__ => "FLogin";

		public bool bCanTick => true;

		public bool bIsTicking { get; set; }

		public Action<MUser> OnSuccessfulLogin;

		float T = 0f;

		bool bIsSigningUp;
		V2 LoginGroupStartPos;
		V2 SignUpGroupStartPos;

		public FLogin()
		{
			InitializeComponent();
			OnSuccessfulLogin += OnLoggedIn;

			GetTickComponent().OnStart();
		}

		~FLogin()
		{
			OnSuccessfulLogin = null;
			Print(this, "Welp");
		}

		void Start(object Sender, EventArgs E)
		{
			LoadLogins();

			LoginGroupStartPos = LoginGroup.Location;
			SignUpGroupStartPos = SignUpGroup.Location;
		}

		public void Tick(float DeltaTime)
		{
			LTitle.Text = "Delta Time: " + DeltaTime.ToString("F3");

			InterpGroups(bIsSigningUp, DeltaTime);
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

		void OnClick_Login(object Sender, EventArgs E)
		{
			string NUsername = TUsername.Text;
			string NPassword = TPassword.Text;

			Print(this, OnClick_Login, NUsername + " " + NPassword);

			if (IsValidLogin(NUsername, NPassword, out MUser LoggedIn))
			{
				OnSuccessfulLogin?.Invoke(LoggedIn);
			}

			T = 0f;
			bIsSigningUp = true;
		}

		void OnLoggedIn(MUser LoggedIn)
		{
			SetUser(LoggedIn);
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

		public ITick<FLogin> GetTickComponent()
		{
			return (ITick<FLogin>)this;
		}

		void OnClick_SignUp(object Sender, EventArgs E)
		{
			T = 0f;
			bIsSigningUp = false;
		}

		void InterpGroups(bool bIsSigningUp, float DeltaTime)
		{
			if (T <= 1f)
			{
				T += DeltaTime;

				if (bIsSigningUp)
				{
					LoginGroup.Location = V2.Interp(LoginGroup.Location, new V2(-LoginGroup.Size.Width, LoginGroupStartPos.Y), T);
					SignUpGroup.Location = V2.Interp(SignUpGroup.Location, LoginGroupStartPos, T);
				}
				else
				{
					LoginGroup.Location = V2.Interp(LoginGroup.Location, LoginGroupStartPos, T);
					SignUpGroup.Location = V2.Interp(SignUpGroup.Location, SignUpGroupStartPos, T);
				}
			}

			LoginGroup.Enabled = !bIsSigningUp;
			SignUpGroup.Enabled = bIsSigningUp;
		}
	}
}