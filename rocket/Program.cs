using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Engine f = new Flea();

            Dictionary<string, Engine> e = new Dictionary<string, Engine>//()
            { 
                { "flea", f }
            };
            //e.Add("flea", f);

             e["flea"].DisplayStats();
             e["flea"].DisplayThrust();

            Rocket rocket = new Rocket(100, 100, 100, 100, e["flea"]);

        }
    }
}
