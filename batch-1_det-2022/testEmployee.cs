using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class testEmployee
    {
        public static void Main()
        {
            employee emp = employee(22830, "indu", "belgum", 7656, 8674765, 33500);
            Console.WriteLine($"employee sal{emp.GetNetSalary()}");
            Console.WriteLine($"employee sal{emp.Get()}");
        }
}
