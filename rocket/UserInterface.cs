using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    public class UserInterface
    {
        private Dictionary<string, Engine> _Engine = new Dictionary<string,Engine>();
        private Dictionary<string, TipShape> _TipShape = new Dictionary<string, TipShape>();
        private double _mass;
        private string _engineInput;
        private string _tipInput;
        
        public UserInterface()
        {
            
            StartUi();
        }

        private void StartUi()
        {
            PopulateEngines();
            PopulateTips();
            GetInput();

        }

        private void PopulateEngines()
        {
            Engine flea = new Flea();
            _Engine.Add("flea", flea);
        }

        private void PopulateTips()
        {
            TipShape cone = new Cone();
            _TipShape.Add(cone.GetName(), cone);
        }

        private void GetInput()
        {
            Console.WriteLine($"Please select the SRB type on this rocket from this list...");
            foreach (var i in _Engine)
            {
                Console.WriteLine(i.Key);
            }
            _engineInput = Console.ReadLine().ToLower();

            Console.WriteLine($"You have selected the {_engineInput}");

            Console.WriteLine($"Select the shape of the tip of the rocket from this list");
            foreach(var i in _TipShape)
            {
                Console.WriteLine(i.Key);
            }
            _tipInput = Console.ReadLine().ToLower();

            Console.WriteLine($"You have selected a {_tipInput}");

            Console.WriteLine("What is the total mass of the rocket? (in kilograms)");
            _mass = Convert.ToDouble(Console.ReadLine());
        }
    }
}
