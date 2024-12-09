// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System;

namespace Pingnite
{

class Program {
static void Main(string[] args)
{
    string text = @"
 ____                                    __             
/\  _`\   __                          __/\ \__          
\ \ \L\ \/\_\    ___      __     ___ /\_\ \ ,_\    __   
 \ \ ,__/\/\ \ /' _ `\  /'_ `\ /' _ `\/\ \ \ \/  /'__`\ 
  \ \ \/  \ \ \/\ \/\ \/\ \L\ \/\ \/\ \ \ \ \ \_/\  __/ 
   \ \_\   \ \_\ \_\ \_\ \____ \ \_\ \_\ \_\ \__\ \____\
    \/_/    \/_/\/_/\/_/\/___L\ \/_/\/_/\/_/\/__/\/____/
                          /\____/                       
                          \_/__/                        
";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(text);



Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("  Coded and Made by @vrkx!");
Console.WriteLine(" ");
Ping pingea = new Ping();
PingReply replyea = pingea.Send("ping-nae.ds.on.epicgames.com",1000);
if( replyea.Status.ToString() == "Success" ){

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("  Na-East Ping :");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  Fortnite-Server-IP :" + " " + replyea.Address );
Console.WriteLine("  Ping :" + " " + replyea.RoundtripTime + "ms");
Console.WriteLine("  Connection Status : " +replyea.Status);

}
Console.WriteLine(" ");

Ping pingc = new Ping();
PingReply replyc = pingc.Send("ping-nac.ds.on.epicgames.com",1000);
if( replyc.Status.ToString() == "Success" ){

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("  Na-Central Ping :");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  Fortnite-Server-IP :" + " " + replyc.Address );
Console.WriteLine("  Ping :" + " " + replyc.RoundtripTime + "ms");
Console.WriteLine("  Connection Status : " +replyc.Status);

}

Console.WriteLine(" ");
Ping pingw = new Ping();
PingReply replyw = pingw.Send("ping-naw.ds.on.epicgames.com",1000);
if( replyw.Status.ToString() == "Success" ){

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("  Na-West Ping :");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  Fortnite-Server-IP :" + " " + replyw.Address );
Console.WriteLine("  Ping :" + " " + replyw.RoundtripTime + "ms");
Console.WriteLine("  Connection Status : " +replyw.Status);

}

Console.WriteLine(" ");
Ping pingeu = new Ping();
PingReply replyeu = pingeu.Send("ping-eu.ds.on.epicgames.com",1000);
if( replyeu.Status.ToString() == "Success" ){

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("  Europe Ping :");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  Fortnite-Server-IP :" + " " + replyeu.Address );
Console.WriteLine("  Ping :" + " " + replyeu.RoundtripTime + "ms");
Console.WriteLine("  Connection Status : " +replyeu.Status);

}

Console.WriteLine(" ");
Ping pingo = new Ping();
PingReply replyo = pingo.Send("ping-oce.ds.on.epicgames.com",1000);
if( replyeu.Status.ToString() == "Success" ){

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("  Europe Ping :");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  Fortnite-Server-IP :" + " " + replyo.Address );
Console.WriteLine("  Ping :" + " " + replyo.RoundtripTime + "ms");
Console.WriteLine("  Connection Status : " +replyo.Status);

}

Console.WriteLine(" ");
Ping pingbr = new Ping();
PingReply replybr = pingbr.Send("ping-br.ds.on.epicgames.com",1000);
if( replybr.Status.ToString() == "Success" ){

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("  Europe Ping :");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  Fortnite-Server-IP :" + " " + replybr.Address );
Console.WriteLine("  Ping :" + " " + replybr.RoundtripTime + "ms");
Console.WriteLine("  Connection Status : " +replybr.Status);

}

System.Threading.Thread.Sleep(-1);
 
}

   
}

}

