public class Solution

{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen=new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            bool added = seen.Add(nums[i]);
            if(!added)
            {
                return true;
            }
        }
        return false;
    }
}