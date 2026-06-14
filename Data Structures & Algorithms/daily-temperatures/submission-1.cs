public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> st = new();
        int[] result = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++) {
            while(st.Count > 0 && temperatures[st.Peek()] < temperatures[i]) {
                int popped = st.Pop();
                result[popped] = i - popped;
            }
            st.Push(i);
        }
        return result;
    }
}
