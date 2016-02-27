namespace MyCar.Forms
{
    partial class AddVehicle
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
            this.textBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textEngine = new System.Windows.Forms.TextBox();
            this.textPower = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textFuelType = new System.Windows.Forms.TextBox();
            this.textFuelConsumption = new System.Windows.Forms.TextBox();
            this.labelEngine = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelEngineVolume = new System.Windows.Forms.Label();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelFuelConsumption = new System.Windows.Forms.Label();
            this.textEngineVolume = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBrand
            // 
            this.textBrand.Location = new System.Drawing.Point(291, 41);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(333, 20);
            this.textBrand.TabIndex = 0;
            this.textBrand.Tag = "Brand";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(131, 44);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(35, 13);
            this.labelBrand.TabIndex = 1;
            this.labelBrand.Text = "Brand";
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(291, 68);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(333, 20);
            this.textModel.TabIndex = 2;
            this.textModel.Tag = "Model";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(130, 71);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(291, 278);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textEngine
            // 
            this.textEngine.Location = new System.Drawing.Point(291, 94);
            this.textEngine.Name = "textEngine";
            this.textEngine.Size = new System.Drawing.Size(333, 20);
            this.textEngine.TabIndex = 5;
            this.textEngine.Tag = "Engine";
            // 
            // textPower
            // 
            this.textPower.Location = new System.Drawing.Point(291, 121);
            this.textPower.Name = "textPower";
            this.textPower.Size = new System.Drawing.Size(333, 20);
            this.textPower.TabIndex = 6;
            this.textPower.Tag = "Power";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(291, 148);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(333, 20);
            this.textYear.TabIndex = 7;
            this.textYear.Tag = "Year";
            // 
            // textFuelType
            // 
            this.textFuelType.Location = new System.Drawing.Point(291, 202);
            this.textFuelType.Name = "textFuelType";
            this.textFuelType.Size = new System.Drawing.Size(333, 20);
            this.textFuelType.TabIndex = 9;
            this.textFuelType.Tag = "FuelType";
            // 
            // textFuelConsumption
            // 
            this.textFuelConsumption.Location = new System.Drawing.Point(291, 229);
            this.textFuelConsumption.Name = "textFuelConsumption";
            this.textFuelConsumption.Size = new System.Drawing.Size(333, 20);
            this.textFuelConsumption.TabIndex = 10;
            this.textFuelConsumption.Tag = "FuelConsumption";
            // 
            // labelEngine
            // 
            this.labelEngine.AutoSize = true;
            this.labelEngine.Location = new System.Drawing.Point(130, 97);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(40, 13);
            this.labelEngine.TabIndex = 11;
            this.labelEngine.Text = "Engine";
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(131, 124);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(37, 13);
            this.labelPower.TabIndex = 12;
            this.labelPower.Text = "Power";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(131, 151);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 13;
            this.labelYear.Text = "Year";
            // 
            // labelEngineVolume
            // 
            this.labelEngineVolume.AutoSize = true;
            this.labelEngineVolume.Location = new System.Drawing.Point(131, 178);
            this.labelEngineVolume.Name = "labelEngineVolume";
            this.labelEngineVolume.Size = new System.Drawing.Size(78, 13);
            this.labelEngineVolume.TabIndex = 14;
            this.labelEngineVolume.Text = "Engine Volume";
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(131, 205);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(54, 13);
            this.labelFuelType.TabIndex = 15;
            this.labelFuelType.Text = "Fuel Type";
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(131, 232);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(91, 13);
            this.labelFuelConsumption.TabIndex = 16;
            this.labelFuelConsumption.Text = "Fuel Consumption";
            // 
            // textEngineVolume
            // 
            this.textEngineVolume.Location = new System.Drawing.Point(291, 175);
            this.textEngineVolume.Name = "textEngineVolume";
            this.textEngineVolume.Size = new System.Drawing.Size(333, 20);
            this.textEngineVolume.TabIndex = 17;
            this.textEngineVolume.Tag = "EngineVolume";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(372, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 492);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textEngineVolume);
            this.Controls.Add(this.labelFuelConsumption);
            this.Controls.Add(this.labelFuelType);
            this.Controls.Add(this.labelEngineVolume);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.labelEngine);
            this.Controls.Add(this.textFuelConsumption);
            this.Controls.Add(this.textFuelType);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textPower);
            this.Controls.Add(this.textEngine);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBrand);
            this.Name = "AddVehicle";
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.textBrand, 0);
            this.Controls.SetChildIndex(this.labelBrand, 0);
            this.Controls.SetChildIndex(this.textModel, 0);
            this.Controls.SetChildIndex(this.labelModel, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.textEngine, 0);
            this.Controls.SetChildIndex(this.textPower, 0);
            this.Controls.SetChildIndex(this.textYear, 0);
            this.Controls.SetChildIndex(this.textFuelType, 0);
            this.Controls.SetChildIndex(this.textFuelConsumption, 0);
            this.Controls.SetChildIndex(this.labelEngine, 0);
            this.Controls.SetChildIndex(this.labelPower, 0);
            this.Controls.SetChildIndex(this.labelYear, 0);
            this.Controls.SetChildIndex(this.labelEngineVolume, 0);
            this.Controls.SetChildIndex(this.labelFuelType, 0);
            this.Controls.SetChildIndex(this.labelFuelConsumption, 0);
            this.Controls.SetChildIndex(this.textEngineVolume, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textEngine;
        private System.Windows.Forms.TextBox textPower;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textFuelType;
        private System.Windows.Forms.TextBox textFuelConsumption;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelEngineVolume;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelFuelConsumption;
        private System.Windows.Forms.TextBox textEngineVolume;
        private System.Windows.Forms.Button buttonCancel;
    }
}

