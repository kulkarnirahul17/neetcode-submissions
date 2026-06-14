public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new();
        
        foreach(string token in tokens) 
        {
            if(int.TryParse(token, out int num)) {
                st.Push(num);
            }
            else 
            {
                // not a number, hence an operand               
                if(st.Count >= 2) {
                    int num2 = st.Pop();
                    int num1 = st.Pop();
                    
                    int res = getOperationResult(num1, num2, token);
                    st.Push(res);
                }
            }
        }

        return st.Count > 0 ? st.Pop() : int.MinValue;
    }

    private int getOperationResult(int num1, int num2, string operation) 
    {         
        switch(operation) 
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*" :
                return num1 * num2;
            case "/": 
                return num1 / num2;                                        
        }
        return 0;
    }
}
