namespace Counterparties
{
    partial class FormMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewMedicine = new System.Windows.Forms.ListView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightPink;
            this.buttonAdd.Location = new System.Drawing.Point(459, 295);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 33);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightPink;
            this.buttonEdit.Location = new System.Drawing.Point(579, 295);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 33);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.LightPink;
            this.buttonDel.Location = new System.Drawing.Point(699, 295);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 33);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewMedicine
            // 
            this.listViewMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMedicine.FullRowSelect = true;
            this.listViewMedicine.GridLines = true;
            this.listViewMedicine.HideSelection = false;
            this.listViewMedicine.Location = new System.Drawing.Point(17, 128);
            this.listViewMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMedicine.MultiSelect = false;
            this.listViewMedicine.Name = "listViewMedicine";
            this.listViewMedicine.Size = new System.Drawing.Size(782, 157);
            this.listViewMedicine.TabIndex = 3;
            this.listViewMedicine.UseCompatibleStateImageBehavior = false;
            this.listViewMedicine.View = System.Windows.Forms.View.Details;
            this.listViewMedicine.SelectedIndexChanged += new System.EventHandler(this.listViewMedicine_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 59);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 27);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Location = new System.Drawing.Point(343, 59);
            this.textBoxDosage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(132, 27);
            this.textBoxDosage.TabIndex = 6;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(507, 59);
            this.textBoxManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(132, 27);
            this.textBoxManufacturer.TabIndex = 7;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(667, 59);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(132, 27);
            this.textBoxDate.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxType.Location = new System.Drawing.Point(175, 59);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(132, 27);
            this.comboBoxType.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 20);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 19);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Название";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(171, 20);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(115, 19);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Форма выпуска";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Location = new System.Drawing.Point(339, 20);
            this.labelDosage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(82, 19);
            this.labelDosage.TabIndex = 12;
            this.labelDosage.Text = "Дозировка";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(503, 20);
            this.labelManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(115, 19);
            this.labelManufacturer.TabIndex = 13;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(663, 20);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(107, 19);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Срок годности";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дозировка";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Производитель";
            this.columnHeader4.Width = 167;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Срок годности";
            this.columnHeader5.Width = 172;
            // 
            // FormMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(809, 349);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewMedicine);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMedicine";
            this.Text = "Лекарства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewMedicine;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}