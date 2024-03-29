namespace ConstructorOfTheClass
{
    class Program
    {
        static void Main(String[] args)
        {
            //Creating an object
            Car car1 = new Car("Ford", "Mustang", 2022, "Brown");
            Car car2 = new Car("Lamborghini", "Aventador", 2024, "Brown");

            car1.Drive();
            car2.Drive();

        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        //Constructor
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}
