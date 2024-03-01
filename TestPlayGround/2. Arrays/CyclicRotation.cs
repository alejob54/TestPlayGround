///This code was created by Alejandro Bastidas Ospina
/// https://github.com/alejob54

namespace TestPlayGround
{
    /*  An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).

        The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

        Write a function:

        class Solution { public int[] solution(int[] A, int K); }

        that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

        For example, given

            A = [3, 8, 9, 7, 6]
            K = 3
        the function should return [9, 7, 6, 3, 8]. Three rotations were made:

            [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
            [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
            [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
        For another example, given

            A = [0, 0, 0]
            K = 1
        the function should return [0, 0, 0]

        Given

            A = [1, 2, 3, 4]
            K = 4
        the function should return [1, 2, 3, 4]

        Assume that:

        N and K are integers within the range [0..100];
        each element of array A is an integer within the range [−1,000..1,000].
    */
    public class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        {
            //Edge cases
            //1. All the numbers inside A, are equal
            if (A.Distinct().Count() == 0) { return A; }

            //2. The number of items inside A, matches with the number of times it needs to be rotated
            if (A.Length == K) { return A; }

            //3. There's only one element
            if (A.Length == 1) { return A; }

            //4. None of above :)
            //Array to store the rotated items
            int[] B = new int[A.Length];

            //int[] C = new int[A.Length];
            A.CopyTo(B, 0);

            for (int i = 0; i < K; i++)
            {
                B[0] = A[A.Length - 1];
                for (int j = 1; j <= A.Length - 1; j++)
                {
                    B[j] = A[j-1];
                }

                B.CopyTo(A, 0);
            }

            return B;
        }
    }
}
