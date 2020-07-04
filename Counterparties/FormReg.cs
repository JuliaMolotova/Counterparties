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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
            ShowBuyer();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                Buyer buyer = new Buyer();
               buyer.Login = textBoxLogin.Text;
               buyer.Password = textBoxPassword.Text;
               buyer.FIO = textBoxFIO.Text;
               buyer.Phone = textBoxPhone.Text;
               buyer.Email = textBoxEmail.Text;
                Program.аптека.Buyer.Add(buyer);
                Program.аптека.SaveChanges();
                ShowBuyer();
            MessageBox.Show("Вы успешно зарегетрировались", "Спасибо", MessageBoxButtons.OK);
        }

        void ShowBuyer()
        {
            listViewBuyer.Items.Clear();
            foreach (Buyer buyer in Program.аптека.Buyer)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                buyer.Id.ToString(),
                buyer.Login,
                buyer.Password,
                buyer.FIO,
                buyer.Phone,
                buyer.Email
                }); 
                item.Tag = buyer;
                listViewBuyer.Items.Add(item);
            }
        }

        private void listViewLegalEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBuyer.SelectedItems.Count == 1)
            {
                Buyer buyer = listViewBuyer.SelectedItems[0].Tag as Buyer;
                textBoxLogin.Text = "";
                textBoxPassword.Text =  "";
                textBoxFIO.Text = "";
                textBoxPhone.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formAuthorization = new FormAuthorization();
            formAuthorization.Show();
        }
    }
}
