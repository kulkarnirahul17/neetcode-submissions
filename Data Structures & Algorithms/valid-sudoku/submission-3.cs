public class Solution {
    public bool IsValidSudoku(char[][] board) {        
        int rows = board.Length;
        int cols = board[0].Length;

        int i = 0, j = 0;
        // Check if the rows are valid.
        for (i = 0; i < rows; i++)
        {
            HashSet<char> rowsHash = new();
            for (j = 0; j < cols; j++)
            {
                char cell = board[i][j];
                if (cell == '.')
                    continue;

                if (rowsHash.Contains(cell))
                    return false;
                rowsHash.Add(cell);
            }
        }

        // Check if the cols are valid.
        for (j = 0; j < cols; j++)
        {
            // For each col, create a HashSet
            HashSet<char> colsHash = new();
            for (i = 0; i < rows; i++)
            {
                char cell = board[i][j];
                if (cell == '.')
                    continue;

                if (colsHash.Contains(cell))
                    return false;
                colsHash.Add(cell);
            }
        }

        // Now check for each grid
        i = 0;
        while (i < rows)
        {
            j = 0;
            while (j < cols)
            {
                HashSet<char> grid = new();
                for (int iOff = i; iOff < i + 3; iOff++)
                    for (int jOff = j; jOff < j + 3; jOff++)
                    {
                        char cell = board[iOff][jOff];
                        if (cell == '.')
                            continue;

                        if (grid.Contains(cell))
                            return false;
                        grid.Add(cell);
                    }
                j += 3;
            }
            i += 3;
        }
        
        // This means that there were no duplicates found and hence return true
        return true;
    }
}
