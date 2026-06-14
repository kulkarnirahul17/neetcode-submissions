public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new();
        foreach(char c in s) {
            // If it is opening parenthesis, add to stack
            if(c == '(' || c == '{' || c == '[') 
            {
                st.Push(c);
            }
            else
            {
                if(st.Count == 0)
                    return false;

                char top = st.Peek();
               
                if((c == ')' && top != '(') || (c == ']' && top != '[') || 
                    (c == '}' && top != '{'))
                    return false;
                st.Pop();
            }
        }
        return st.Count == 0;
    }
}
