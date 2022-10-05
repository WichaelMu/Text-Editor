

namespace MTextEditor
{
	public partial class FEditor : Form
	{
		public FEditor()
		{
			InitializeComponent();
		}

		void Start(object Sender, EventArgs E)
		{
			LLoggedInUser.Text = "Username: " + MUser.Get().Username;
		}

		void FEditor_OnClose(object Sender, FormClosedEventArgs E)
		{
			Application.Exit();
		}
	}
}
