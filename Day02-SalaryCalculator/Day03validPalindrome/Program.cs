using System;


public class Solution
{
    public static void Main()
    {
        bool out1 = IsPalindrome("hjgjhgjh3,W");
        Console.WriteLine(out1);
        Console.ReadLine();
        public static bool IsPalindrome(string s)
    {
        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
}
        
    


      
       

    
