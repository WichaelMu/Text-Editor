
public enum ESignupResponse : byte
{
	OK = 0,
	UsernameExists = 1,
	PasswordNonMatch = 2,
	UsernameEmpty = 4,
	PasswordEmpty = 8,
	NameEmpty = 16
}
