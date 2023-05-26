using System;
using System.ComponentModel.Design.Serialization;
using System.Net;
using System.Security.Cryptography;

namespace IPFinder
{
    public class Program 
    {
        static bool once = true;
        public static void logo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("██╗░░██╗███╗░░░███╗░█████╗░███╗░░██╗░██████╗  ██╗██████╗░  ███████╗██╗███╗░░██╗██████╗░███████╗██████╗░");
            Console.WriteLine("██║░██╔╝████╗░████║██╔══██╗████╗░██║██╔════╝  ██║██╔══██╗  ██╔════╝██║████╗░██║██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine("█████═╝░██╔████╔██║███████║██╔██╗██║╚█████╗░  ██║██████╔╝  █████╗░░██║██╔██╗██║██║░░██║█████╗░░██████╔╝");
            Console.WriteLine("██╔═██╗░██║╚██╔╝██║██╔══██║██║╚████║░╚═══██╗  ██║██╔═══╝░  ██╔══╝░░██║██║╚████║██║░░██║██╔══╝░░██╔══██╗");
            Console.WriteLine("██║░╚██╗██║░╚═╝░██║██║░░██║██║░╚███║██████╔╝  ██║██║░░░░░  ██║░░░░░██║██║░╚███║██████╔╝███████╗██║░░██║");
            Console.WriteLine("╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░  ╚═╝╚═╝░░░░░  ╚═╝░░░░░╚═╝╚═╝░░╚══╝╚═════╝░╚══════╝╚═╝░░╚═╝");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(""); 
            Console.WriteLine("");

        }
        public static void Main()
        {
            logo();
            Console.WriteLine("Please insert IP below");
            var x = Console.ReadLine();
            Console.WriteLine($"IP you entered: {x}");
            Console.WriteLine("");
            if (once)
            {
                WebClient web = new WebClient();
                var y = web.DownloadString($"https://nordvpn.com/wp-admin/admin-ajax.php?action=get_user_info_data&ip={x}");
                var d1 = y.Replace('{', ' ');
                var uhh = d1.Replace('"', ' ');
                var uhh2 = uhh.Replace('}', ' ');
                var uhh3 = uhh2.Replace("  coordinates :", " ");
                    var d = uhh3.Split(',');
                foreach (var d2 in d)
                {
                    Console.WriteLine(d2);
                }
                once = false;
            }
            Console.ReadLine();
        }
    }

}

