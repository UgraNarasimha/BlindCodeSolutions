using System;
namespace NeetCode
{
    public class Test
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> x = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (x.Contains(nums[i]))
                    return true;
                else
                    x.Add(nums[i]);

            }

            return false;
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (int i=0;i< ans.Length;i++)
                ans[i] = 1;

            int prefix = 1;

            for(int i=0;i<nums.Length;i++)
            {
                ans[i] *= prefix;
                prefix *= nums[i];
            }

# Console.WriteLine("----first pass-----");
# foreach (int j in ans)
#            Console.WriteLine(j);

            int postfix = 1;
            for (int i = nums.Length-1; i >= 0; i--)
            {
                ans[i] *= postfix;
                postfix *= nums[i];

            }

            //Console.WriteLine("----second pass-----");
            //foreach (int j in ans)
            //    Console.WriteLine(j);

            return ans;
        }
    }
}

