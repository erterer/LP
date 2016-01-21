namespace LifePerformance___Sven_Nottelman.Forms
{
    partial class Hoofdscherm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbProjecten = new System.Windows.Forms.ListBox();
            this.btnOpenen = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinutenStart = new System.Windows.Forms.NumericUpDown();
            this.nudUrenStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinutenEind = new System.Windows.Forms.NumericUpDown();
            this.nudUrenEind = new System.Windows.Forms.NumericUpDown();
            this.lblEind = new System.Windows.Forms.Label();
            this.dateEind = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutenStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrenStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutenEind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrenEind)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projecten:";
            // 
            // lbProjecten
            // 
            this.lbProjecten.FormattingEnabled = true;
            this.lbProjecten.Location = new System.Drawing.Point(12, 37);
            this.lbProjecten.Name = "lbProjecten";
            this.lbProjecten.Size = new System.Drawing.Size(241, 95);
            this.lbProjecten.TabIndex = 1;
            // 
            // btnOpenen
            // 
            this.btnOpenen.Location = new System.Drawing.Point(12, 305);
            this.btnOpenen.Name = "btnOpenen";
            this.btnOpenen.Size = new System.Drawing.Size(241, 23);
            this.btnOpenen.TabIndex = 2;
            this.btnOpenen.Text = "Open project en log bezoek";
            this.btnOpenen.UseVisualStyleBackColor = true;
            this.btnOpenen.Click += new System.EventHandler(this.btnOpenen_Click);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 158);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(241, 20);
            this.dateStart.TabIndex = 3;
            this.dateStart.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 142);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // nudMinutenStart
            // 
            this.nudMinutenStart.Location = new System.Drawing.Point(73, 184);
            this.nudMinutenStart.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutenStart.Name = "nudMinutenStart";
            this.nudMinutenStart.Size = new System.Drawing.Size(39, 20);
            this.nudMinutenStart.TabIndex = 13;
            // 
            // nudUrenStart
            // 
            this.nudUrenStart.Location = new System.Drawing.Point(12, 184);
            this.nudUrenStart.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudUrenStart.Name = "nudUrenStart";
            this.nudUrenStart.Size = new System.Drawing.Size(39, 20);
            this.nudUrenStart.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = ":";
            // 
            // nudMinutenEind
            // 
            this.nudMinutenEind.Location = new System.Drawing.Point(73, 264);
            this.nudMinutenEind.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutenEind.Name = "nudMinutenEind";
            this.nudMinutenEind.Size = new System.Drawing.Size(39, 20);
            this.nudMinutenEind.TabIndex = 18;
            // 
            // nudUrenEind
            // 
            this.nudUrenEind.Location = new System.Drawing.Point(12, 264);
            this.nudUrenEind.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudUrenEind.Name = "nudUrenEind";
            this.nudUrenEind.Size = new System.Drawing.Size(39, 20);
            this.nudUrenEind.TabIndex = 17;
            // 
            // lblEind
            // 
            this.lblEind.AutoSize = true;
            this.lblEind.Location = new System.Drawing.Point(12, 222);
            this.lblEind.Name = "lblEind";
            this.lblEind.Size = new System.Drawing.Size(28, 13);
            this.lblEind.TabIndex = 15;
            this.lblEind.Text = "Eind";
            // 
            // dateEind
            // 
            this.dateEind.Location = new System.Drawing.Point(12, 238);
            this.dateEind.Name = "dateEind";
            this.dateEind.Size = new System.Drawing.Size(241, 20);
            this.dateEind.TabIndex = 14;
            this.dateEind.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMinutenEind);
            this.Controls.Add(this.nudUrenEind);
            this.Controls.Add(this.lblEind);
            this.Controls.Add(this.dateEind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMinutenStart);
            this.Controls.Add(this.nudUrenStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnOpenen);
            this.Controls.Add(this.lbProjecten);
            this.Controls.Add(this.label1);
            this.Name = "Hoofdscherm";
            this.Text = "Hoofdscherm";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutenStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrenStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutenEind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrenEind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProjecten;
        private System.Windows.Forms.Button btnOpenen;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinutenStart;
        private System.Windows.Forms.NumericUpDown nudUrenStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinutenEind;
        private System.Windows.Forms.NumericUpDown nudUrenEind;
        private System.Windows.Forms.Label lblEind;
        private System.Windows.Forms.DateTimePicker dateEind;
    }
}