using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_remoting_lib
{
    public class RemoteObject : MarshalByRefObject
    {
        public RemoteObject()
        {
            Console.WriteLine("The RemoteObject constructor is called");
        }

        public int Sum(int a, int b)
        {
            Console.WriteLine("Sum was called (" + a + " + " + b + ")");
            return a + b;
        }
    }
}
