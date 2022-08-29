using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_1_det_2022
{

    internal class InvalidAgeException : Exception
    {


        public InvalidAgeException(string msg) : base(msg)
        {

        }

    }
}

