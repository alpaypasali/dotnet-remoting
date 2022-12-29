using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using dotnet_remoting_lib;

namespace dotnet_remoting_server
{
    internal class Server
    {
        static void Main()
        {
            RemotingConfiguration.Configure("Server.exe.config", false);
            Utils.DumpAllInfoAboutRegisteredRemotingTypes();
            Console.WriteLine("To finish, press Enter");
            Console.ReadLine();
        }
    }
}
