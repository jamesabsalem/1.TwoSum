// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = new int[] { 3,2,4};
var target = 6;
var twoSum = TwoSum(nums, target);
twoSum.ToList().ForEach(x => Console.WriteLine(x));


static int[] TwoSum(int[] nums, int target)
{
    int[] results = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                results[0] = i;
                results[1] = j;
            }
        }
    }
    return results;
}