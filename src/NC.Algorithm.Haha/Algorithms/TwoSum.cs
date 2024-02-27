namespace NC.Algorithm.Haha.Algorithms;

public static class TwoSum
{
    /// <summary>
    /// 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
    /// 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
    /// 你可以按任意顺序返回答案。
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    public static int[] Func(int[] nums, int target)
    {
        var result = new int[2];
        var dict = new Dictionary<int, int>();
        for (int i = 0; i <= nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dict.ContainsKey(diff))
            {
                result = [dict[diff], i];
                break;
            }
            dict[nums[i]] = i;
        }
        return result;
    }
}