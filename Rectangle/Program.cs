using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Rectangle rectangle1 = new Rectangle { Width = 10, Height = 5};

Rectangle rectangle2 = new Rectangle { Width = 7, Height = 7 };

Rectangle rectangle3 = new Rectangle();


Console.WriteLine("=== 사각형 1 ===");
rectangle1.PrintResult();
Console.WriteLine();

Console.WriteLine("=== 사각형 2 ===");
rectangle2.PrintResult();
Console.WriteLine();

Console.WriteLine("=== 사각형 3 ===");
rectangle3.PrintResult();


class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    public int Area => Width * Height;

    public int Perimeter => 2 * (Width + Height);

    public bool IsSquare => Width == Height;


    public void PrintResult()
    {
        Console.WriteLine($"가로: {Width}, 세로: {Height}");
        Console.WriteLine($"넓이: {Area}");
        Console.WriteLine($"둘레: {Perimeter}");
        Console.WriteLine($"정사각형: {IsSquare}");
    }
}
