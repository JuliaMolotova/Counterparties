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
    public partial class FormLegalEntities : Form
    {
        public FormLegalEntities()
        {
            InitializeComponent();
            ShowLegalEntities();
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
                LegalEntities legalEntities = new LegalEntities();
                legalEntities.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                legalEntities.Name = textBoxName.Text;
                legalEntities.Address = textBoxAddress.Text;
                legalEntities.INN = textBoxINN.Text;
                legalEntities.KPP = textBoxKPP.Text;
                legalEntities.Address = textBoxAddress.Text;
                Program.counterparties.LegalEntities.Add(legalEntities);
                Program.counterparties.SaveChanges();
                ShowLegalEntities();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowLegalEntities()
        {
            listViewLegalEntities.Items.Clear();
            foreach (LegalEntities legalEntities in Program.counterparties.LegalEntities)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                legalEntities.Id.ToString(),
                legalEntities.IdManager.ToString(),
                legalEntities.Manager.LastName,
                legalEntities.Name,
                legalEntities.Address,
                legalEntities.INN,
                legalEntities.KPP
                }); 
                item.Tag = legalEntities;
                listViewLegalEntities.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewLegalEntities.SelectedItems.Count == 1)
            {
                LegalEntities legalEntities = listViewLegalEntities.SelectedItems[0].Tag as LegalEntities;
                legalEntities.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                legalEntities.Name = textBoxName.Text;
                legalEntities.Address = textBoxAddress.Text;
                legalEntities.INN = textBoxINN.Text;
                legalEntities.KPP = textBoxKPP.Text;
                legalEntities.Address = textBoxAddress.Text;
                Program.counterparties.SaveChanges();
                ShowLegalEntities();
            }
        }

        private void listViewLegalEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLegalEntities.SelectedItems.Count == 1)
            {
                LegalEntities legalEntities = listViewLegalEntities.SelectedItems[0].Tag as LegalEntities;
                comboBoxManager.SelectedIndex = comboBoxManager.FindString(legalEntities.IdManager.ToString());
            }
            else
            {
                comboBoxManager.SelectedItem = null;
                textBoxName.Text = "";
                textBoxAddress.Text =  "";
                textBoxINN.Text = "";
                textBoxKPP.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewLegalEntities.SelectedItems.Count == 1)
                {
                    LegalEntities legalEntities = listViewLegalEntities.SelectedItems[0].Tag as LegalEntities;
                    Program.counterparties.LegalEntities.Remove(legalEntities);
                    Program.counterparties.SaveChanges();
                    ShowLegalEntities();
                }
                comboBoxManager.SelectedItem = null;
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxINN.Text = "";
                textBoxKPP.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
