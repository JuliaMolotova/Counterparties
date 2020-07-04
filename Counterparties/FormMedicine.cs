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
    public partial class FormMedicine : Form
    {
        public FormMedicine()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowMedicine();
            if (FormAuthorization.users.type == "agent") { buttonAdd.Enabled = false; buttonEdit.Enabled = false; buttonDel.Enabled = false; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Name = textBoxName.Text;
            medicine.Dosage = textBoxDosage.Text;
            medicine.Manufacturer = textBoxManufacturer.Text;
            medicine.Date = textBoxDate.Text;
            Program.аптека.Medicine.Add(medicine);
            Program.аптека.SaveChanges();
            ShowMedicine();
        }

        void ShowMedicine()
        {
            listViewMedicine.Items.Clear();
            foreach (Medicine medicine in Program.аптека.Medicine)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                medicine.Id.ToString(),
                medicine.Name,
                medicine.Dosage,
                medicine.Manufacturer,
                medicine.Date
                });
                item.Tag = medicine;
                listViewMedicine.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMedicine.SelectedItems.Count == 1)
            {
                Medicine medicine = listViewMedicine.SelectedItems[0].Tag as Medicine;
                medicine.Name = textBoxName.Text;
                medicine.Dosage = textBoxDosage.Text;
                medicine.Manufacturer = textBoxManufacturer.Text;
                medicine.Date = textBoxDate.Text;
                Program.аптека.SaveChanges();
                ShowMedicine();
            }
        }

        private void listViewMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedicine.SelectedItems.Count == 1)
            {
                Medicine medicine = listViewMedicine.SelectedItems[0].Tag as Medicine;
                comboBoxType.SelectedItem = null;
                textBoxName.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxDate.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMedicine.SelectedItems.Count == 1)
                {
                    Medicine medicine = listViewMedicine.SelectedItems[0].Tag as Medicine;
                    Program.аптека.Medicine.Remove(medicine);
                    Program.аптека.SaveChanges();
                    ShowMedicine();
                }
                comboBoxType.SelectedItem = null;
                textBoxName.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
