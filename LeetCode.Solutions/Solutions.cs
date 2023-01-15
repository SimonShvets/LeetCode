namespace LeetCode.Solutions
{
    public static class Solutions
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int a = target - nums[0];
            for (int i = result[0]; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    result[0]++;
                    i = result[0];
                    a = target - nums[i];
                }
                if (nums[i + 1] - a == 0)
                {
                    result[1] = i + 1;
                    return result;
                }
            }
            return result;
        }
    }
}
