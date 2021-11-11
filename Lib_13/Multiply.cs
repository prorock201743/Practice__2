using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibMas;

namespace Lib_13
{
    public static class Multiply
    {
        public static string MultiplicationOfMas(this MyArray myarray)
        {
            int multiplication = 1;

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] > 2)
                    multiplication *= myarray[i];
            }
            return multiplication.ToString();
        }
    }
}
