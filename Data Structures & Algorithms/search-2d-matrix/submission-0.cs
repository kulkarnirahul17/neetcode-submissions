public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length; 
        int cols = matrix[0].Length;

        int top = 0, bot = rows -1;
        int candRow = 0;
        while(top <= bot) {
            candRow = (top + bot) / 2;
            if(target > matrix[candRow][cols -1]) // number greater than current rows last element, search down
            {
                top = candRow + 1;
            }
            else if (target < matrix[candRow][0]) {
                bot = candRow -1;
            }
            else
                break;
        }

        if(!(top <= bot))
            return false;
        
        int l = 0, r = cols -1;
        while(l <= r) {            
            int m = (l + r)/ 2;
            if(target == matrix[candRow][m]) {
                return true;
            }
            else if (target < matrix[candRow][m]) 
            {
                r = m -1;
            }
            else 
            {
                l = m + 1;
            }
        }            
        
        return false;
       
    }

    
}
