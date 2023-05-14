using System.Net;
using static System.Console;

Write("Enter A Valid Web Address: ");
string Url = ReadLine();
if (string.IsNullOrEmpty(Url) is true)
{
    Url = "https://world.episerver.com/cms/?q=pagetype";
}
var Uri = new Uri(Url);
WriteLine($"Uri : {Uri}");
WriteLine($"Uri Port : {Uri.Port}");
WriteLine($"Uri Query : {Uri.Query}");
WriteLine($"Uri Host : {Uri.Host}");
WriteLine($"Uri Scheme : {Uri.Scheme}");
WriteLine($"Uri Host : {Uri.Host}");
WriteLine($"Uri OriginalString : {Uri.OriginalString}");
WriteLine($"Uri Scaped : {Uri.UserEscaped}");

////////////////////// Get Ip
IPHostEntry entry = Dns.GetHostEntry(Uri.Host);
WriteLine($"{entry.HostName} Has The Folowing Ip Addresses :");
foreach (IPAddress address in entry.AddressList)
{
    Write($"{address}");
}

ReadKey();