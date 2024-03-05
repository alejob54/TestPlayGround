using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlayGround._99._MS_Test
{
    public class Excercise2
    {
        public bool Solution(int[] A)
        {

            // Count the number of odd and even integers
            int EvenNumbers = 0;
            int NotEvenNumbers = 0;

            foreach (var number in A) {
                if (number % 2 != 0)
                {
                    NotEvenNumbers = NotEvenNumbers + 1;
                }
                else
                {
                    EvenNumbers = EvenNumbers + 1;
                }
            }

            if (NotEvenNumbers == EvenNumbers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
