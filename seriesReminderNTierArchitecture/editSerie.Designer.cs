namespace seriesReminderNTierArchitecture
{
    partial class editSerie
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.numericUpDownEpisode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSeason = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpisode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Rating";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(169, 227);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(103, 23);
            this.BtnEdit.TabIndex = 36;
            this.BtnEdit.Text = "edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // numericUpDownEpisode
            // 
            this.numericUpDownEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownEpisode.Location = new System.Drawing.Point(180, 181);
            this.numericUpDownEpisode.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownEpisode.Name = "numericUpDownEpisode";
            this.numericUpDownEpisode.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownEpisode.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Episode";
            // 
            // numericUpDownSeason
            // 
            this.numericUpDownSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSeason.Location = new System.Drawing.Point(61, 181);
            this.numericUpDownSeason.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSeason.Name = "numericUpDownSeason";
            this.numericUpDownSeason.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownSeason.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Season";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 148);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 20);
            this.tbName.TabIndex = 30;
            // 
            // cmbRating
            // 
            this.cmbRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(12, 108);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(260, 21);
            this.cmbRating.TabIndex = 29;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(12, 68);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(260, 21);
            this.cmbStatus.TabIndex = 28;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(12, 28);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(260, 21);
            this.cmbCategorie.TabIndex = 27;
            // 
            // editSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.numericUpDownEpisode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSeason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbCategorie);
            this.Name = "editSerie";
            this.Text = "editSerie";
            this.Load += new System.EventHandler(this.editSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpisode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.NumericUpDown numericUpDownEpisode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSeason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCategorie;
    }
}