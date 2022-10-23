using System.Diagnostics;
using System.Reflection;
using Engine;

/// <summary>Utility and Helper Functions for use with Windows Forms.</summary>
public class UForm : IFormClass
{
	/// <summary><see cref="IFormClass"/> implementation for debugging.</summary>
	public string __CLASS__ => "UForm";

	/// <summary>The name of the calling Function for debugging.</summary>
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

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="__CLASS__">The calling Class</param>
	/// <param name="__FUNCTION__">The calling Function.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print(string __CLASS__, string __FUNCTION__, object Param)
	{
		Debug.WriteLine(__CLASS__ + "::" + (__FUNCTION__ ?? UForm.__FUNCTION__)
				+ " -> " + Param.ToString()
		);
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="Class">The <see cref="IFormClass"/> calling class implementation.</param>
	/// <param name="__FUNCTION__">The signature of the calling Function.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print(IFormClass Class, Action? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="Class">The <see cref="IFormClass"/> calling class implementation.</param>
	/// <param name="__FUNCTION__">The signature of the calling Function.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print(IFormClass Class, Action<object, EventArgs>? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="Class">The <see cref="IFormClass"/> calling class implementation.</param>
	/// <param name="__FUNCTION__">The signature of the calling Function.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print(IFormClass Class, Action<object, KeyEventArgs>? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="Class">The <see cref="IFormClass"/> calling class implementation.</param>
	/// <param name="__FUNCTION__">The signature of the calling Function.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print<T>(IFormClass Class, Func<T> __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="Class">The <see cref="IFormClass"/> calling class implementation.</param>
	/// <param name="__FUNCTION__">The signature of the calling Function.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print<T1, T2>(IFormClass Class, Func<T1, T2> __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? UForm.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="__CLASS__">The calling Class.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print(string __CLASS__, object Param)
	{
		Debug.WriteLine(__CLASS__ + " -> " + Param.ToString());
	}

	/// <summary>Print to the Visual Studio <see cref="Debug"/> as standard output.</summary>
	/// <param name="Class">The <see cref="IFormClass"/> calling class implementation.</param>
	/// <param name="Param">The string to print to the <see cref="Debug"/> console.</param>
	public static void Print(IFormClass Class, object Param)
	{
		Print(Class.__CLASS__, Param);
	}

	/// <summary>Shows and hides Windows Forms.</summary>
	/// <typeparam name="S">The type of Form to show.</typeparam>
	/// <typeparam name="H">The type of Form to hide.</typeparam>
	/// <param name="ToShow">The Form to Show to the user.</param>
	/// <param name="ToHide">The Form to Hide from the user.</param>
	public static void ShowHide<S, H>(S ToShow, H ToHide) where S : Form where H : Form
	{
		ToShow.Show();
		ToHide.Hide();
	}

	/// <summary>Shows and Hides Windows Forms.</summary>
	/// <typeparam name="S">The type of Form to Show.</typeparam>
	/// <param name="ToHide">The Form to Hide form the user.</param>
	public static void ShowHide<S>(Form ToHide) where S : Form, new()
	{
		S ToShow = new();
		ToShow.Show();
		ToHide.Hide();
	}

	/// <summary>Get the size of a Windows Form.</summary>
	/// <param name="Bounds">The Form to get the size of.</param>
	/// <returns>A <see cref="V2"/> of the Width and Height Bounds of <paramref name="Bounds"/>.</returns>
	public static V2 GetBounds(Form Bounds)
	{
		var B = Bounds.Size;
		return new V2(B.Width, B.Height);
	}

	// Constant filters. (.txt, .rtf, and .cs)
	const string kTXT = "Plain Text (*.txt)|*.txt";
	const string kRTF = "Rich Text Format (*.rtf)|*.rtf";
	const string kCS = "|C Sharp Source File (*.cs)|*.cs";
	static string Filter = kTXT + "|" + kRTF + kCS;

	/// <summary>Set the extension for the <see cref="FileExplorer(string, ref string, bool, out DialogResult)"/>.</summary>
	/// <remarks>C# Source Files is always the last option.</remarks>
	/// <param name="Extension">0 is RTF and default, 1 and otherwise is TXT by default.</param>
	public static void SetExtension(int Extension = 0)
	{
		if (Extension == 0)
		{
			Filter = kRTF + "|" + kTXT;
		}
		else
		{
			Filter = kTXT + "|" + kRTF;
		}

		Filter += kCS;
	}

	/// <summary>Opens a File Explorer Dialog window for <paramref name="bOpening"/> or saving files.</summary>
	/// <param name="Title">The title of the File Explorer Dialog.</param>
	/// <param name="FileName">A <see langword="ref"/>erence to the file path that the user selects in the File Explorer Dialog.</param>
	/// <param name="bOpening"><see cref="true"/> if this File Explorer Dialog should open a file. <see langword="false"/> for saving.</param>
	/// <param name="Response">The <see cref="DialogResult"/> from the user of this File Explorer Dialog.</param>
	/// <returns><see langword="true"/> if the user pressed <see cref="DialogResult.OK"/>. In any other case, <see langword="false"/>.</returns>
	public static bool FileExplorer(string Title, ref string FileName, bool bOpening, out DialogResult Response)
	{
		if (bOpening)
		{
			OpenFileDialog File = new OpenFileDialog();
			File.Title = Title;
			File.Filter = Filter;

			Response = File.ShowDialog();
			if (Response == DialogResult.OK)
			{
				FileName = File.FileName;
				return true;
			}
		}
		else
		{
			SaveFileDialog Path = new SaveFileDialog();
			Path.Title = Title;
			Path.Filter = Filter;

			Response = Path.ShowDialog();
			if (Response == DialogResult.OK)
			{
				FileName = Path.FileName;
				return true;
			}
		}

		return false;
	}

	/// <inheritdoc cref="FileExplorer(string, ref string, bool, out DialogResult)"/>
	public static bool FileExplorer(string Title, ref string FileName, bool bOpening) => FileExplorer(Title, ref FileName, bOpening, out _);
}