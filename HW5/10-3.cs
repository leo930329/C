using System;

namespace CarPrice
{
    public interface IPrice
    {
        double GetPrice();
    }

    public class Car : IPrice
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Car(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }

        public string GetName()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car("ktm1290", 960000);
            Console.WriteLine("車名: " + Car.GetName());
            Console.WriteLine("價格: " + Car.GetPrice() + " 元");
        }
    }
}