/// <summary>
/// Method used to create an entry to the AD.
/// Replace the path, username, and password.
/// </summary>
/// <returns>DirectoryEntry</returns>
public static DirectoryEntry GetDirectoryEntry()
{
DirectoryEntry de = new DirectoryEntry();
de.Path = LDAP://192.168.1.1/CN=Users;DC=Yourdomain;
de.Username = @"yourdomain\sampleuser";
de.Password = "samplepassword";
return de;
}
