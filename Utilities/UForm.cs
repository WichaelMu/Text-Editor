using System.Diagnostics;
using System.Reflection;
using Engine;

public class UForm : IFormClass
{
	public string __CLASS__ => "UForm";

	public static string __FUNCTION__
	{
		get
		{
			StackTrace StackTrace = new StackTrace();
			StackFrame? Frame = StackTrace.GetFrame(2);

			if (Frame != null)
			{
				MethodBase? Base = Frame.GetMethod();
				if (Base != null)
					return Base.Name;
			}

			return "";
		}
	}

	public static void Print(string __CLASS__, string __FUNCTION__, object Param)
	{
		Debug.WriteLine(__CLASS__ + "::" + (__FUNCTION__ ?? UForm.__FUNCTION__)
				+ " -> " + Param.ToString()
		);
	}

	public static void Print(IFormClass Class, Action? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print(IFormClass Class, Action<object, EventArgs>? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print(IFormClass Class, Action<object, KeyEventArgs>? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print<T>(IFormClass Class, Func<T> __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print<T1, T2>(IFormClass Class, Func<T1, T2> __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print(string __CLASS__, object Param)
	{
		Debug.WriteLine(__CLASS__ + " -> " + Param.ToString());
	}

	public static void Print(IFormClass Class, object Param)
	{
		Print(Class.__CLASS__, Param);
	}

	public static void ShowHide<S, H>(S ToShow, H ToHide) where S : Form where H : Form
	{
		ToShow.Show();
		ToHide.Hide();
	}

	public static void ShowHide<S>(Form ToHide) where S : Form, new()
	{
		S ToShow = new();
		ToShow.Show();
		ToHide.Hide();
	}

	public static V2 GetBounds(Form Bounds)
	{
		var B = Bounds.Size;
		return new V2(B.Width, B.Height);
	}

	const string kFilter = "Plain Text (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

	public static bool FileExplorer(string Title, ref string FileName, bool bOpening)
	{
		if (bOpening)
		{
			OpenFileDialog File = new OpenFileDialog();
			File.Title = Title;
			File.Filter = kFilter;

			if (File.ShowDialog() == DialogResult.OK)
			{
				FileName = File.FileName;
				return true;
			}
		}
		else
		{
			SaveFileDialog Path = new SaveFileDialog();
			Path.Title = Title;
			Path.Filter = kFilter;

			if (Path.ShowDialog() == DialogResult.OK)
			{
				FileName = Path.FileName;
				return true;
			}
		}

		return false;
	}
}