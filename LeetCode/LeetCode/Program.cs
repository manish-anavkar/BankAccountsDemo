namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nums2 empty
            //int[] nums1 = { 1, 3, 8 };
            //int m = 3;
            //int[] nums2 = { };
            //int n = 0;

            // nums1 empty
            //int[] nums1 = { 0, 0, 0 };
            //int m = 0;
            //int[] nums2 = { 2, 5, 6 };
            //int n = 3;

            // nums1 and nums2 both not empty
            //int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            //int m = 3;
            //int[] nums2 = { 2, 5, 6 };
            //int n = 3;

            int[] nums1 = { 1, 2, 3, 8, 0, 0, 0, 0 };
            int m = 4;
            int[] nums2 = { 2, 5, 6, 7 };
            int n = 4;

            //int[] nums1 = { 2, 0 };
            //int m = 1;
            //int[] nums2 = { 1 };
            //int n = 1;

            Solution.Merge(nums1, m, nums2, n);
        }
    }

    public sealed class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int mPosition = m - 1;
            int nPosition = n - 1;
            int currentPosition = nums1.Length - 1;

            // nums2 is empty, no need to do anything
            if (nPosition >= 0)
            {
                // nums1 is empty, just copy nums2 to nums1
                if (mPosition < 0)
                {
                    for(int i = 0; i < nums2.Length; i++)
                    { nums1[i] = nums2[i]; }
                }
                else
                {
                    while(currentPosition >= 0)
                    {
                        // Already moved all nums1 but there are still nums2
                        if(nPosition >= 0 && mPosition < 0)
                        {
                            nums1[currentPosition] = nums2[nPosition];
                            nPosition--;
                            currentPosition--;
                        }    
                        else if (nPosition >= 0 && nums2[nPosition] >= nums1[mPosition])
                        {
                            nums1[currentPosition] = nums2[nPosition];
                            nPosition--;
                            currentPosition--;
                        }
                        else
                        {
                            nums1[currentPosition] = nums1[mPosition];
                            currentPosition--;
                            mPosition--;
                        }
                    }
                }
            }

            // Print nums1
            Console.WriteLine("Printing nums1:");
            for(int i = 0; i < nums1.Length; i++) { Console.WriteLine(nums1[i]); }
        }
    }
}
