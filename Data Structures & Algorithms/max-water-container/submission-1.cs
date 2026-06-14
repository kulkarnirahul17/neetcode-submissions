public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        //Two pointers, left and right
        int left = 0, right = heights.Length - 1;
      
        while(left < right) {
            int height = Math.Min(heights[left], heights[right]);
            int width = right - left;
            int currArea = width * height;
            maxArea = Math.Max(currArea, maxArea);
            
            if(heights[left] < heights[right])
                left ++;
            else 
                right --;
        }
        return maxArea;
    }
}
