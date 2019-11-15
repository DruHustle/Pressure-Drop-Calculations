namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.IterationsTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FrictionalFactorTxtBox = new System.Windows.Forms.TextBox();
            this.PressureDropTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RoughnessExceptionErrorLabel = new System.Windows.Forms.Label();
            this.ThicknessExceptionErrorLabel = new System.Windows.Forms.Label();
            this.OutsideDiameterExceptionErrorLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PipeRoughnessTxtBox = new System.Windows.Forms.TextBox();
            this.PipeThicknessTxtBox = new System.Windows.Forms.TextBox();
            this.OutsideDiameterTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViscosityExceptionErrorLabel = new System.Windows.Forms.Label();
            this.DensityExceptionErrorLabel = new System.Windows.Forms.Label();
            this.FlowrateExceptionErrorLabel = new System.Windows.Forms.Label();
            this.FlowrateComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViscosityTxtBox = new System.Windows.Forms.TextBox();
            this.DensityTxtBox = new System.Windows.Forms.TextBox();
            this.FlowrateTxtBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flow rate :";
            // 
            // IterationsTxtBox
            // 
            this.IterationsTxtBox.Enabled = false;
            this.IterationsTxtBox.Location = new System.Drawing.Point(214, 166);
            this.IterationsTxtBox.Name = "IterationsTxtBox";
            this.IterationsTxtBox.ReadOnly = true;
            this.IterationsTxtBox.Size = new System.Drawing.Size(100, 22);
            this.IterationsTxtBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Iterations performed :";
            // 
            // FrictionalFactorTxtBox
            // 
            this.FrictionalFactorTxtBox.Enabled = false;
            this.FrictionalFactorTxtBox.Location = new System.Drawing.Point(214, 108);
            this.FrictionalFactorTxtBox.Name = "FrictionalFactorTxtBox";
            this.FrictionalFactorTxtBox.ReadOnly = true;
            this.FrictionalFactorTxtBox.Size = new System.Drawing.Size(100, 22);
            this.FrictionalFactorTxtBox.TabIndex = 3;
            // 
            // PressureDropTxtBox
            // 
            this.PressureDropTxtBox.Enabled = false;
            this.PressureDropTxtBox.Location = new System.Drawing.Point(214, 48);
            this.PressureDropTxtBox.Name = "PressureDropTxtBox";
            this.PressureDropTxtBox.ReadOnly = true;
            this.PressureDropTxtBox.Size = new System.Drawing.Size(100, 22);
            this.PressureDropTxtBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Frictional factor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pressure drop :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.IterationsTxtBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.FrictionalFactorTxtBox);
            this.groupBox2.Controls.Add(this.PressureDropTxtBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(864, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 236);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "kPa/m";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RoughnessExceptionErrorLabel);
            this.groupBox3.Controls.Add(this.ThicknessExceptionErrorLabel);
            this.groupBox3.Controls.Add(this.OutsideDiameterExceptionErrorLabel);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.PipeRoughnessTxtBox);
            this.groupBox3.Controls.Add(this.PipeThicknessTxtBox);
            this.groupBox3.Controls.Add(this.OutsideDiameterTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(49, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 232);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pipe Parameters";
            // 
            // RoughnessExceptionErrorLabel
            // 
            this.RoughnessExceptionErrorLabel.AutoSize = true;
            this.RoughnessExceptionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoughnessExceptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RoughnessExceptionErrorLabel.Location = new System.Drawing.Point(373, 165);
            this.RoughnessExceptionErrorLabel.Name = "RoughnessExceptionErrorLabel";
            this.RoughnessExceptionErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.RoughnessExceptionErrorLabel.TabIndex = 12;
            this.RoughnessExceptionErrorLabel.Text = "Error Label 5";
            // 
            // ThicknessExceptionErrorLabel
            // 
            this.ThicknessExceptionErrorLabel.AutoSize = true;
            this.ThicknessExceptionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThicknessExceptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ThicknessExceptionErrorLabel.Location = new System.Drawing.Point(373, 103);
            this.ThicknessExceptionErrorLabel.Name = "ThicknessExceptionErrorLabel";
            this.ThicknessExceptionErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.ThicknessExceptionErrorLabel.TabIndex = 11;
            this.ThicknessExceptionErrorLabel.Text = "Error Label 4";
            // 
            // OutsideDiameterExceptionErrorLabel
            // 
            this.OutsideDiameterExceptionErrorLabel.AutoSize = true;
            this.OutsideDiameterExceptionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsideDiameterExceptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.OutsideDiameterExceptionErrorLabel.Location = new System.Drawing.Point(373, 45);
            this.OutsideDiameterExceptionErrorLabel.Name = "OutsideDiameterExceptionErrorLabel";
            this.OutsideDiameterExceptionErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.OutsideDiameterExceptionErrorLabel.TabIndex = 10;
            this.OutsideDiameterExceptionErrorLabel.Text = "Error Label 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "mm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Outside diameter :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Roughness :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thickness :";
            // 
            // PipeRoughnessTxtBox
            // 
            this.PipeRoughnessTxtBox.Location = new System.Drawing.Point(168, 160);
            this.PipeRoughnessTxtBox.Name = "PipeRoughnessTxtBox";
            this.PipeRoughnessTxtBox.Size = new System.Drawing.Size(100, 22);
            this.PipeRoughnessTxtBox.TabIndex = 2;
            this.PipeRoughnessTxtBox.TextChanged += new System.EventHandler(this.PipeRoughnessTxtBox_TextChanged_1);
            // 
            // PipeThicknessTxtBox
            // 
            this.PipeThicknessTxtBox.Location = new System.Drawing.Point(168, 98);
            this.PipeThicknessTxtBox.Name = "PipeThicknessTxtBox";
            this.PipeThicknessTxtBox.Size = new System.Drawing.Size(100, 22);
            this.PipeThicknessTxtBox.TabIndex = 1;
            this.PipeThicknessTxtBox.TextChanged += new System.EventHandler(this.PipeThicknessTxtBox_TextChanged_1);
            // 
            // OutsideDiameterTxtBox
            // 
            this.OutsideDiameterTxtBox.Location = new System.Drawing.Point(168, 40);
            this.OutsideDiameterTxtBox.Name = "OutsideDiameterTxtBox";
            this.OutsideDiameterTxtBox.Size = new System.Drawing.Size(100, 22);
            this.OutsideDiameterTxtBox.TabIndex = 0;
            this.OutsideDiameterTxtBox.TextChanged += new System.EventHandler(this.OutsideDiameterTxtBox_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViscosityExceptionErrorLabel);
            this.groupBox1.Controls.Add(this.DensityExceptionErrorLabel);
            this.groupBox1.Controls.Add(this.FlowrateExceptionErrorLabel);
            this.groupBox1.Controls.Add(this.FlowrateComboBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ViscosityTxtBox);
            this.groupBox1.Controls.Add(this.DensityTxtBox);
            this.groupBox1.Controls.Add(this.FlowrateTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(49, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fluid Parameters";
            // 
            // ViscosityExceptionErrorLabel
            // 
            this.ViscosityExceptionErrorLabel.AutoSize = true;
            this.ViscosityExceptionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViscosityExceptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ViscosityExceptionErrorLabel.Location = new System.Drawing.Point(373, 171);
            this.ViscosityExceptionErrorLabel.Name = "ViscosityExceptionErrorLabel";
            this.ViscosityExceptionErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.ViscosityExceptionErrorLabel.TabIndex = 11;
            this.ViscosityExceptionErrorLabel.Text = "Error Label 3";
            // 
            // DensityExceptionErrorLabel
            // 
            this.DensityExceptionErrorLabel.AutoSize = true;
            this.DensityExceptionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DensityExceptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DensityExceptionErrorLabel.Location = new System.Drawing.Point(373, 113);
            this.DensityExceptionErrorLabel.Name = "DensityExceptionErrorLabel";
            this.DensityExceptionErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.DensityExceptionErrorLabel.TabIndex = 10;
            this.DensityExceptionErrorLabel.Text = "Error Label 2";
            // 
            // FlowrateExceptionErrorLabel
            // 
            this.FlowrateExceptionErrorLabel.AutoSize = true;
            this.FlowrateExceptionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlowrateExceptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FlowrateExceptionErrorLabel.Location = new System.Drawing.Point(373, 56);
            this.FlowrateExceptionErrorLabel.Name = "FlowrateExceptionErrorLabel";
            this.FlowrateExceptionErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.FlowrateExceptionErrorLabel.TabIndex = 9;
            this.FlowrateExceptionErrorLabel.Text = "Error Label 1";
            // 
            // FlowrateComboBox
            // 
            this.FlowrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlowrateComboBox.FormattingEnabled = true;
            this.FlowrateComboBox.Items.AddRange(new object[] {
            "Kg/h",
            "m^3/h"});
            this.FlowrateComboBox.Location = new System.Drawing.Point(292, 51);
            this.FlowrateComboBox.Name = "FlowrateComboBox";
            this.FlowrateComboBox.Size = new System.Drawing.Size(75, 24);
            this.FlowrateComboBox.TabIndex = 8;
            this.FlowrateComboBox.SelectedIndexChanged += new System.EventHandler(this.FlowrateComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Kg/m^3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "cP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Viscosity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Density :";
            // 
            // ViscosityTxtBox
            // 
            this.ViscosityTxtBox.Location = new System.Drawing.Point(168, 166);
            this.ViscosityTxtBox.Name = "ViscosityTxtBox";
            this.ViscosityTxtBox.Size = new System.Drawing.Size(100, 22);
            this.ViscosityTxtBox.TabIndex = 2;
            this.ViscosityTxtBox.TextChanged += new System.EventHandler(this.ViscosityTxtBox_TextChanged_1);
            // 
            // DensityTxtBox
            // 
            this.DensityTxtBox.Location = new System.Drawing.Point(168, 108);
            this.DensityTxtBox.Name = "DensityTxtBox";
            this.DensityTxtBox.Size = new System.Drawing.Size(100, 22);
            this.DensityTxtBox.TabIndex = 1;
            this.DensityTxtBox.TextChanged += new System.EventHandler(this.DensityTxtBox_TextChanged_1);
            // 
            // FlowrateTxtBox
            // 
            this.FlowrateTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FlowrateTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.FlowrateTxtBox.Location = new System.Drawing.Point(168, 51);
            this.FlowrateTxtBox.Name = "FlowrateTxtBox";
            this.FlowrateTxtBox.Size = new System.Drawing.Size(100, 22);
            this.FlowrateTxtBox.TabIndex = 0;
            this.FlowrateTxtBox.TextChanged += new System.EventHandler(this.FlowrateTxtBox_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(864, 317);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(86, 36);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Programming Task.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IterationsTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FrictionalFactorTxtBox;
        private System.Windows.Forms.TextBox PressureDropTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PipeRoughnessTxtBox;
        private System.Windows.Forms.TextBox PipeThicknessTxtBox;
        private System.Windows.Forms.TextBox OutsideDiameterTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox FlowrateComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ViscosityTxtBox;
        private System.Windows.Forms.TextBox DensityTxtBox;
        private System.Windows.Forms.TextBox FlowrateTxtBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label RoughnessExceptionErrorLabel;
        private System.Windows.Forms.Label ThicknessExceptionErrorLabel;
        private System.Windows.Forms.Label OutsideDiameterExceptionErrorLabel;
        private System.Windows.Forms.Label ViscosityExceptionErrorLabel;
        private System.Windows.Forms.Label DensityExceptionErrorLabel;
        private System.Windows.Forms.Label FlowrateExceptionErrorLabel;
    }
}

