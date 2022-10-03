using static global::FFormUtilities;
using static global::FUser;
using static IO.LoginParser;

namespace Text_Editor
{
	public partial class FLogin : Form, IFormDefinitions
	{
		public string __CLASS__ => "FLogin";

		public Action<FUser> OnSuccessfulLogin;

		public FLogin()
		{
			InitializeComponent();
			OnSuccessfulLogin += OnLoggedIn;
		}

		~FLogin()
		{
			OnSuccessfulLogin = null;
			Print(this, "Welp");
		}

		void Start(object Sender, EventArgs E)
		{
			LoadLogins();
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

			if (IsValidLogin(NUsername, NPassword, out FUser LoggedIn))
			{
				OnSuccessfulLogin?.Invoke(LoggedIn);
			}
		}

		void OnLoggedIn(FUser LoggedIn)
		{
			SetUser(LoggedIn);
		}

		bool IsValidLogin(string UN, string PW, out FUser ValidUser)
		{
			if (AllUsers.ContainsKey(UN))
			{
				FUser Login = AllUsers[UN];

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
	}
}