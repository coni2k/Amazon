namespace Amazon.Core.LeetCode.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum
    {
        public int[] Process(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var x = i + 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == target)
                        return new int[] { i, x };
                }
            }

            return null;
        }
    }
}
