﻿using ConsoleApp10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_1_det_2022
{
    internal class Animal1
    {
        public static  void Main()
        {
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new dog());
            Animals.Add(new cat());
            
            foreach (Animal a in Animals)
                Console.WriteLine(a.ToString());
        }
    }
}
