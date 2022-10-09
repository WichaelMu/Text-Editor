using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void New()
		{
			Print(this, New, "New");

			if (CheckAndAskForUnsaved())
			{
				Clear();
				CurrentyOpenedFile = string.Empty;
			}

			UpdateTitle();
		}
	}
}
