public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int rows = board.Length;
        int cols = board[0].Length;
        // First check row by row, if there are duplicates        
        for(int rowNum = 0; rowNum < rows; rowNum ++) 
        {
            HashSet<int> rowSet = new();
            for(int colNum = 0; colNum < cols; colNum ++) 
            {
                int.TryParse(board[rowNum][colNum].ToString(), out int val);
                if(rowSet.Contains(val)) 
                {
                    return false;
                }
                else if (val > 0) 
                {
                    rowSet.Add(val);
                }
                
            }            
        }       

        // Then we check column by column if there are duplicates            
        for(int colNum = 0; colNum < cols; colNum ++) 
            {
                HashSet<int> colSet = new();
                for(int rowNum = 0; rowNum < rows; rowNum ++) 
                {
                int.TryParse(board[rowNum][colNum].ToString(), out int val);
                if(colSet.Contains(val)) 
                {
                    return false;
                }
                else if(val > 0) 
                {
                    colSet.Add(val);
                }                
            }            
        } 

        // Then divide the grid in 9, 3*3 blocks, check if there are duplicates in that
        for(int rowOffset = 0; rowOffset < rows; rowOffset += 3) {
            for(int colOffset = 0; colOffset < cols; colOffset += 3) {
                HashSet<int> blockOffset = new();
                for(int i =  0; i < 3; i++) 
                {
                    for(int j = 0; j < 3; j++) 
                    {
                        int gridRowNo = i + rowOffset;
                        int gridColNo = j + colOffset;
                        int.TryParse(board[gridRowNo][gridColNo].ToString(), out int val);
                        
                        if(blockOffset.Contains(val))
                            return false;
                        else if(val > 0)
                        {                            
                            blockOffset.Add(val);
                        }
                            
                    }
                }
            }
        }

        // This means that there were no duplicates found and hence return true
        return true;
    }
}
