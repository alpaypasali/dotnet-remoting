using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using dotnet_remoting_lib;

namespace dotnet_remoting_client
{
    internal class Client
    {
        static void Main()
        {
            RemotingConfiguration.Configure("Client.exe.config", false);
            Utils.DumpAllInfoAboutRegisteredRemotingTypes();
            var obj = new RemoteObject();

            Console.Write("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("RemoteObject is " + (
                RemotingServices.IsTransparentProxy(obj) ? "proxy" : "n't proxy"));
            Console.WriteLine("Sum of numbers: " + obj.Sum(x, y));

            Console.WriteLine("To finish, press Enter");
            Console.ReadLine();
        }
    }
}
