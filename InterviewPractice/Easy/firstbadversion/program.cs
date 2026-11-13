public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
       
        int left = 1;
        int right = n;
        int midv=n;
        while (right >= left) 
        {

            midv = left +(( right - left) / 2);
            if (IsBadVersion(midv))
            {
                right = midv - 1;
            }
            else 
            {
                left = midv + 1;
            }
        }

        return left;
        
    }
}