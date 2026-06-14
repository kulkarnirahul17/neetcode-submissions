public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> tempStack = new();
        int[] result = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++) {
            while(tempStack.Count > 0 && temperatures[tempStack.Peek()] < temperatures[i]) {
                var prevIndex = tempStack.Pop();
                result[prevIndex] = i - prevIndex;
            }
            tempStack.Push(i);
        }
        return result;
    }
}
