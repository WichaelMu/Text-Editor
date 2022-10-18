using static global::UForm;
using static global::MUser;
using static IO.LoginParser;

namespace MTextEditor
{
	public partial class FSignup : Form, IFormClass
	{
		public string __CLASS__ => "FSignup";

		public FSignup()
		{
			InitializeComponent();
		}

		void Start(object Sender, EventArgs E)
		{
			EUserType.Items.Add(EUserTypes.View);
			EUserType.Items.Add(EUserTypes.Edit);
			EUserType.SelectedIndex = 0;
		}

		void OnClick_Signup(object Sender, EventArgs E)
		{
			CheckSignup();
		}

		void CheckSignup()
		{
			ESignupResponse Response = ValidateSignup(out MUser NewUser);
			LSignupUsernameFailMessage.Visible = false;
			LSignupPasswordFailMessage.Visible = false;

			if (Response == ESignupResponse.OK)
			{
				AllUsers.Add(NewUser.Username, NewUser);
				ShowHide<FLogin>(this);
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
		}

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


		void OnClick_SignupCancel(object Sender, EventArgs E)
		{
			ShowHide<FLogin>(this);
		}

		void OnClose_FSignup(object Sender, FormClosedEventArgs E)
		{
			ShowHide<FLogin>(this);
		}

		void FSignup_OnKeyDown(object Sender, KeyEventArgs E)
		{
			if (E.KeyCode == Keys.Enter)
				CheckSignup();
		}
	}
}
