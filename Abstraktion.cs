using System.Security.Cryptography.X509Certificates;

namespace Arv_uppgift
{
    //Abstraktion

    // Huvudklass abstrakt
    public abstract class MotorBike
    {
        public abstract void Drive();
    }

    // Subklass
    public class CrossBike : MotorBike
    {
        public override void Drive()
        {
            Console.WriteLine("MoterBike brakes");
        }
    }
}
