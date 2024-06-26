﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        int xPos = 10;
        int yPos = 8;
        Console.SetCursorPosition(85, 53);
        Console.Write("Exit");
        while (true)
        {
            Console.Clear();
            var x = Console.WindowWidth;
            var y = Console.WindowHeight;
            if (x > 120)
            {
                Console.SetCursorPosition(120, 1);
            }
            Console.WriteLine($"xPos: {xPos}, yPos: {yPos}");
            DrawRows(15, 75, 100);
            DrawColumns(25, 125, 60);
            DrawRabbit(xPos, yPos);
            DrawExit();
            var key = Console.ReadKey();
            MoveRabbit(key.Key, ref xPos, ref yPos);
            Console.CursorVisible = false;


        }
    }
    public static void DrawExit()
    {
        Console.SetCursorPosition(85, 53);
        Console.Write("Exit");
    }
    public static void DrawRabbit(int xPos, int yPos)
    {
        Console.SetCursorPosition(xPos, yPos);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("RABBIT");
        Console.CursorVisible = false;
    }
    public static void MoveRabbit(ConsoleKey key, ref int xPos, ref int yPos)
    {
        switch (key)
        {
            case ConsoleKey.LeftArrow:
                if (xPos - 25 > 0)
                {

                    xPos -= 25;
                }
                break;
            case ConsoleKey.RightArrow:
                if (xPos + 25 < 100)
                {

                    xPos += 25;
                }
                break;
            case ConsoleKey.UpArrow:
                if (yPos - 15 > 0)
                {

                    yPos -= 15;
                }
                break;
            case ConsoleKey.DownArrow:
                if (yPos + 15 < 60)
                {

                    yPos += 15;
                }
                break;
            default:
                break;
        }
    }
    //public static void Area(int width, int height)
    //{
    //    for (int i = 0; i < width; i++)
    //    {
    //        Console.Write("-");
    //    }
    //    for (int i = 0; i < width; i++)
    //    {
    //        Console.SetCursorPosition(i, height);
    //        Console.Write("-");
    //    }
    //    for (int i = 1; i < height; i++)
    //    {
    //        Console.SetCursorPosition(0, i);
    //        Console.Write("|");
    //    }
    //    for (int i = 1; i < height; i++)
    //    {
    //        Console.SetCursorPosition(width - 1, i);
    //        Console.Write("|");
    //    }

    //}
    public static void DrawRows(int rowHeight, int heigth, int width)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        int rowCount = heigth / rowHeight;

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.SetCursorPosition(j, i * rowHeight);
                Console.Write("*");
            }

        }
    }
    static void DrawColumns(int columnWidth, int witdh, int height)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        int colsCount = witdh / columnWidth;
        for (int i = 0; i < colsCount; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Console.SetCursorPosition(i * columnWidth, j);
                Console.WriteLine("*");
            }
        }
    }
}