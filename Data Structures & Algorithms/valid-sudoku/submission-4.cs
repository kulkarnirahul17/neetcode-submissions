public class Solution {
    public bool IsValidSudoku(char[][] board) {        
        int rows = board.Length;
        int cols = board[0].Length;

        int i = 0, j = 0;
        // Check if the rows are valid.
        for(i = 0; i < rows; i++) {
            HashSet<int> rowsHash = new();            
            for(j = 0; j < cols; j++) {
                int.TryParse(board[i][j].ToString(), out int num);
                if(num == 0) continue;
                if(rowsHash.Contains(num))
                    return false;
                rowsHash.Add(num);
            }            
        }

        // Check if the cols are valid.
        for (j = 0; j < cols; j++) {
            // For each col, create a HashSet
            HashSet<int> colsHash = new();
            for (i = 0; i < rows; i++) {
                int.TryParse(board[i][j].ToString(), out int num);
                if(num == 0) continue;
                if(colsHash.Contains(num))
                    return false;
                colsHash.Add(num);
            }
        }

        // Now check for each grid
        i = 0;
        while(i < rows) {
            j = 0;
            while(j < cols) {
                HashSet<int> grid = new();
                for(int iOff = i; iOff < i + 3; iOff++)
                    for(int jOff = j; jOff < j + 3; jOff++) {
                        int.TryParse(board[iOff][jOff].ToString(), out int num);
                        if(num == 0) continue;
                        if(grid.Contains(num))
                            return false;
                        grid.Add(num);
                    }    
                j += 3;
            }
            i +=3;
        }
        
        // This means that there were no duplicates found and hence return true
        return true;
    }
}
