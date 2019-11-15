using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double Flowrate, Viscosity, Density, Roughness, Thickness, OutsideDiameter; //declaring the varibales to be used pass property values to classes.
        string UnitType; //String type declaration to use when determinng either to use kg/h or m^3/h.
        

        //instantiating new object for the given varibles;
        Pipe PipeProperties = new Pipe();  //Instantiation of new object from class pipe.
        Fluid FluidProperties = new Fluid(); //Instantiation of new object from class fluid.
        Calculations CalculationsGivenProperites = new Calculations(); //Instantiation of new object from class calculations.

        
        public Form1()
        {
            InitializeComponent(); //Automatically created by Windows Form Designer 
        }

        #region Clear Error Labels after loading the form.
        //After loading the form the text of ErrorLabels will be clear text on labels.
        private void Form1_Load(object sender, EventArgs e)
        {
            FlowrateExceptionErrorLabel.Text = "";
            DensityExceptionErrorLabel.Text = "";
            ViscosityExceptionErrorLabel.Text = "";
            OutsideDiameterExceptionErrorLabel.Text = "";
            ThicknessExceptionErrorLabel.Text = "";
            RoughnessExceptionErrorLabel.Text = "";
        }

        #endregion

        #region Data Entry and Exception handling. 

        
        private void FlowrateTxtBox_TextChanged(object sender, EventArgs e) //Event that occurs when text in Flowrate Text Box changes.
        {
            try //Excecute the lines of code below
            {
                Flowrate = Convert.ToDouble(FlowrateTxtBox.Text.Trim()); //mass or volumetric flowrate. Conversion happens in FluidsProperties class. "Trim" trims all the spaces before or after the string.
                FluidProperties.FlowRate = Flowrate; // Set the value of flow rate to the value entered.
                FlowrateExceptionErrorLabel.Text = ""; //To clear the text on Error label after every new valid entry.

                FlowrateComboBox.DroppedDown = true; //If the users enters a valid entry, the dropdown box is enabled
                Cursor = Cursors.Default; //Since the combodrop down is activated, the cursor was going to the back of the form. This line brings it back.
            }

            catch (Exception) //if an exeption is encountered, catch exeption. Exception occurs when a text or tab entry i entered.
            {
               

                FlowrateExceptionErrorLabel.Text = "Enter Numerical Input"; //The Error label should notify to enter a valid entry,
                FlowrateComboBox.DroppedDown = false; //If an invalid data entry is entered, the drop down combo box is not enabled.

                
               string TextInput =  FlowrateTxtBox.Text.Trim() ; //Trim to remove "space" character from being imported into the code.
               if (TextInput.Length != 0) //To avoid an exception from Remove(), when Text length is zero.
                { 
                    FlowrateTxtBox.Text = TextInput.Remove(TextInput.Length-1); //Removing a text input, after an exeption.
                    FlowrateTxtBox.SelectionStart = FlowrateTxtBox.Text.Length; //Set the position of cursor to the end of the input string.
                }
                
            }
        }

       

        private void FlowrateComboBox_SelectedIndexChanged(object sender, EventArgs e) //Event that occurs when index in combo box is selected.
        {
            try//Excecute the lines of code below
            {
                UnitType = FlowrateComboBox.Text; // The text in the selected combo box index is stored in UnitType variable.
                FluidProperties.UnitsType = UnitType; //The value of UnitsType in object fluid properties in set to UnitType.
                FlowrateExceptionErrorLabel.Text = ""; //If no exeption occurs, the error label is null.
            }
            catch (Exception)//if operation fails and an exeption is encountered, catch exeption.
            {

            }
        }

        private void DensityTxtBox_TextChanged_1(object sender, EventArgs e) //Event occurs after the text in Density text box changed
        {

            try //Excecute the lines of code below
            {
                Density = Convert.ToDouble(DensityTxtBox.Text.Trim()); //An input entry is a string by default. It is converted to a double and stored in memory location Density.
                FluidProperties.Density = Density;//The value of density if fluid properties is set to density.
                DensityExceptionErrorLabel.Text = "";//If no exceptions happen, do not display anything in the error text label
            }
            catch (Exception) //if operation fails and an exeption is encountered, catch exeption.
            {
                DensityExceptionErrorLabel.Text = "Enter Numerical Input"; //If an exception happens, error label should display error message.
                string TextInput = DensityTxtBox.Text.Trim(); //Trim to remove "space" character from being imported into the code.
                if (TextInput.Length != 0) //To avoid an exception from Remove(), when Text length is zero.
                {
                    DensityTxtBox.Text = TextInput.Remove(TextInput.Length - 1); //Removing a text input, after an exeption.
                    DensityTxtBox.SelectionStart = DensityTxtBox.Text.Length; //Set the position of cursor to the end of the input string.
                }
            }

        }

        private void ViscosityTxtBox_TextChanged_1(object sender, EventArgs e) //When text in the Viscocity Text box change, the code in the curly brackets is executed.
        {
            try //Excecute the lines of code below
            {
                Viscosity = Convert.ToDouble(ViscosityTxtBox.Text.Trim()); //The trimmed string text is converted to double, and value is stored on Viscosity memory location.
                FluidProperties.Viscosity = Viscosity; //The value of viscosity in Fluid properties object, is set to the value of Viscosity.
                ViscosityExceptionErrorLabel.Text = ""; //If there is no exception the Error label is null.
            }
            catch (Exception) //if operation fails and an exeption is encountered, catch exeption.
            {
                ViscosityExceptionErrorLabel.Text = "Enter Numerical Input"; //Error label should display the text if an exception is encountered.
                string TextInput = ViscosityTxtBox.Text.Trim(); //Trim to remove "space" character from being imported into the code.
                if (TextInput.Length != 0) //To avoid an exception from Remove(), when Text length is zero.
                {
                    ViscosityTxtBox.Text = TextInput.Remove(TextInput.Length - 1); //Removing a text input, after an exeption.
                    ViscosityTxtBox.SelectionStart = ViscosityTxtBox.Text.Length; //Set the position of cursor to the end of the input string.
                }
            }
        }

        

        private void OutsideDiameterTxtBox_TextChanged_1(object sender, EventArgs e) //When text in the Outside Diameter Text box change, the code in the curly brackets is executed.
        {
            try //Excecute the lines of code below
            {
                OutsideDiameter = Convert.ToDouble(OutsideDiameterTxtBox.Text.Trim()); //The trimmed string text is converted to double, and value is stored on Outside Diameter memory location.
                PipeProperties.OutsideDiameter = OutsideDiameter;
                OutsideDiameterExceptionErrorLabel.Text = "";

                if (!String.IsNullOrEmpty(PipeThicknessTxtBox.Text.Trim()) && (PipeProperties.Thickness >= PipeProperties.OutsideDiameter)) //Thickness cannot be greater than diameter
                {
                    OutsideDiameterExceptionErrorLabel.Text = "Diameter should be greater than thickness.";

                }
                if (!String.IsNullOrEmpty(PipeRoughnessTxtBox.Text.Trim()) && (PipeProperties.Roughness*1000 >= PipeProperties.OutsideDiameter)) //Thickness cannot be greater than diameter
                {
                    OutsideDiameterExceptionErrorLabel.Text = "Diameter should be greater than roughness.";

                }
            }
            catch (Exception) //if operation fails and an exeption is encountered, catch exeption.
            {
                OutsideDiameterExceptionErrorLabel.Text = "Enter Numerical Input";
                string TextInput = OutsideDiameterTxtBox.Text.Trim(); //Trim to remove "space" character from being imported into the code.
                if (TextInput.Length != 0) //To avoid an exception from Remove(), when Text length is zero.
                {
                    OutsideDiameterTxtBox.Text = TextInput.Remove(TextInput.Length - 1); //Removing a text input, after an exeption.
                    OutsideDiameterTxtBox.SelectionStart = OutsideDiameterTxtBox.Text.Length; //Set the position of cursor to the end of the input string.
                }
            }
        }

        private void PipeThicknessTxtBox_TextChanged_1(object sender, EventArgs e) //When text in the Pipe Thickness Text box change, the code in the curly brackets is executed
        {
            try //Excecute the lines of code below
            {
                Thickness = Convert.ToDouble(PipeThicknessTxtBox.Text.Trim()); //The trimmed string text is converted to double, and value is stored on Thickness memory location
                PipeProperties.Thickness = Thickness;
                ThicknessExceptionErrorLabel.Text = "";

                if (!String.IsNullOrEmpty(OutsideDiameterTxtBox.Text.Trim())&&(PipeProperties.Thickness >= PipeProperties.OutsideDiameter)) //Thickness cannot be greater than diameter
                {
                    ThicknessExceptionErrorLabel.Text = "Thickness should be less than diameter.";
                    
                }

                if (!String.IsNullOrEmpty(PipeRoughnessTxtBox.Text.Trim()) && (PipeProperties.Roughness*1000 >= PipeProperties.Thickness)) //Thickness cannot be greater than diameter
                {
                    ThicknessExceptionErrorLabel.Text = "Thickness should be greater than roughness.";

                }
            }
            catch (Exception) //if operation fails and an exeption is encountered, catch exeption.
            {
                ThicknessExceptionErrorLabel.Text = "Enter Numerical Input";
                string TextInput = PipeThicknessTxtBox.Text.Trim(); //Trim to remove "space" character from being imported into the code.
                if (TextInput.Length != 0) //To avoid an exception from Remove(), when Text length is zero.
                {
                    PipeThicknessTxtBox.Text = TextInput.Remove(TextInput.Length - 1); //Removing a text input, after an exeption.
                    PipeThicknessTxtBox.SelectionStart = PipeThicknessTxtBox.Text.Length; //Set the position of cursor to the end of the input string.
                }
            }
        }

        private void PipeRoughnessTxtBox_TextChanged_1(object sender, EventArgs e) //When text in the Pipe Roughness Text box change, the code in the curly brackets is executed
        {
            try //Excecute the lines of code below
            {
                Roughness = Convert.ToDouble(PipeRoughnessTxtBox.Text.Trim()) * 0.001; //The input value of Roughness is multiplied by 0.001 to convert it to meters. 
                PipeProperties.Roughness = Roughness ;
                RoughnessExceptionErrorLabel.Text = "";

                if (!String.IsNullOrEmpty(PipeThicknessTxtBox.Text)&&(PipeProperties.Roughness*1000 >= PipeProperties.Thickness))//Roughness cannot be greater than thickness
                {
                    RoughnessExceptionErrorLabel.Text = "Roughness should be less than thickness.";
                    
                }
                if (!String.IsNullOrEmpty(OutsideDiameterTxtBox.Text.Trim()) && (PipeProperties.Roughness*1000 >= PipeProperties.OutsideDiameter)) //Thickness cannot be greater than diameter
                {
                    RoughnessExceptionErrorLabel.Text = "Roughness should be less than diameter.";

                }

            }
            catch (Exception) //if operation fails and an exeption is encountered, catch exeption.
            {
                RoughnessExceptionErrorLabel.Text = "Enter Numerical Input";
                string TextInput = PipeRoughnessTxtBox.Text.Trim(); //Trim to remove "space" character from being imported into the code.
                if (TextInput.Length != 0) //To avoid an exception from Remove(), when Text length is zero.
                {
                    PipeRoughnessTxtBox.Text = TextInput.Remove(TextInput.Length - 1); //Removing a text input, after an exeption.
                    PipeRoughnessTxtBox.SelectionStart = PipeRoughnessTxtBox.Text.Length; //Set the position of cursor to the end of the input string.
                }
            }
        }
        #endregion

        #region  Function " CheckFields" to check if all data fields have valid input entries before calculating.
        private bool CheckFields()

        {
            bool FieldLogic = true; //The declared value

                if (String.IsNullOrEmpty(FlowrateTxtBox.Text) || !String.IsNullOrEmpty(FlowrateExceptionErrorLabel.Text)) //Flowrate textbox is checked if its null or emepty, then also the error message is checked. Error message appears when wrong data type is entered.
                {
                    if (String.IsNullOrEmpty(FlowrateExceptionErrorLabel.Text)) //If empty or null, the error label displays text to tell the user to enter input values.
                    {
                        FlowrateExceptionErrorLabel.Text = "Enter flow rate value."; //Text displayed on error label.
                        
                    }
                      FieldLogic = false;       //the value of FieldLogic will be returned, after all if statements are executed             
                }

                if (String.IsNullOrEmpty(FlowrateComboBox.Text))
                {
                   FlowrateExceptionErrorLabel.Text = "Select flow rate units.";
                   FieldLogic = false;
                }

                if ((String.IsNullOrEmpty(FlowrateTxtBox.Text) || !String.IsNullOrEmpty(FlowrateExceptionErrorLabel.Text)) && String.IsNullOrEmpty(FlowrateComboBox.Text))
                {
                   FlowrateExceptionErrorLabel.Text = "Enter flow rate and select units."; //Check if user entered values for both Flowrate text box and the flow rate combo box.
                   FieldLogic = false;
                }

            if (String.IsNullOrEmpty(DensityTxtBox.Text) || !String.IsNullOrEmpty(DensityExceptionErrorLabel.Text)) //Check if user entered a valid entry
                {
                    if (String.IsNullOrEmpty(DensityExceptionErrorLabel.Text))
                    {
                        DensityExceptionErrorLabel.Text = "Enter density value."; //If textbox is empty, "enter density value" is displayed.
                    }
                   FieldLogic = false;
                }

                 
                 if (String.IsNullOrEmpty(ViscosityTxtBox.Text) || !String.IsNullOrEmpty(ViscosityExceptionErrorLabel.Text))
                {
                    if (String.IsNullOrEmpty(ViscosityExceptionErrorLabel.Text))
                    {
                        ViscosityExceptionErrorLabel.Text = "Enter viscosity value.";
                    }
                    FieldLogic= false;
                }

                 if (String.IsNullOrEmpty(OutsideDiameterTxtBox.Text) || !String.IsNullOrEmpty(OutsideDiameterExceptionErrorLabel.Text))
                {
                    if (String.IsNullOrEmpty(OutsideDiameterExceptionErrorLabel.Text))
                    {
                        OutsideDiameterExceptionErrorLabel.Text = "Enter outside diameter value.";
                    }
                    FieldLogic = false;
                }

                 if (String.IsNullOrEmpty(PipeThicknessTxtBox.Text) || !String.IsNullOrEmpty(ThicknessExceptionErrorLabel.Text))
                {
                    if (String.IsNullOrEmpty(ThicknessExceptionErrorLabel.Text))
                    {
                        ThicknessExceptionErrorLabel.Text = "Enter pipe thickness value.";
                    }
                    FieldLogic = false;
                }

                if (PipeProperties.Thickness > PipeProperties.OutsideDiameter)
                {
                    ThicknessExceptionErrorLabel.Text = "Thickness not greater than diameter.";
                     FieldLogic = false;
                }

                 if (String.IsNullOrEmpty(PipeRoughnessTxtBox.Text) || !String.IsNullOrEmpty(RoughnessExceptionErrorLabel.Text))
                {
                    if (String.IsNullOrEmpty(RoughnessExceptionErrorLabel.Text))
                    {
                        RoughnessExceptionErrorLabel.Text = "Enter roughness value.";
                    }
                    FieldLogic = false;
                 }

            return FieldLogic;

        }
        #endregion

        #region Calculate after pressing "Calculate" button.
        private void Calculate_Click_1(object sender, EventArgs e)
        {

            if (CheckFields())
            {
                PipeProperties.SetDiameter(); //Tell PipeProperties to calculate Diameter.  
                FluidProperties.Diameter = PipeProperties.GetDiameter(); //Set the value of Diameter in Fluid Properties, as the value calculated in Pipe Class.
                FluidProperties.SetVelocity(); //Tell FluidProperties to calculate Velocity.             


                //Passing arguments to the Calculations class to make calculations.
                CalculationsGivenProperites.Velocity = FluidProperties.GetVelocity(); //Take the value of velocity in fluidProperties and put it in calculationGivenVariables
                CalculationsGivenProperites.Diameter = PipeProperties.GetDiameter(); //
                CalculationsGivenProperites.Viscosity = FluidProperties.Viscosity;
                CalculationsGivenProperites.Roughness = PipeProperties.Roughness;
                CalculationsGivenProperites.Density = FluidProperties.Density;

                //Calculating Re and followed by F_number
                CalculationsGivenProperites.CalculateF_number();

                double PressureDiff = CalculationsGivenProperites.CalculatePressure();
                int iterations = CalculationsGivenProperites.iterations;
                double F_number = CalculationsGivenProperites.CalculateF_number();


                //Displaying values on the User Interface

                PressureDropTxtBox.Text = PressureDiff.ToString();
                FrictionalFactorTxtBox.Text = F_number.ToString();
                IterationsTxtBox.Text = iterations.ToString();

                //Resetting iterations
                CalculationsGivenProperites.iterations = 0; 
            }
        }
        #endregion


      
    }

}


    