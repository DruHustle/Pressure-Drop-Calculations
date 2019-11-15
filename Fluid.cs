using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Fluid
    {
      //  input variables: flowRate, density, viscosity, unitsType;

        public double FlowRate { get; set; }
        public double Density { get; set; }
        public double Viscosity { get; set; }        
        public string UnitsType { get; set; }
        public double Diameter { get; set; }
        private double Velocity;

        public void SetVelocity()
        {           
            switch (UnitsType)
            {
                case "Kg/h":
                    Velocity = (FlowRate * 4) / (Density * Math.PI* Diameter * Diameter * 3600); //velocity in meters per second.
                        break;
                case "m^3/h":
                    Velocity = (FlowRate * 4) / (Math.PI * Math.Pow(Diameter,2)* 3600); //velocity in meters per second.
                    break;
                 
            }
        }
        public double GetVelocity()
        {
            return Velocity;
        }

    }
}
