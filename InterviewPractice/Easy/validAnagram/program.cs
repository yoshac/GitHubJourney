public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Step 1: If lengths are different,
        // return false
        if(s.Length != t.Length) 
            return false;


        // Step 2: Convert s and t
        // into character arrays
        char[] si=s.ToCharArray();
        char[] ti = t.ToCharArray();


        // Step 3: Sort both arrays
        Array.Sort(si);
        Array.Sort(ti);

        string output1=new String(si);
        string output2 = new String(ti);

        return output1.Equals(output2);
         
        

        // Step 4: Compare the sorted results
        // and return true or false

    }
}