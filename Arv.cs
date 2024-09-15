namespace Arv_uppgift
{
    // Arv exempel 

    // Detta blir huvud klassen
    public class Car
    {
       // Atributer av classen car 
        public string modell;

        public int horsepower;

       // Metoder av classen car

        public void drive()
        {
            Console.WriteLine("This car is driving")
        }

        public void brake()
        {
            Console.WriteLine("This car is braking")
        }
    }
        // Subklasser som erver från car
        public class Ferrari : Car
    {
        // Nya atributer + alla atributer från car
        public string F40;

        // Nya metoder + alla metoder från car
        public new void drive()
        {
            Console.WriteLine("This car dose not drive");
        }
    }
}
