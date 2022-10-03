using System.Diagnostics;
using System.Reflection;

public class FFormUtilities : IFormDefinitions
{
	public string __CLASS__ => "FCoreBaseForm";

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
		Debug.WriteLine(__CLASS__ + "::" + (__FUNCTION__ ?? FFormUtilities.__FUNCTION__)
				+ " -> " + Param.ToString()
		);
	}

	public static void Print(IFormDefinitions Class, Action? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? FFormUtilities.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print(IFormDefinitions Class, Action<object, EventArgs>? __FUNCTION__, object Param)
	{
		Print(Class.__CLASS__, __FUNCTION__ == null
			? FFormUtilities.__FUNCTION__
			: __FUNCTION__.Method.Name,
				Param
		);
	}

	public static void Print(string __CLASS__, object Param)
	{
		Debug.WriteLine(__CLASS__ + " -> " + Param.ToString());
	}

	public static void Print(IFormDefinitions Class, object Param)
	{
		Print(Class.__CLASS__, Param);
	}
}