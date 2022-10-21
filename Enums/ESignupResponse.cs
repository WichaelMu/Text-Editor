
/// <summary>The Response when a User Signs Up to MTextEditor as an <see cref="MUser"/>.</summary>
public enum ESignupResponse : byte
{
	/// <summary>No Problems. Valid <see cref="MUser"/>.</summary>
	OK = 0,
	/// <summary>An <see cref="MUser"/> with that <see cref="MUser.Username"/> already exists.</summary>
	UsernameExists = 1,
	/// <summary>Base and Comparison Verification Passwords are mismatched.</summary>
	PasswordNonMatch = 2,
	/// <summary>The Sign Up Username is empty.</summary>
	UsernameEmpty = 4,
	/// <summary>One or more Sign Up Passwords are empty.</summary>
	PasswordEmpty = 8,
	/// <summary>Either the User's First Name, or Surname are empty.</summary>
	NameEmpty = 16
}
