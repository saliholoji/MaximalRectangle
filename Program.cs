using System.Diagnostics;

char[][] matrix = new char[][]
{
    new char[] {'1', '0', '1', '0', '0'},
    new char[] {'1', '0', '1', '1', '1'},
    new char[] {'1', '1', '1', '1', '1'},
    new char[] {'1', '1', '0', '0', '0'}
};

Console.Title = "Maximal Rectangle Problem - Salih Uysal | 2024";
PrintSudokuBoard(matrix);

Stopwatch stopwatch = Stopwatch.StartNew();

//Check Constrains
if (!controlConstrains(matrix))
{
    Console.WriteLine("The problem is faulty! It can't be solved, it doesn't follow the rules!");
    stopwatch.Stop();
    Console.WriteLine($"Runtime: {stopwatch.ElapsedMilliseconds} ms");
    return;
}

int result = MaximalRectangle(matrix,'1');
Console.WriteLine($"Result: {result}" );

stopwatch.Stop();

Console.WriteLine($"Runtime: {stopwatch.ElapsedMilliseconds} ms");
Console.ReadLine();


static void PrintSudokuBoard(char[][] matrix)
{
    Console.WriteLine(" -------------");
    Console.WriteLine(" P R O B L E M");
    Console.WriteLine(" -------------");

    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write(matrix[i][j] + " ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

int MaximalRectangle(char[][] matrix,char target)
{
    if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        return 0;

    int rows = matrix.Length;
    int cols = matrix[0].Length;
    int[] heights = new int[cols];
    int maxArea = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            // Update the histogram heights
            heights[j] = matrix[i][j] == target ? heights[j] + 1 : 0;
        }
        // Calculate the maximum area in the histogram
        maxArea = Math.Max(maxArea, MaxHistogramArea(heights));
    }
    Console.WriteLine("Target number: " + target);
    return maxArea;
}

int MaxHistogramArea(int[] heights)
{
    Stack<int> stack = new Stack<int>();
    int maxArea = 0;
    int index = 0;

    while (index < heights.Length)
    {
        if (stack.Count == 0 || heights[index] >= heights[stack.Peek()])
        {
            stack.Push(index++);
        }
        else
        {
            int height = heights[stack.Pop()];
            int width = stack.Count == 0 ? index : index - stack.Peek() - 1;
            maxArea = Math.Max(maxArea, height * width);
        }
    }

    while (stack.Count > 0)
    {
        int height = heights[stack.Pop()];
        int width = stack.Count == 0 ? index : index - stack.Peek() - 1;
        maxArea = Math.Max(maxArea, height * width);
    }

    return maxArea;
}

bool controlConstrains(char[][] matrix)
{
    bool result = false;

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            if ((matrix[i][j] == '0' || matrix[i][j] == '1') && (matrix.Length >= 0 && matrix[i].Length <= 200))
            {
                result = true;
            }
        }
    }

    return result;
}
