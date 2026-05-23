using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    public abstract class TipShape
    {
        protected double _DragCoEff;

        public virtual void DisplayDrag()
        {
            Console.WriteLine(_DragCoEff);
        }

        public virtual double GetDrag()
        {
            return 0;
        }
    }
    //===========================================SHAPES==========================
    public class Cone : TipShape
    {
        private new double _DragCoEff = 0.3;
        public override void DisplayDrag()
        {
            Console.WriteLine($"Drag of this shape is {_DragCoEff}");
        }

        public override double GetDrag()
        {
            return _DragCoEff;
        }
    }
}
