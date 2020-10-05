namespace ConsoleApp10
{
    public class Program
    {
        /* theory
        private int mSomeMember = 3;
        public int MyProperty { get; set; } = 10;

        public int MyPropertyExtended
        {
            get => mSomeMember;
            set
            {
                if (value > 0)
                    mSomeMember = value;
            }
        }

        public Program()
        {
            mSomeMember = 5;
        }
        
        static void Main(string[] args)
        {
            var program = new Program();

            var car = new Car();

            //car.WheelSize = 10;

            System.Console.WriteLine(car.WheelSize);
        }
        */
        public static void Main(string[] args)
        {
            var mazda = new Mazda();
            var porsche = new Porsche();

            var car = new Car();

            SomeFunction(mazda);
        }

        public static void SomeFunction(Car car) //referency, if you change car, you change mazda
        {

        }
    }

    public class Car //internal - like public, but access only in this Solution
    {
        protected int Length { get; set; }
        public int TopSpeed { get; set; }
        public int WheelSize { get; private set; } = 15;

        public void Drive()
        {

        }
    }

    public class Porsche : Car
    {

    }

    public class Mazda : Car
    {
        public int SomeMazdaSpecificProperty { get; set; }
    }
}
