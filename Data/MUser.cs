using System.Text;
using IO;

/// <summary>The Data Model that represents a user of MTextEditor.</summary>
public class MUser
{
#pragma warning disable CS8618 // This is never null when exiting LoginParser.ReadLogins() which is called in FLogin.Start().
	public static Dictionary<string, MUser> AllUsers;
#pragma warning restore CS8618
	static MUser Instance = null;

	public string Username;
	public string Password;

	public EUserTypes Type;

	public string FirstName;
	public string LastName;

	public DateTime DoB;

	/// <summary>Completely construct an <see cref="MUser"/>.</summary>
	public MUser(string Username, string Password, EUserTypes Type, string FirstName, string LastName, DateTime DoB)
	{
		this.Username = Username;
		this.Password = Password;
		this.Type = Type;
		this.FirstName = FirstName;
		this.LastName = LastName;
		this.DoB = DoB;
	}

	/// <summary>Get the singleton <see cref="Instance"/> <see cref="MUser"/> who is logged in.</summary>
	public static MUser Get()
	{
		return Instance;
	}

	/// <summary>Set the singleton <see cref="Instance"/> <see cref="MUser"/> who has just logged in.</summary>
	/// <returns><see langword="true"/> if there wasn't an <see cref="MUser"/> who logged out before <paramref name="UserToSet"/>.</returns>
	public static bool SetUser(MUser UserToSet)
	{
		bool bWasPreviouslyNull = Instance;

		Instance = UserToSet;

		return bWasPreviouslyNull;
	}

	/// <summary>
	/// Formats this <see cref="MUser"/>'s <see cref="DoB"/> to be in the format:
	/// <br></br>
	/// DD-MM-YYYY
	/// <br></br><br></br>
	/// E.g., 28-02-2001
	/// </summary>
	public string FormatDoB()
	{
		return DoB.ToString("dd-MM-yyyy");
	}

	/// <summary>
	/// Formats this <see cref="MUser"/>'s <see cref="DoB"/> to be in the format:
	/// <br></br>
	/// Wednesday, 28 February 2001
	/// </summary>
	public string FormatDoBFull()
	{
		return DoB.ToString("D");
	}

	/// <summary><see langword="async"/>hronously writes this <see cref="MUser"/>'s details to <see cref="FileSystem.kDirectory"/> <see cref="FileSystem.kLoginFile"/>.</summary>
	public async void Write()
	{
		await FileSystem.WriteToFile(FileSystem.kDirectory, FileSystem.kLoginFile, EWriteMode.Append, Encoding.UTF8, FormatToFile());
	}

	/// <summary>Delimits this <see cref="MUser"/>'s details to be in the correct structure for <see cref="Write"/>.</summary>
	string FormatToFile()
	{
		StringBuilder SB = new();

		SB
			.Append(Username)
			.Append(',')
			.Append(Password)
			.Append(',')
			.Append(Type)
			.Append(',')
			.Append(FirstName)
			.Append(',')
			.Append(LastName)
			.Append(',')
			.Append(FormatDoB());

		return SB.ToString();
	}

	/// <summary>[DEBUG ONLY] <see cref="UForm.Print(string, object)"/> this <see cref="MUser"/> in a human-readable format.</summary>
	public override string ToString()
	{
		StringBuilder SB = new StringBuilder();

		SB.Append("Username: ")
			.Append(Username)
			.Append("\nPassword: ")
			.Append(Password)
			.Append("\nType: ")
			.Append(Type)
			.Append("\nFirst Name: ")
			.Append(FirstName)
			.Append("\nLast Name: ")
			.Append(LastName)
			.Append("\nDate of Birth: ")
			.Append(FormatDoB());

		return SB.ToString();
	}

	/// <summary>Shorthand for
	/// <code>
	/// <see langword="if"/> (<paramref name="U"/> == <see langword="null"/>)
	/// </code>
	/// </summary>
	public static implicit operator bool (MUser U) => U == null;
}