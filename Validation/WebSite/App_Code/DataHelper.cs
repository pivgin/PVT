public sealed class DataHelper
{
	// Do not modify this class.

	private static string[] _existingLoginNames = 
		new string[] {"testuser1", "testuser2", "testuser3"};

	public static bool DoesLoginNameExist(string loginNameToCheck)
	{
		// In a real world application this method would check if a Login Name already 
		// exists in a database.

		foreach (string loginName in _existingLoginNames)
		{
			if (loginNameToCheck.ToLower() == loginName)
				return false;
		}

		return true;
	}
}
