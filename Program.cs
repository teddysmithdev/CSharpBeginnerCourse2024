//Pinger

using System.Net.NetworkInformation;

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8");

while (PR.Status.ToString() == "Success")
{
    Console.WriteLine(PR.Status.ToString() + "!");
    PR = p1.Send("8.8.8.8");
    Console.WriteLine("Waiting ten seconds for next request");
    Thread.Sleep(10000);
}