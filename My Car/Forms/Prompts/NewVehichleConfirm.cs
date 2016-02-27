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

namespace MyCar.Forms.Prompts
{
    public partial class NewVehichleConfirm : Form
    {
        public NewVehichleConfirm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();

            var th = new Thread(openNewAddVehicleForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            var th = new Thread(openNewMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void openNewAddVehicleForm(object obj) 
        {
            Application.Run(new AddVehicle());
        }

        private void openNewMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
