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

        private void buttonManager_Click(object sender, EventArgs e)
        {
            Form formManager = new FormManager();
            formManager.Show();
        }

        private void buttonIndividuals_Click(object sender, EventArgs e)
        {
            Form formIndividuals = new FormIndividuals();
            formIndividuals.Show();
        }

        private void buttonLegalEntities_Click(object sender, EventArgs e)
        {
            Form formLegalEntities = new FormLegalEntities();
            formLegalEntities.Show();
        }
    }
}
