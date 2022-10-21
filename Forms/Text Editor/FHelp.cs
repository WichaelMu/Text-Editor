

namespace MTextEditor
{
	public partial class FHelp : Form
	{
		public FHelp()
		{
			InitializeComponent();
		}

		void Start(object Sender, EventArgs E)
		{
			UpdateTheme();
		}

		void OnClick_Back(object Sender, EventArgs E)
		{
			Close();
		}

		void UpdateTheme()
		{
			if (MFormSettings.bIsLightTheme)
			{
				BackColor = AboutGroup.BackColor = IconsAndShortcutsGroup.BackColor = InstructionsGroup.BackColor = MFormSettings.LightThemeColour;
				ForeColor = AboutGroup.ForeColor = IconsAndShortcutsGroup.ForeColor = InstructionsGroup.ForeColor = MFormSettings.LightThemeForeColour;

				BClose.ForeColor = MFormSettings.LightThemeForeColour;
			}
			else
			{
				BackColor = AboutGroup.BackColor = IconsAndShortcutsGroup.BackColor = InstructionsGroup.BackColor = MFormSettings.DarkThemeColour;
				ForeColor = AboutGroup.ForeColor = IconsAndShortcutsGroup.ForeColor = InstructionsGroup.ForeColor = MFormSettings.DarkThemeForeColour;

				BClose.ForeColor = MFormSettings.LightThemeForeColour;
			}
		}
	}
}
