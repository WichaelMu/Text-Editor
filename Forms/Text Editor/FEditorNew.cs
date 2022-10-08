using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void New()
		{
			Print(this, New, "New");

			CheckAndAskForUnsaved();

			UpdateTitle();
		}
	}
}
