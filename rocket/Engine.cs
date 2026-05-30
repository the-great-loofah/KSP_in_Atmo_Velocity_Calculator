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
        protected string _Type;
        protected string _Name;
        protected double _Thrust;
        protected double _Isp;
        protected double _Mass;
        protected double _DryMass;
        protected double _FuelCapacity;
        protected double _FuelConsumption;
        protected double _FuelMass;
        //--------------------------------METHODS------------------------------------

        public virtual void DisplayStats()
        {
            Console.WriteLine($"This is the {_Name} {_Type}, it has a thrust of {_Thrust} newtons, a specific impulse of {_Isp}");
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

        public virtual double GetFuelMass()
        {
            return 0;
        }

        public virtual double GetIsp()
        {
            return 0;
        }
    }
    //=====================================================SRB'S=================================================
    //-----------------------------------------------------FLEA--------------------------------------------------
    public class Flea : Engine
    {
        private new string _Type = "solid rocket booster/SRB";
        private new string _Name = "Flea";
        private new double _Thrust = 162909; //newtons
        private new double _Isp = 140;
        private new double _Mass = 1500; 
        private new double _DryMass = 450; 
        private new double _FuelCapacity = 140; //arbitrary value from KSP
        private new double _FuelConsumption = 15.821; //arbitrary value from KSP
        private new double _FuelMass = 1050;
        
        public override void DisplayStats() //debug
        {
            Console.WriteLine($"This is the {_Name} {_Type}, it has a thrust of {_Thrust} newtons, a specific impulse of {_Isp}");

        }

        public override void DisplayThrust() //debug
        {
            Console.WriteLine($"This Booster has a thrust of {_Thrust}");
        }

        public override double GetThrust()
        {
            return _Thrust;
        }

        public override string GetName()
        {
            return _Name;
        }

        public override string GetEngineType()
        {
            return _Type;
        }

        public override double GetBurnTime()
        {
            return _FuelCapacity / _FuelConsumption;
        }

        public override double GetFuelMass()
        {
            return _FuelMass;
        }

        public override double GetIsp()
        {
            return _Isp;
        }
    }

    //==================================================================================================================

}
