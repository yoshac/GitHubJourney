public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> frequency1 = new();
       
        
        for (int i = 0; i < s.Length; i++)
        {
            if (frequency1.ContainsKey(s[i]))
            {
                frequency1[s[i]]++;
            }
            else 
            { 
                frequency1[s[i]] = 1;
            }
               
        }
        for (int i = 0; i < t.Length; i++)
        {
            if (frequency1.ContainsKey(t[i]) && frequency1[t[i]]>0)
            {
                frequency1[t[i]]--;
            }
            else
            {
                return false;
            }
            
        }
        return true;
    }
}