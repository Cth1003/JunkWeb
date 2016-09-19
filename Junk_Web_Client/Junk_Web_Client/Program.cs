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
           //write to console "IP SWITCHER ... START"
            Console.WriteLine("IP switcher... start");
            //creates the i variables
            int i = 0;
            while (i < 10)
            {
                //jump to dead ip address so much junk
                //random
                Random rnd = new Random();
                //all the deads ips on array
                string[] ip = new string[] { "https://81.196.2.213:80/", "https://203.66.159.44:80/", "https://123.57.190.51:80/", "https://123.57.190.51:80/", "https://199.16.220.249:80/", "https://202.47.236.251:80/", "https://202.47.236.252/", "https://203.66.159.46:80/","https://82.166.160.30:80/","https://217.175.34.170:80","https://123.57.190.51:80/" };
                //select random string from array
                string res = ip[rnd.Next(ip.Length)];
                res = ip[rnd.Next(ip.Length)];
                //just set current proxy to ip
                WebProxy proxyObject = new WebProxy(res);
                GlobalProxySelection.Select = proxyObject;
                //well. displays "switching to ip : ip"
                Console.WriteLine("Switching to IP : "+res);
                //add 1 to i
                i++;
                do {
                while (! Console.KeyAvailable) {
                Stop_Proxy()
                }       
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                //if i is 10. take a break
                if (i == 10)
                {
                    Web();
                }
            }

        }

        private static void Web()
        {
            //proxy pause
            Console.WriteLine("Proxy pause...");
            //wait for 10000 milliseconds
            System.Threading.Thread.Sleep(10000);
            //reset the variable
            i = 0;
            System.Threading.Thread.Sleep(1000);
            Main("-restarted");
            
        }
        private static void Stop_Proxy()
        {
           proxyObject = null;
           Console.WriteLine("disabled proxy");
        }
	        
        }
    }

}
