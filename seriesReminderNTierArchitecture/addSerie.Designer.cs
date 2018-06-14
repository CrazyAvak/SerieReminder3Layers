namespace seriesReminderNTierArchitecture
{
    partial class addSerie
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.numericUpDownEpisode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSeason = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpisode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(92, 232);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 23);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // numericUpDownEpisode
            // 
            this.numericUpDownEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownEpisode.Location = new System.Drawing.Point(181, 186);
            this.numericUpDownEpisode.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownEpisode.Name = "numericUpDownEpisode";
            this.numericUpDownEpisode.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownEpisode.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(130, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Episode";
            // 
            // numericUpDownSeason
            // 
            this.numericUpDownSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSeason.Location = new System.Drawing.Point(62, 186);
            this.numericUpDownSeason.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSeason.Name = "numericUpDownSeason";
            this.numericUpDownSeason.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownSeason.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Season";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 20);
            this.tbName.TabIndex = 13;
            // 
            // cmbRating
            // 
            this.cmbRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(13, 113);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(260, 21);
            this.cmbRating.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(13, 73);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(260, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(13, 33);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(260, 21);
            this.cmbCategorie.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // addSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 267);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.numericUpDownEpisode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSeason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbCategorie);
            this.Name = "addSerie";
            this.Text = "addSerie";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpisode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownEpisode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSeason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}