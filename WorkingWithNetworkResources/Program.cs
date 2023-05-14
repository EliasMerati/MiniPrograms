using System.Net;
using System.Net.NetworkInformation;
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

///////////////////////////////////////// ping site
try
{
    var ping = new Ping();
    WriteLine("Pinging Server . Please Wait ....");
    PingReply Reply = ping.Send(Uri.Host);
    WriteLine($"{Uri.Host} Was Pinged and Replied {Reply.Status}.");
    if (Reply.Status is IPStatus.Success)
    {
        WriteLine($"Reply From {Reply.Address} Took {Reply.RoundtripTime:N0}ms");
    }
}
catch (Exception ex)
{
   WriteLine($"{ex.GetType()} says {ex.Message}");
}

ReadKey();