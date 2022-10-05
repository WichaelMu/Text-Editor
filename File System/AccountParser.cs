using static IO.FileSystem;
using static UForm;

namespace IO
{
	public static class LoginParser
	{
		public const char kDelimiter = ',';

		/// <summary>Read and Parse valid Login Credentials.</summary>
		public static bool ReadLogins(IFormClass Class, out Dictionary<string, MUser> OutCredentials)
		{
			OutCredentials = new Dictionary<string, MUser>();
			if (ReadFromFile(kDirectory, kLoginFile, out List<string> LoginData))
			{
				foreach (string Credential in LoginData)
				{
					// If this iteration if Credential is empty.
					bool bCredentialLineIsEmpty = string.IsNullOrEmpty(Credential);

					// Skip any '!' (comment markers in login.txt), or skip if the line is empty.
					if (bCredentialLineIsEmpty || Credential[0] == '!')
						continue;

					// Check if there is a ',' delimiter.
					if (!Credential.Contains(kDelimiter))
						Print(Class, "User Details are not correctly configured for: " + Credential);

					string[] Credentials = Credential.Split(kDelimiter);

					// Check if the file is configured in the format: <Username>,<Password>...
					if (Credentials.Length != 6)
						Print(Class, "User Details are not correctly configured for: " + Credential);

					// Check there are no duplicates in the Login Credential file.
					if (OutCredentials.ContainsKey(Credentials[0]))
						Print(Class, "Duplicate Key Found! User failed checks for: " + Credential);

					// Simply ignore a Login Credential if a duplicate Username is present.
					if (OutCredentials.ContainsKey(Credentials[0]))
						continue;

					// Prevent adding anything if any checks above failed.
					if (Credentials.Length == 6)
						OutCredentials.Add(Credentials[0], ConstructFromFile(Credentials));
				}

				if (OutCredentials.Count == 0)
					Print(Class, "There are no Login Credentials in login.txt!\nPlease create Login Credentials as per instructions in login.txt");

				return OutCredentials.Count != 0;
			}
			// Raise error.
			Print(Class, "Unable to open " + kDirectory + kLoginFile);

			// Return Empty.
			return false;
		}

#if true
		/// <summary>Retrieves and Constructs an <see cref="MUser"/> from a file with the corresponding <see cref="MUser.ID"/>.</summary>
		/// <param name="ID">The <see cref="MUser.ID"/>.</param>
		/// <returns>The <see cref="MUser"/> associated with <paramref name="ID"/>.</returns>
		public static MUser ConstructFromFile(string[] FromString)
		{
			string UN = FromString[0];
			string PW = FromString[1];
			EUserTypes T = GetUType(FromString[2]);
			string FN = FromString[3];
			string LN = FromString[4];
			string DB = FromString[5];

			return new MUser(UN, PW, T, FN, LN, DateTime.Parse(DB));
		}

		public static EUserTypes GetUType(string Type)
		{
			if (Type == nameof(EUserTypes.View))
				return EUserTypes.View;
			return EUserTypes.Edit;
		}
#endif

		/// <summary>The next Unique Account Number.</summary>
		public static int Unique { get => GetNextAccountNumber(); }
		// 8-Digit number.
		static int UniqueAccountNumber = 10000001;

		static int GetNextAccountNumber()
		{
			// Look for a unique Account Number by checking if a corresponding file exists.
			// Return the first Number with no match.
			while (FileExists(kDirectory, UniqueAccountNumber.ToString() + ".txt"))
			{
				++UniqueAccountNumber;
			}

			return UniqueAccountNumber;
		}
	}
}
