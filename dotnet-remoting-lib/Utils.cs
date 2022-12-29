using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_remoting_lib
{
    public class Utils
    {
        private static void DumpTypeEntries(Array arr)
        {
            foreach (object obj in arr)
            {
                Console.WriteLine("  {0}: {1}", obj.GetType().Name, obj);
            }
        }

        public static void DumpAllInfoAboutRegisteredRemotingTypes()
        {
            Console.WriteLine("ALL REGISTERED TYPES IN REMOTING -(BEGIN)---------");

            DumpTypeEntries(RemotingConfiguration.GetRegisteredActivatedClientTypes());
            DumpTypeEntries(RemotingConfiguration.GetRegisteredActivatedServiceTypes());
            DumpTypeEntries(RemotingConfiguration.GetRegisteredWellKnownClientTypes());
            DumpTypeEntries(RemotingConfiguration.GetRegisteredWellKnownServiceTypes());

            Console.WriteLine("ALL REGISTERED TYPES IN REMOTING -(END)  ---------");
        }
    }

}
