using ConsoleApp10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_1_det_2022
{
    internal class person
    {
        static void Main()
        {
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (age > 120)
                {
                    throw new InvalidAgeException("Please check the entered age:");
                }
                else
                {
                    Console.WriteLine($"Age is {age}");
                }

            }
            catch (InvalidAgeException i)
            {
                Console.WriteLine(i.Message);


            }
            catch (Exception e)
            {

            }
        }
    }
}
