using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Pipe //Pipe class definition.
    {
        public double OutsideDiameter { get; set; } //properties to be passed to and fro other classes
        public double  Roughness { get; set; }
        public double  Thickness { get; set; }
        private double Diameter; //private property class

       

        public void SetDiameter()
        {
            Diameter = (OutsideDiameter - 2 * Thickness) * 0.001; //Calculating the diameter
        }

        public double GetDiameter()
        {
            return Diameter; //returning the calculated Diameter.
        }
        
      
    }
}
