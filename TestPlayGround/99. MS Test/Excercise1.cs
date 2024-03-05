using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlayGround._99._MS_Test
{
    public class Excercise1
    {
        public int Solution(string S)
        {
            //replace strings by actual numbers
            S = S.Replace("one", "1");
            S = S.Replace("two", "2");
            int num = 0;
            int? previousNum = null;
            bool? operand = null; // false  to substract, true to add

            foreach (var item in S)
            {
                //is this an number ? lets store it
                if (char.IsNumber(item))
                {
                    num = int.Parse(item.ToString());
                    //is first number ? lets store in "previous" variable to compute later
                    if (previousNum == null)
                    {
                        previousNum = num;
                    }
                }
                else
                {
                    //find which tipe of operator it is.
                    operand = item == '+';
                    continue;
                }

                //compute the result
                if (previousNum != null && operand != null)
                {
                    previousNum = operand.Value ? previousNum + num : previousNum - num;
                }
            }

            return previousNum.Value;
        }
    }
}
