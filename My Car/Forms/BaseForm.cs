using MyCar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar.Forms
{
    public partial class BaseForm : Form
    {
        public DataProvider Database
        {
            get
            {
                var dataProvider = new DataProvider();

                return dataProvider;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
        }
    }
}
