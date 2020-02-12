using System;

namespace Polymorphism
{
    public class Toyota
    {
        public virtual void Details(){
            Console.WriteLine("Toyota");
        }
    }

    public class Yaris : Toyota
    {
        public override void Details() {
            Console.WriteLine("Yaris");
        }
    }

    public class Avanza : Toyota
    {
        public override void Details(){
            Console.WriteLine("Avanza");
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Toyota[] toyotaCars = new Toyota[3];
            toyotaCars[0] = new Toyota();
            toyotaCars[1] = new Yaris();
            toyotaCars[2] = new Avanza();

            foreach (Toyota car in toyotaCars){
                car.Details();
            }

            Console.ReadLine();
        }
    }
}
