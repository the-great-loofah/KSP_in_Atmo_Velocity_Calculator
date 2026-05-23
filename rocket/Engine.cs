using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    //====================================PARENT CLASS===============================
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

        public virtual void DisplayThrust()
        {

        }

        public virtual double GetThrust()
        {
            return -1;
        }
    }
    //=====================================================SRB'S=================================================
    public class Flea : Engine
    {
        private new string Type = "solid rocket booster/SRB";
        private new string Name = "Flea";
        private new double Thrust = 162909; //newtons
        private new double Isp = 140;
        private new double Mass = 1500; //placeholder
        private new double DryMass = 450; //Placeholder

        public override void DisplayStats()
        {
            Console.WriteLine($"This is the {Name} {Type}, it has a thrust of {Thrust} newtons, a specific impulse of {Isp}");
        }

        public override void DisplayThrust()
        {
            Console.WriteLine($"This Booster has a thrust of {Thrust}");
        }

        public override double GetThrust()
        {
            return Thrust;
        }
    }

}
