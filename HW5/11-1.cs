using System;

class MyMath
{
    // 過載方法：計算 int 的平方
    public int Cube(int h0)
    {
        return h0 * h0;
    }

    // 過載方法：計算 double 的平方
    public double Cube(double h0)
    {
        return h0 * h0;
    }

    // 過載方法：傳入3個 int，找最小值
    public int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    // 過載方法：傳入4個 int，找最小值
    public int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}

class Program
{
    static void Main()
    {
        MyMath math = new MyMath();

        // 測試 Cube 方法
        Console.WriteLine("Cube of 3 (int): " + math.Cube(3));         // 9
        Console.WriteLine("Cube of 2.5 (double): " + math.Cube(2.5));  // 6.25

        // 測試 MinElement 方法
        Console.WriteLine("Min of 3, 7, 10: " + math.MinElement(3, 7, 10));             // 3
        Console.WriteLine("Min of 15, 5, 8, 9: " + math.MinElement(15, 5, 8, 9));     // 8
    }
}

