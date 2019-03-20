using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args);
        {

}
              static void ShowNamesParts()

        {
            string[] names = { "Alice Everton", "Robert T. Sharp", "Eva Candace Truesdale Olivier", "Mojo", "Wally R. Droid" };
            foreach (string name in names)
            {
                Console.Write("Name: {0} --", name);
                Console.Write("{0} parts --", name.Split(' ').Length);
                char separator = ' ';
                foreach( string part in name.Split(' '))
                {
                    Console.Write("{0}{1}", separator, part);
                    separator = ',';
                }
                Console.WriteLine();
            }
        }
    }
}
