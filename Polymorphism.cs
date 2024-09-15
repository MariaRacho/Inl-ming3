namespace Arv_uppgift
{
    // Polymorphism exempel

    public class animal
    {
        public string Name;

        public string Vikt;

        public void Running()
        {
            Console.WriteLine("Animal running")
        }
    }

    public class Horse : animal
    {
        public override void Running()
        {
            Console.WriteLine("Horse Running");
        }
    }

    public class Dog : animal
    {
        public override void Running()
        {
            Console.WriteLine("Dog Running");
        }
    }
}
