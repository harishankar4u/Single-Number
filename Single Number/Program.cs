public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SingleNumber([1,2,2,3,3,1,4])); // output 4 because 4 is only one in the Array
    }
    public static int SingleNumber(int[] nums)
    {
        int res = 0;
        foreach (int num in nums)
        {
            res ^= num;
        }
        return res;
        //Dictionary<int, int> map = new();
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (map.ContainsKey(nums[i]))
        //    {
        //        map[nums[i]] += 1;
        //    }
        //    else
        //    {
        //        map[nums[i]] = 1;
        //    }
        //}
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (map[nums[i]] == 1)
        //    {
        //        return nums[i];
        //    }

        //}
        //return 0;
    }
}
