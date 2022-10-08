using static UForm;

namespace MTextEditor
{
	public partial class FEditor
	{
		void Cut()
		{
			Print(this, Cut, "Cut");
		}

		void Copy()
		{
			Print(this, Copy, "Copy");
		}

		void Paste()
		{
			Print(this, Paste, "Paste");
		}
	}
}
