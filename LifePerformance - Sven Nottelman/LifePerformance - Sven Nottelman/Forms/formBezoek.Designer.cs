namespace LifePerformance___Sven_Nottelman
{
    partial class formBezoek
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
            this.pbGebied = new System.Windows.Forms.PictureBox();
            this.gbWaarneming = new System.Windows.Forms.GroupBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.lbDieren = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPunten = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinuten = new System.Windows.Forms.NumericUpDown();
            this.nudUren = new System.Windows.Forms.NumericUpDown();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.lblSoort = new System.Windows.Forms.Label();
            this.rbSelecteren = new System.Windows.Forms.RadioButton();
            this.rbMaken = new System.Windows.Forms.RadioButton();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnOpties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGebied)).BeginInit();
            this.gbWaarneming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPunten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUren)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGebied
            // 
            this.pbGebied.Location = new System.Drawing.Point(12, 12);
            this.pbGebied.Name = "pbGebied";
            this.pbGebied.Size = new System.Drawing.Size(1152, 669);
            this.pbGebied.TabIndex = 0;
            this.pbGebied.TabStop = false;
            this.pbGebied.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGebied_MouseClick);
            // 
            // gbWaarneming
            // 
            this.gbWaarneming.Controls.Add(this.btnOpties);
            this.gbWaarneming.Controls.Add(this.btnOpslaan);
            this.gbWaarneming.Controls.Add(this.lbDieren);
            this.gbWaarneming.Controls.Add(this.label5);
            this.gbWaarneming.Controls.Add(this.nudPunten);
            this.gbWaarneming.Controls.Add(this.label3);
            this.gbWaarneming.Controls.Add(this.label1);
            this.gbWaarneming.Controls.Add(this.label2);
            this.gbWaarneming.Controls.Add(this.nudMinuten);
            this.gbWaarneming.Controls.Add(this.nudUren);
            this.gbWaarneming.Controls.Add(this.cbSoort);
            this.gbWaarneming.Controls.Add(this.lblSoort);
            this.gbWaarneming.Controls.Add(this.rbSelecteren);
            this.gbWaarneming.Controls.Add(this.rbMaken);
            this.gbWaarneming.Controls.Add(this.tbNaam);
            this.gbWaarneming.Controls.Add(this.lblNaam);
            this.gbWaarneming.Location = new System.Drawing.Point(1183, 12);
            this.gbWaarneming.Name = "gbWaarneming";
            this.gbWaarneming.Size = new System.Drawing.Size(223, 669);
            this.gbWaarneming.TabIndex = 1;
            this.gbWaarneming.TabStop = false;
            this.gbWaarneming.Text = "Waarneming";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(118, 625);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(99, 38);
            this.btnOpslaan.TabIndex = 17;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // lbDieren
            // 
            this.lbDieren.FormattingEnabled = true;
            this.lbDieren.Location = new System.Drawing.Point(9, 313);
            this.lbDieren.Name = "lbDieren";
            this.lbDieren.Size = new System.Drawing.Size(185, 290);
            this.lbDieren.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Naam waargenomen dier:";
            // 
            // nudPunten
            // 
            this.nudPunten.Location = new System.Drawing.Point(9, 247);
            this.nudPunten.Name = "nudPunten";
            this.nudPunten.Size = new System.Drawing.Size(100, 20);
            this.nudPunten.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aantal punten:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tijdstip:";
            // 
            // nudMinuten
            // 
            this.nudMinuten.Location = new System.Drawing.Point(70, 190);
            this.nudMinuten.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinuten.Name = "nudMinuten";
            this.nudMinuten.Size = new System.Drawing.Size(39, 20);
            this.nudMinuten.TabIndex = 9;
            // 
            // nudUren
            // 
            this.nudUren.Location = new System.Drawing.Point(9, 190);
            this.nudUren.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudUren.Name = "nudUren";
            this.nudUren.Size = new System.Drawing.Size(39, 20);
            this.nudUren.TabIndex = 8;
            // 
            // cbSoort
            // 
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Items.AddRange(new object[] {
            "Vogel aanwezig",
            "Territorium indicerend",
            "Nest indicerend"});
            this.cbSoort.Location = new System.Drawing.Point(9, 136);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(185, 21);
            this.cbSoort.TabIndex = 7;
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(6, 120);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(95, 13);
            this.lblSoort.TabIndex = 6;
            this.lblSoort.Text = "Soort waarneming:";
            // 
            // rbSelecteren
            // 
            this.rbSelecteren.AutoSize = true;
            this.rbSelecteren.Location = new System.Drawing.Point(118, 19);
            this.rbSelecteren.Name = "rbSelecteren";
            this.rbSelecteren.Size = new System.Drawing.Size(76, 17);
            this.rbSelecteren.TabIndex = 3;
            this.rbSelecteren.TabStop = true;
            this.rbSelecteren.Text = "Selecteren";
            this.rbSelecteren.UseVisualStyleBackColor = true;
            // 
            // rbMaken
            // 
            this.rbMaken.AutoSize = true;
            this.rbMaken.Location = new System.Drawing.Point(9, 19);
            this.rbMaken.Name = "rbMaken";
            this.rbMaken.Size = new System.Drawing.Size(58, 17);
            this.rbMaken.TabIndex = 2;
            this.rbMaken.TabStop = true;
            this.rbMaken.Text = "Maken";
            this.rbMaken.UseVisualStyleBackColor = true;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(9, 77);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(185, 20);
            this.tbNaam.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(6, 61);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam:";
            // 
            // btnOpties
            // 
            this.btnOpties.Location = new System.Drawing.Point(6, 625);
            this.btnOpties.Name = "btnOpties";
            this.btnOpties.Size = new System.Drawing.Size(95, 38);
            this.btnOpties.TabIndex = 18;
            this.btnOpties.Text = "Opties";
            this.btnOpties.UseVisualStyleBackColor = true;
            this.btnOpties.Click += new System.EventHandler(this.btnOpties_Click);
            // 
            // formBezoek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 701);
            this.Controls.Add(this.gbWaarneming);
            this.Controls.Add(this.pbGebied);
            this.Name = "formBezoek";
            this.Text = "Nieuw bezoek";
            ((System.ComponentModel.ISupportInitialize)(this.pbGebied)).EndInit();
            this.gbWaarneming.ResumeLayout(false);
            this.gbWaarneming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPunten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGebied;
        private System.Windows.Forms.GroupBox gbWaarneming;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.RadioButton rbSelecteren;
        private System.Windows.Forms.RadioButton rbMaken;
        private System.Windows.Forms.ComboBox cbSoort;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinuten;
        private System.Windows.Forms.NumericUpDown nudUren;
        private System.Windows.Forms.NumericUpDown nudPunten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDieren;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnOpties;
    }
}

