using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counterparties
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            Form formAuthorization = new FormAuthorization();
            formAuthorization.Show();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Form formReg = new FormReg();
            formReg.Show();
        }
    }
}
