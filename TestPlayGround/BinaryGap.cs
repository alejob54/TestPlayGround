namespace TestPlayGround
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            // Implement your solution here
            string binary = Convert.ToString(N, 2);

            //Validate if the binary contains 0 to give a faster response 
            if (binary.Contains("0"))
            {
                //List to store all the gaps
                List<int> Gaps = new List<int>();
                
                //Flag to handle sequences (gaps)
                bool SequenceStarted = false;
                int max = 0;
                for (int i = 0; i < binary.Length; i++)
                {
                    //Validate if the number is 1 or 0
                    if (binary[i].ToString().Equals("1"))
                    {
                        //Sequence already started, so we need to end the gap count.
                        if (SequenceStarted)
                        {
                            if (max != 0)
                            {
                                Gaps.Add(max);
                                max = 0;
                            }
                            continue;
                        }
                        else
                        {
                            SequenceStarted = true;
                        }
                    }
                    else //Value is 0
                    {
                        if (SequenceStarted)
                        {
                            max++;
                        }
                    }
                }
                return Gaps.Any() ? Gaps.Max() : 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
