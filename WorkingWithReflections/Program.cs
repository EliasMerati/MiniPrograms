using System.Reflection;

using static System.Console;

WriteLine("Assembly MetaData:");
Assembly assembly = Assembly.GetEntryAssembly();
WriteLine($"FullName : {assembly.FullName}");
WriteLine($"Location : {assembly.Location}");

var attributes = assembly.GetCustomAttributes();
WriteLine($"Attributes :");
foreach (Attribute a in attributes)
{
    WriteLine($"{a.GetType()}");
}
///////////////////////////////////////////////////////////////////////// Information
WriteLine("---------------------------------------------------------------------");
var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
WriteLine($" Version : {version.InformationalVersion}");

var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
WriteLine($"Company : {company.Company}");

/////////////////////////////////////////////////////////////////////////

ReadKey();