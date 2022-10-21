using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void New()
		{
			if (MUser.Get().Type < EUserTypes.Edit)
				return;

			Print(this, New, "New");

			if (CheckAndAskForUnsaved())
			{
				Clear();
				CurrentlyOpenedFile = string.Empty;
			}

			UpdateTitle();
		}
	}
}
