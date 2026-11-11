public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        
        foreach (char ch in s)
        {
           
            if(ch == '(' ||  ch == '[' || ch == '{')
            { stack.Push(ch); }
            if (ch == ']' || ch == '}' || ch == ')')
            {
                if (stack.Count == 0)
                { return false; }
                switch (ch)
                {
                    case ']':
                        if (stack.Peek() == '[')
                        { stack.Pop(); }
                        else { return false; }
                        break;
                    case '}':
                        if (stack.Peek() == '{')
                        { stack.Pop(); }
                        else { return false; }
                        break;
                    case ')':
                        if (stack.Peek() == '(')
                        { stack.Pop(); }
                        else { return false; }
                        break;
                }
                    
               
                
            }

        }

        if (stack.Count == 0)
        { return true; }
        else { return false; }
    }
}