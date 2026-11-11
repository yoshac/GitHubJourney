public class Solution
{
    public int Search(int[] nums, int target)
    {
        int binaryindex;
        int left = 0;
        int right = nums.Length - 1;

        while (right >= left )
        {
            binaryindex = left + ((right - left) / 2);
            if ((nums[binaryindex]) < target)
            {
                left = binaryindex+1;
            }
            else if ((nums[binaryindex]) > target)
            {
                right = binaryindex-1;
            }
            else if ((nums[binaryindex]) == target)
            {
                return binaryindex;
            }


        }
        
        
        return -1;
    }
}