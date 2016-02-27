using MyCar.Data;
using MyCar.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar.Forms
{
    public partial class AddVehicle : BaseForm
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string tableName = "Vehichles";
            string cols = "[Brand], [Model], [Engine], [Power], [Year], [EngineVolume], [FuelType], [FuelConsumption]";
            var data = new List<object>() 
            { 
                textBrand.Text, 
                textModel.Text, 
                textEngine.Text, 
                textPower.Text, 
                textYear.Text, 
                textEngineVolume.Text, 
                textFuelType.Text, 
                textFuelConsumption.Text 
            };

            try
            {
                this.Database.Insert(tableName, cols, data);

                MessageBox.Show("The vehichle has been added successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}.", ex.Message), "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            var th = new Thread(openNewMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
