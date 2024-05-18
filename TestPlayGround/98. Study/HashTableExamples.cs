using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlayGround._98._Study
{
    public class HashTableExamples
    {
        public void DoWork()
        {
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
                hashtable.Add(i, i * i * i);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

            if (hashtable.ContainsKey(6500))
            {
                Console.WriteLine("Contains 6500");
            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] response = null;
            for (int i = 0; i <= nums.Length; i++)
            {
                Console.WriteLine("i:" + i);
                if (response == null)
                {
                    for (int k = 0; k <= nums.Length; k++)
                    {
                        Console.WriteLine("k:" + k);
                        if (i == k) continue;
                        if (nums[i] + nums[k] == target)
                        {
                            Console.WriteLine("creating array: ");
                            response = new int[2] { i, k };
                            break;
                        }
                    }
                }
                else { break; }
            }

            

            return response;
        }
    }
}
