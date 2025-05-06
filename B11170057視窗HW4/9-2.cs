using System;

public class Box
{
    // 成員變數
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }

    // 建構子
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    // 計算體積
    public double Volume()
    {
        return Width * Height * Length;
    }

    // 計算表面積：2*(W*H + W*L + H*L)
    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
    /*+----------------+
|      Box       |
+----------------+
| - Width: double|
| - Height: double|
| - Length: double|
+----------------+
| + Box(width: double, height: double, length: double) |
| + Volume(): double |
| + Area(): double   |
+----------------+
*/
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5.0, 2.0, 8.0);

            Console.WriteLine("體積：" + box.Volume());
            Console.WriteLine("表面積：" + box.Area());
        }
    }
   
}

