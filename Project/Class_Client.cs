using System;

public class Client
{
    public string firstname;
    public string lastname;
    public string surname;
    public string organization;
    public Class(string f, string l, string s, string o)
	{
        firstname = f;
        lastname = l;
        surname = s;
        organization = o;
	}
    public void GetInfo()
    {
        ConsoleWriteLine("{0} {1}.{2}", lastname, firstname[0], surname[0]);
        ConsoleWriteLine(organization);
    }
}
