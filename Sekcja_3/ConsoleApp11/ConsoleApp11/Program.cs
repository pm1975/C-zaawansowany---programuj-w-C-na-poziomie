using System;

namespace ConsoleApp11
{
    class Program
    {
        public static void Main(string[] args)
        {
            var mazda = new Mazda(100);
            var porsche = new Porsche(100);

            SomeFunction(mazda);
        }

        public static void SomeFunction(Car car) //referency, if you change car, you change mazda
        {

        }
    }

    public abstract class Car 
    {
        public abstract string Name { get; }
        protected int Length { get; set; }
        public int TopSpeed { get; set; }
        public int WheelSize { get; private set; } = 15;

        public abstract void Drive();

        public Car(int topSpeed)
        {
            TopSpeed = topSpeed;
            Console.WriteLine("I am car constructor");
        }

    }

    public sealed class Porsche : Car
    {
        public override string Name => "I am Porsche";

        public override void Drive()
        {
            throw new NotImplementedException();
        }
        public Porsche(int topSpeed) : base(topSpeed)
        {
            Console.WriteLine("I am Porsche constructor");
        }
    }

    public class Mazda : Car
    {
        public override string Name => "I am Mazda";

        public int SomeMazdaSpecificProperty { get; set; }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
        public Mazda(int topSpeed) : base(topSpeed)
        {
            Console.WriteLine("I am Mazda constructor");
        }
    }
}
