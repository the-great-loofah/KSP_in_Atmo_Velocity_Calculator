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
        protected double FuelCapacity;
        protected double FuelConsumption;

        public virtual void DisplayStats()
        {

        }

        public virtual void DisplayThrust()
        {
           
        }

        public virtual double GetThrust()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "0";
        }
        
        public virtual string GetEngineType()
        {
            return "0";
        }

        public virtual double GetBurnTime()
        {
            return 0;
        }
    }
    //=====================================================SRB'S=================================================
    public class Flea : Engine
    {
        private new string Type = "solid rocket booster/SRB";
        private new string Name = "Flea";
        private new double Thrust = 162909; //newtons
        private new double Isp = 140;
        private new double Mass = 1500; 
        private new double DryMass = 450; 
        private new double FuelCapacity = 140; //arbitrary value from KSP
        private new double FuelConsumption = 15.821; //arbitrary value from KSP
        //---------------------------------------------METHODS------------------------------------------------------
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

        public override string GetName()
        {
            return Name;
        }

        public override string GetEngineType()
        {
            return Type;
        }

        public override double GetBurnTime()
        {
            return FuelCapacity / FuelConsumption;
        }
    }

    //==================================================================================================================

}
