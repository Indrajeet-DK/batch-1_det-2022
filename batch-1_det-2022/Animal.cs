﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_1_det_2022
{
    public abstract class Animal
    {
        public string name { get; set; }

        public int age { get; set; }

        public string igender { get; set; }

        public abstract string ToString();
    }
}
