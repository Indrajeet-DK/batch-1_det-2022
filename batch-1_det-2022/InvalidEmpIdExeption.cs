
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class InvalidEmpIDExeption : Exception
    {

        public InvalidEmpIDExeption(string msg) : base(msg)
        {

        }

    }
}
