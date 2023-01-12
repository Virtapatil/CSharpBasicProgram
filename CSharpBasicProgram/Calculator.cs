using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProgram
{
    /// <summary>
    /// Calculator class created to perform arithmetic operations
    /// </summary>
    internal class Calculator
    {
        //instance variables
        public int first, second, Sum;
        public Calculator(int firstNumb,int secondNumb) 
        {
            this.first = firstNumb;
            this.second = secondNumb;
        }
        /// <summary>
        /// Addition of 2 numbers to get sum
        /// </summary>
        public void Addition()
        {
            Sum = first + second;
            Console.WriteLine("Sum:" + Sum);
        }
    }
}
