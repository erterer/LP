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
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.rbMaken = new System.Windows.Forms.RadioButton();
            this.rbSelecteren = new System.Windows.Forms.RadioButton();
            this.lblSoort = new System.Windows.Forms.Label();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.nudUur = new System.Windows.Forms.NumericUpDown();
            this.nudSeconde = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPunten = new System.Windows.Forms.NumericUpDown();
            this.tbNaamDier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAfkorting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGebied)).BeginInit();
            this.gbWaarneming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPunten)).BeginInit();
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
            this.gbWaarneming.Controls.Add(this.tbAfkorting);
            this.gbWaarneming.Controls.Add(this.label4);
            this.gbWaarneming.Controls.Add(this.tbNaamDier);
            this.gbWaarneming.Controls.Add(this.label5);
            this.gbWaarneming.Controls.Add(this.nudPunten);
            this.gbWaarneming.Controls.Add(this.label3);
            this.gbWaarneming.Controls.Add(this.label1);
            this.gbWaarneming.Controls.Add(this.label2);
            this.gbWaarneming.Controls.Add(this.nudSeconde);
            this.gbWaarneming.Controls.Add(this.nudUur);
            this.gbWaarneming.Controls.Add(this.cbSoort);
            this.gbWaarneming.Controls.Add(this.lblSoort);
            this.gbWaarneming.Controls.Add(this.rbSelecteren);
            this.gbWaarneming.Controls.Add(this.rbMaken);
            this.gbWaarneming.Controls.Add(this.tbNaam);
            this.gbWaarneming.Controls.Add(this.lblNaam);
            this.gbWaarneming.Location = new System.Drawing.Point(1183, 12);
            this.gbWaarneming.Name = "gbWaarneming";
            this.gbWaarneming.Size = new System.Drawing.Size(223, 407);
            this.gbWaarneming.TabIndex = 1;
            this.gbWaarneming.TabStop = false;
            this.gbWaarneming.Text = "Waarneming";
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
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(9, 77);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(185, 20);
            this.tbNaam.TabIndex = 1;
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
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(6, 120);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(95, 13);
            this.lblSoort.TabIndex = 6;
            this.lblSoort.Text = "Soort waarneming:";
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
            // nudUur
            // 
            this.nudUur.Location = new System.Drawing.Point(9, 190);
            this.nudUur.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudUur.Name = "nudUur";
            this.nudUur.Size = new System.Drawing.Size(39, 20);
            this.nudUur.TabIndex = 8;
            // 
            // nudSeconde
            // 
            this.nudSeconde.Location = new System.Drawing.Point(70, 190);
            this.nudSeconde.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeconde.Name = "nudSeconde";
            this.nudSeconde.Size = new System.Drawing.Size(39, 20);
            this.nudSeconde.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aantal punten:";
            // 
            // nudPunten
            // 
            this.nudPunten.Location = new System.Drawing.Point(9, 247);
            this.nudPunten.Name = "nudPunten";
            this.nudPunten.Size = new System.Drawing.Size(100, 20);
            this.nudPunten.TabIndex = 12;
            // 
            // tbNaamDier
            // 
            this.tbNaamDier.Location = new System.Drawing.Point(9, 313);
            this.tbNaamDier.Name = "tbNaamDier";
            this.tbNaamDier.Size = new System.Drawing.Size(185, 20);
            this.tbNaamDier.TabIndex = 16;
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
            // tbAfkorting
            // 
            this.tbAfkorting.Location = new System.Drawing.Point(9, 370);
            this.tbAfkorting.Name = "tbAfkorting";
            this.tbAfkorting.Size = new System.Drawing.Size(185, 20);
            this.tbAfkorting.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Afkorting dier:";
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
            ((System.ComponentModel.ISupportInitialize)(this.nudUur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPunten)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudSeconde;
        private System.Windows.Forms.NumericUpDown nudUur;
        private System.Windows.Forms.NumericUpDown nudPunten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAfkorting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNaamDier;
        private System.Windows.Forms.Label label5;
    }
}

