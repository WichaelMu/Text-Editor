using System.Collections.Generic;
using System.Text;

public class MUser
{
	public static Dictionary<string, MUser> AllUsers;
	static MUser Instance = null;

	public string Username;
	public string Password;

	public EUserTypes Type;

	public string FirstName;
	public string LastName;

	public DateTime DoB;

	public MUser(string Username, string Password, EUserTypes Type, string FirstName, string LastName, DateTime DoB)
	{
		this.Username = Username;
		this.Password = Password;
		this.Type = Type;
		this.FirstName = FirstName;
		this.LastName = LastName;
		this.DoB = DoB;
	}

	public static MUser Get()
	{
		return Instance;
	}

	public static bool SetUser(MUser UserToSet)
	{
		bool bWasPreviouslyNull = Instance;

		Instance = UserToSet;

		return bWasPreviouslyNull;
	}

	public string FormatDoB()
	{
		return DoB.ToString("dd-MM-yyyy");
	}

	public string FormatDoBFull()
	{
		return DoB.ToString("D");
	}

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

	public static implicit operator bool (MUser U) => U == null;
}