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
        public double WetMass; //in Kg
        public double MassLoss;
        public double Drag; //drag coefficient of leading tip(s)
        public double Thrust;
        public string Name;
        public string EngineType;
        public double BurnTime;
        public double FuelMass;

        public Rocket() //control conditions
        {
            WetMass = 2341;
            MassLoss = 119.32;
            Drag = 0.3;
            Thrust = 162909;

            Engine f = new Flea();

            Name = f.GetName();
            EngineType = f.GetEngineType();
            BurnTime = f.GetBurnTime();
        }

        public Rocket(double mass, Engine engine, TipShape tip) //overload
        {
            WetMass = mass;
            
            
            //DryMass = dryMass;

            Drag = tip.GetDrag();
            Thrust = engine.GetThrust();
            Name = engine.GetName();
            EngineType = engine.GetEngineType();
            BurnTime = engine.GetBurnTime();
            FuelMass = engine.GetFuelMass();
            MassLoss = engine.GetFuelMass() / engine.GetBurnTime();
        }
        //-------------------------------------METHODS-------------------------------------------
        public void rocketStats()
        {
            Console.WriteLine($"The mass of the rocket is {WetMass}kg/{WetMass / 1000} tons");
            Console.WriteLine($"This rocket is powered by a {Name} {EngineType}");
            Console.WriteLine($"This stage will burn for {Math.Round(BurnTime,2)} seconds");
            Console.WriteLine($"The final velocity is roughly... {Math.Round(CalculateFinalVelocity(),2)} m/s ");
        }

        public double CalculateFinalVelocity()
        {
            for (int i = 0; i < BurnTime; i++)
            {
                Velocity = Velocity + ((Thrust - (WetMass - MassLoss * i) * G - (Drag * (Velocity * Velocity)) + (MassLoss * Velocity)) / (WetMass - (MassLoss * i)));
            }
            return Velocity;
            //Console.WriteLine(Velocity);
        }

    }
}
