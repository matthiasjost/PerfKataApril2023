namespace PerfKataApril2023;

public static class StringExtensions
{
    public static int LargestProduct(this string grid)
    {
        ParseGrid(grid, out int[,] gridTable);

        int largest = 0;

        int largestProductHorizontal = FindLargestHorizontal(gridTable);
        int largestProductVertical = FindLargestVertical(gridTable);
        int largestProductDiagonal = FindLargestDiagonal(gridTable);
        
        largest = Math.Max(largestProductHorizontal, Math.Max(largestProductVertical, largestProductDiagonal));
        return largest;
    }

    private static int FindLargestDiagonal(int[,] gridTable)
    {
        int largestProduct = 0;

        for (int r = 1; r < gridTable.GetLength(0) - 3; r++)
        {
            for (int c = 0; c < gridTable.GetLength(1) - 3; c++)
            {
                int product = gridTable[r, c] * gridTable[r + 1, c + 1] * gridTable[r + 2, c + 2] * gridTable[r + 3, c + 3];

                if (product > largestProduct)
                {
                    largestProduct = product;
                }
            }
        }
        return largestProduct;
    }

    private static int FindLargestVertical(int[,] gridTable)
    {
        int largestProduct = 0;
        for (int r = 1; r < gridTable.GetLength(0) - 3; r++)
        {
            for (int c = 0; c < gridTable.GetLength(1); c++)
            {
                int product = gridTable[r, c] * gridTable[r + 1, c] * gridTable[r + 2, c] * gridTable[r + 3, c];

                if (product > largestProduct)
                {
                    largestProduct = product;
                }
            }
        }

        return largestProduct;
    }

    private static int FindLargestHorizontal(int[,] gridTable)
    {
        int largestProduct = 0;

        for (int r = 1; r < gridTable.GetLength(0); r++)
        {
            for (int c = 0; c < gridTable.GetLength(1) - 3; c++)
            {
                int product = gridTable[r, c] * gridTable[r, c + 1] * gridTable[r, c + 2] * gridTable[r, c + 3];

                if (product > largestProduct)
                {
                    largestProduct = product;
                }
            }
        }
        return largestProduct;
    }


    private static void ParseGrid(string grid, out int[,] gridTable)
    {
        string[] allRowStrings = grid.Split("\n");
        int numCols = allRowStrings[1].Split(" ").Length;
        int numRows = allRowStrings.Length;

        gridTable = new int[numRows, numCols];

        for (int r = 1; r < allRowStrings.Length; r++)
        {
            string[] rowStringTemp = allRowStrings[r].Split(" ");

            for (int c = 0; c < numCols; c++)
            {
                gridTable[r, c] = int.Parse(rowStringTemp[c]);
            }
        }
    }
}