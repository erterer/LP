namespace LifePerformance___Sven_Nottelman.Forms
{
    partial class formOpties
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
            this.btnProjectSluiten = new System.Windows.Forms.Button();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra projectopties";
            // 
            // btnProjectSluiten
            // 
            this.btnProjectSluiten.ForeColor = System.Drawing.Color.Red;
            this.btnProjectSluiten.Location = new System.Drawing.Point(35, 90);
            this.btnProjectSluiten.Name = "btnProjectSluiten";
            this.btnProjectSluiten.Size = new System.Drawing.Size(136, 23);
            this.btnProjectSluiten.TabIndex = 1;
            this.btnProjectSluiten.Text = "Project sluiten";
            this.btnProjectSluiten.UseVisualStyleBackColor = true;
            this.btnProjectSluiten.Click += new System.EventHandler(this.btnProjectSluiten_Click);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(35, 50);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(136, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken broedparen";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // formOpties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 125);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.btnProjectSluiten);
            this.Controls.Add(this.label1);
            this.Name = "formOpties";
            this.Text = "formOpties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProjectSluiten;
        private System.Windows.Forms.Button btnBereken;
    }
}