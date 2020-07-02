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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            ShowManager();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.LastName = textBoxLastName.Text;
            manager.IO = textBoxIO.Text;
            manager.Email = textBoxEmail.Text;
            Program.counterparties.Manager.Add(manager);
            Program.counterparties.SaveChanges();
            ShowManager();
        }

        void ShowManager()
        {
            listViewManager.Items.Clear();
            foreach (Manager manager in Program.counterparties.Manager)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                manager.Id.ToString(), manager.LastName, manager.IO, manager.Email
                });
                item.Tag = manager;
                listViewManager.Items.Add(item);
            }
            listViewManager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                Manager manager = listViewManager.SelectedItems[0].Tag as Manager;
                manager.LastName = textBoxLastName.Text;
                manager.IO = textBoxIO.Text;
                manager.Email = textBoxEmail.Text;
                Program.counterparties.SaveChanges();
                ShowManager();
            }
        }

        private void listViewManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                Manager manager = listViewManager.SelectedItems[0].Tag as Manager;
                textBoxLastName.Text = manager.LastName;
                textBoxIO.Text = manager.IO;
                textBoxEmail.Text = manager.Email;
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxIO.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManager.SelectedItems.Count == 1)
                {
                    Manager manager = listViewManager.SelectedItems[0].Tag as Manager;
                    Program.counterparties.Manager.Remove(manager);
                    Program.counterparties.SaveChanges();
                    ShowManager();
                }
                textBoxLastName.Text = "";
                textBoxIO.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
