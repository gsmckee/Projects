using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle(3, 405, 1500);
            Vehicle v2 = new Vehicle(v);
            v.DisplayInformation();
            Console.WriteLine(v2.ToString());
            Console.Read();
        }
    }
}
