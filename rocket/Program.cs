using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    public class Rocket
    {
        //=======================================CONSTRUCTORS=======================================
        public double G = 9.81;
        public double Velocity = 0;
        public double Mass;
        public double MassLoss;
        public double Time;
        public double Drag;
        public double Thrust;

        public Rocket() //control conditions
        {
            Mass = 1396;
            MassLoss = 131.25;
            Time = 1;
            Drag = 0.3;
            Thrust = 162909;
        }

        public Rocket(double mass, double massLoss, double time, double drag, Engine engine) //overload
        {
            Mass = mass;
            MassLoss = massLoss;
            Time = time;
            Drag = drag;
            Thrust = engine.DisplayThrust();
        }
        //=========================================METHODS=============================================
        public void rocketStats()
        {
            Console.WriteLine($"The mass of the rocket is {Mass}kg/{Mass/1000} tons");
            
        }

        public void FinalVelocity()
        {
            for(int i = 0; i < Time; i++)
            {
                Velocity = Velocity + ((Thrust - (Mass - MassLoss * i) * G - (Drag*(Velocity*Velocity)) + (MassLoss*Velocity)) / (Mass - (MassLoss*i)));
            }
            Console.WriteLine(Velocity);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine f = new Flea();

            Rocket r = new Rocket(1, 1, 1, 1, f);
            Console.WriteLine(r.Thrust);
        }
    }
}
