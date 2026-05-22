using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    public abstract class Engine
    {
        protected string Type;
        protected string Name;
        protected double Thrust;
        protected double Isp;
        protected double Mass;
        protected double DryMass;

        public virtual void DisplayStats()
        {

        }

        public virtual double DisplayThrust()
        {
            return -1;
        }
    }

    public class Flea : Engine
    {
        private new string Type = "solid rocket booster/SRB";
        private new string Name = "Flea";
        private new double Thrust = 162909; //newtons
        private new double Isp = 140;
        private new double Mass = 1; //placeholder
        private new double DryMass = 1; //Placeholder

        public override void DisplayStats()
        {
            Console.WriteLine($"This is the {Name} {Type}, it has a thrust of {Thrust} newtons, a specific impulse of {Isp}");
        }

        public override double DisplayThrust()
        {
            return Thrust;
        }
    }

}
