using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Calculations //"Calculations Class" definition
    {
        public double Velocity { get; set; } //deaclaring publicly accessed properties of the class (auto-implemented)
        public double Diameter { get; set; }
        public double Viscosity { get; set; }
        public double Roughness { get; set; }
        public double Density { get; set; }

        private double Re;        //declaring Re variable 
        private double F_number;   //declaring F_number variable
        private double PressureDiff; //declaring Pressure Difference variable
        public int iterations = 0; // declaring and initializing iterations variable, after calculations this value is updated and no longer zero.

       
               
        public double CalculateF_number()
        {
            Re = 1000 * (Diameter * Velocity * Density) / Viscosity; //Re is calculated first

            if (Re != 0 && Re < 2100) //If Re<2000 calculate F_number using the equations below.
            {
                F_number = 64 / Re;
                
            }
            else if (Re > 4000) //If Re>4000 calculate F_number using the equations below.
            {
                F_number = 64 / Re;

                double F_number1, F_number_difference; //declaring int variables to use in F_number calculations.

                do
                {
                    F_number1 = Math.Pow(-2 * Math.Log10(Roughness / (3.7 * Diameter) + 2.51 / (Re*Math.Sqrt(F_number))), -2); //The Colebrook White Equation with F_number = 64 / Re;
                    F_number_difference = Math.Abs(F_number - F_number1);//Iterations should be done until the absolute difference, F_number_difference is small. 
                    F_number = F_number1; //The result from the Colebrook White equation is now used in the next iteration at F_number   
                    
                    iterations = iterations + 1; // iterations++

                } while (F_number_difference > 0.00001 && iterations<=1000) ; //The do-while loop is excecuted as long as the F_number_diff>0.0001. To avoid the loop for going on and on without stopping, &&<1000 max iterations can be put in the condition
            }
            else //((Re <= 4000)&& (Re >= 2100))
            {
                double A = Math.Pow(2.457*Math.Log(Math.Pow(((Math.Pow((7/Re),0.9)) +(0.27*Roughness)/Diameter),-1)), 16);
                double B = Math.Pow(37530 / Re, 16);

                F_number = 8 * Math.Pow(Math.Pow(8/Re, 12)+Math.Pow(A+B,-1.5),1/12);
            }

            return F_number;
        }

        public double CalculatePressure()
        {
            PressureDiff = ((F_number * Density * Velocity * Velocity) / (2 * Diameter)); //Calculating Pressure difference in Pascals.

            return PressureDiff;
        }
                       

    }
}
