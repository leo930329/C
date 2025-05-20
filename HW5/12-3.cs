using System;

class UnitConverter
{
    // 委派型別：接收 double（英吋），回傳 double（轉換後單位）
    public delegate double ConvertFromInches(double inches);

    // 英吋轉英尺
    public static double InchesToFeet(double inches)
    {
        return inches / 12.0;
    }

    // 英吋轉英碼
    public static double InchesToYards(double inches)
    {
        return inches / (3.0 * 12.0);
    }

    static void Main()
    {
        Console.WriteLine("請輸入英吋數值：");
        double inputInches = double.Parse(Console.ReadLine());

        Console.WriteLine("請選擇轉換方式：");
        Console.WriteLine("1. 英吋 轉 英尺");
        Console.WriteLine("2. 英吋 轉 英碼");

        string choice = Console.ReadLine();

        ConvertFromInches converter;

        if (choice == "1")
        {
            converter = InchesToFeet;
        }
        else if (choice == "2")
        {
            converter = InchesToYards;
        }
        else
        {
            Console.WriteLine("無效選項！");
            return;
        }

        double result = converter(inputInches);
        Console.WriteLine($"轉換後的數值為：{result}");
    }
}
