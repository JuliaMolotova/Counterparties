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
    public partial class FormIndividuals : Form
    {
        public FormIndividuals()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowIndividuals();
            ShowManager();
        }

        void ShowManager()
        {
            comboBoxManager.Items.Clear();
            foreach (Manager manager in Program.counterparties.Manager)
            {
                string[] item = { manager.Id.ToString() + ". ", "" + manager.LastName };
                comboBoxManager.Items.Add(string.Join("", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxManager.SelectedItem != null)
            {
                Individuals individuals = new Individuals();
                individuals.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                individuals.LastName = textBoxLastName.Text;
                individuals.IO = textBoxIO.Text;
                individuals.DOB = textBoxDOB.Text;
                individuals.Address = textBoxAddress.Text;
                Program.counterparties.Individuals.Add(individuals);
                Program.counterparties.SaveChanges();
                ShowIndividuals();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowIndividuals()
        {
            listViewIndividuals.Items.Clear();
            foreach (Individuals individuals in Program.counterparties.Individuals)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                individuals.Id.ToString(),
                individuals.IdManager.ToString(),
                individuals.Manager.LastName,
                individuals.LastName,
                individuals.IO,
                individuals.Type.ToString(),
                individuals.DOB,
                individuals.Address
                }) ;
                item.Tag = individuals;
                listViewIndividuals.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewIndividuals.SelectedItems.Count == 1)
            {
                Individuals individuals = listViewIndividuals.SelectedItems[0].Tag as Individuals;
                individuals.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                individuals.LastName = textBoxLastName.Text;
                individuals.IO = textBoxIO.Text;
                individuals.DOB = textBoxDOB.Text;
                individuals.Address = textBoxAddress.Text;
                Program.counterparties.SaveChanges();
                ShowIndividuals();
            }
        }

        private void listViewIndividuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIndividuals.SelectedItems.Count == 1)
            {
                Individuals individuals = listViewIndividuals.SelectedItems[0].Tag as Individuals;
                comboBoxManager.SelectedIndex = comboBoxManager.FindString(individuals.IdManager.ToString());
            }
            else
            {
                comboBoxManager.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                textBoxLastName.Text = "";
                textBoxIO.Text = "";
                textBoxDOB.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewIndividuals.SelectedItems.Count == 1)
                {
                    Individuals individuals = listViewIndividuals.SelectedItems[0].Tag as Individuals;
                    Program.counterparties.Individuals.Remove(individuals);
                    Program.counterparties.SaveChanges();
                    ShowIndividuals();
                }
                comboBoxManager.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                textBoxLastName.Text = "";
                textBoxIO.Text = "";
                textBoxDOB.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
