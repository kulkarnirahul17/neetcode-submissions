public class MinStack {
    Stack<int> numStack;
    Stack<int> minNumbersStack;

    public MinStack() {
        numStack = new();
        minNumbersStack = new();
    }
    
    // nums = 1,2,3,0,2
    // mins = 1,1,1,0,0
    public void Push(int val) {
        numStack.Push(val);
        if(minNumbersStack.Count == 0 || val < minNumbersStack.Peek() )
        {
            minNumbersStack.Push(val);
        }
        else{
            minNumbersStack.Push(minNumbersStack.Peek());
        }
    }
    
    public void Pop() {
        numStack.Pop();
        minNumbersStack.Pop();
    }
    
    public int Top() {
        return numStack.Peek();
    }
    
    public int GetMin() {
        return minNumbersStack.Peek();
    }
}
