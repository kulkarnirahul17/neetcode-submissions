public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair = new int[position.Length][];
        for(int i =0; i < position.Length; i++) {
            pair[i] = new int[] { position[i], speed[i]};            
        }
        Stack<double> st = new();
        // Sort in descending order of positions.
        Array.Sort(pair, (a,b) => b[0].CompareTo(a[0]));
        foreach(var p in pair) {
            st.Push((double)(target - p[0]) / p[1]);
            if(st.Count >=2 && st.Peek()<= st.ElementAt(1)) {
                st.Pop();
            }
        }
        return st.Count;
    }
}
