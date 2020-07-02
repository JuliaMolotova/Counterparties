namespace Counterparties
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonIndividuals = new System.Windows.Forms.Button();
            this.buttonLegalEntities = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManager
            // 
            this.buttonManager.BackColor = System.Drawing.Color.LightPink;
            this.buttonManager.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManager.Location = new System.Drawing.Point(12, 89);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(200, 50);
            this.buttonManager.TabIndex = 0;
            this.buttonManager.Text = "Менеджеры";
            this.buttonManager.UseVisualStyleBackColor = false;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonIndividuals
            // 
            this.buttonIndividuals.BackColor = System.Drawing.Color.LightPink;
            this.buttonIndividuals.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIndividuals.Location = new System.Drawing.Point(12, 145);
            this.buttonIndividuals.Name = "buttonIndividuals";
            this.buttonIndividuals.Size = new System.Drawing.Size(200, 50);
            this.buttonIndividuals.TabIndex = 1;
            this.buttonIndividuals.Text = "Физические лица";
            this.buttonIndividuals.UseVisualStyleBackColor = false;
            this.buttonIndividuals.Click += new System.EventHandler(this.buttonIndividuals_Click);
            // 
            // buttonLegalEntities
            // 
            this.buttonLegalEntities.BackColor = System.Drawing.Color.LightPink;
            this.buttonLegalEntities.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLegalEntities.Location = new System.Drawing.Point(12, 201);
            this.buttonLegalEntities.Name = "buttonLegalEntities";
            this.buttonLegalEntities.Size = new System.Drawing.Size(200, 50);
            this.buttonLegalEntities.TabIndex = 3;
            this.buttonLegalEntities.Text = "Юридические лица";
            this.buttonLegalEntities.UseVisualStyleBackColor = false;
            this.buttonLegalEntities.Click += new System.EventHandler(this.buttonLegalEntities_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Counterparties.Properties.Resources.mclogo5536fc9343e9ab0aca071354084dd3cc;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(229, 269);
            this.Controls.Add(this.buttonLegalEntities);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonIndividuals);
            this.Controls.Add(this.buttonManager);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormMenu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonIndividuals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLegalEntities;
    }
}

