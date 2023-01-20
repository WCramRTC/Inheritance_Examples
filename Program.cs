namespace Inheritance_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Boat boat = new Boat();
            Air air = new Air();

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(vehicle);
            vehicles.Add(car);
            vehicles.Add(boat);
            vehicles.Add(air);

            List<Boat> boats = new List<Boat>();

            boats.Add(boat);
 

            foreach(Vehicle vehicle1 in vehicles)
            {
                Console.WriteLine(vehicle1.Move());
            }




            //Console.WriteLine(vehicle.Move());
            //Console.WriteLine(car.Move());
            //Console.WriteLine(boat.Float());
            //Console.WriteLine(air.Fly());







            Console.ReadKey();
        } // main

        public static void Example1()
        {
            // Polymorphism - Many Forms

            Vehicle vehicle = new Vehicle();
            object vObject = (object)vehicle;

            // C# and many languages are STRONGLY TYPED LANGUAGES
            // GetType()

            Console.WriteLine(vehicle.GetType().Name);

            // is - What is is?
            // is returns true or false, and checks if its a type of object

            // Everything is an object
            // Vehicle - Vehicle, and an object
            // Boat - Boat, and an object
            // When made Vehicle a CHILD of Boat
            // Vehicle was a boat, vehicle, and an object



            bool isABoat = vehicle is Boat;

            Console.WriteLine(isABoat);
        }

        public static void Example2()
        {
            // ------------------------------------------

            Vehicle v2 = new Vehicle();
            Car car = new Car();

            if (car is object)
            {
                Console.WriteLine("car is an object");
            }

            if (car is Vehicle)
            {
                Console.WriteLine("car is an Vehicle");

            }

            if (car is Car)
            {
                Console.WriteLine("car is an Car");
            }


        }

    } // class

} // namespace