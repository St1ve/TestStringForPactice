using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldMac = "replacig 00-00-00-00-00-00";
            string newMac = "1C-6F-65-24-33-F8";

            Console.WriteLine("Before replace");
            Console.WriteLine("OldMac:{0}", oldMac);
            Console.WriteLine("NewMac:{0}\n", newMac);

            oldMac = Regex.Replace(oldMac, "..-..-..-..-..-..", ",");

            Console.WriteLine("After replace");
            Console.WriteLine("OldMac:{0}", oldMac);
            Console.WriteLine("NewMac:{0}", newMac);

            Console.ReadKey();
        }
    }
}
