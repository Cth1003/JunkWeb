//JunkWeb Client by Cth103
//this following program is a test. feel free to edit it anytime.
//START CODE
//Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;

namespace Junk_Web_Client
{
    class Program
    {

        //Main
        static void Main(string[] args)
        {
            Console.WriteLine("IP switcher... start");
            int i = 0;
            while (i < 10)
            {
                //jump to dead ip address so much junk
                Random rnd = new Random();
                string[] ip = new string[] { "https://81.196.2.213:80/", "https://203.66.159.44:80/", "https://123.57.190.51:80/", "https://123.57.190.51:80/", "https://199.16.220.249:80/", "https://202.47.236.251:80/", "https://202.47.236.252/", "https://203.66.159.46:80/","https://82.166.160.30:80/","https://217.175.34.170:80","https://123.57.190.51:80/" };
                string res = ip[rnd.Next(ip.Length)];
                res = ip[rnd.Next(ip.Length)];
                WebProxy proxyObject = new WebProxy(res);
                GlobalProxySelection.Select = proxyObject;
                Console.WriteLine("Switching to IP : "+res);
                i++;
                if (i == 10)
                {
                    Web();
                }
            }

        }

        private static void Web()
        {
            //The Web
            Console.WriteLine("Proxy pause...");
            System.Threading.Thread.Sleep(10000);
            Main("-restarted")
        }
    }

}
