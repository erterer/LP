using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifePerformance___Sven_Nottelman.Logic;
using LifePerformance___Sven_Nottelman.Models;
using LifePerformance___Sven_Nottelman.Data;

namespace LifePerformance___Sven_Nottelman.Forms
{
    public partial class Hoofdscherm : Form
    {
        //Repository voor de database
        private ProjectRepository repo;

        public Hoofdscherm()
        {
            InitializeComponent();
            repo = new ProjectRepository(new ProjectOracleContext());
            LaadProjecten();
        }

        /// <summary>
        /// Deze methode haalt alle prjecten op
        /// </summary>
        private void LaadProjecten()
        {
            repo.HaalProjectenOp();
            if (repo.Error != string.Empty)
            {
                MessageBox.Show(repo.Error);
            }
            lbProjecten.Items.Clear();
            foreach(var v in repo.Projecten)
            {
                lbProjecten.Items.Add(v.Naam);
            }
        }

        /// <summary>
        /// Met het klikken op de knop wordt het bestaande project geopend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenen_Click(object sender, EventArgs e)
        {
            if (lbProjecten.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een project");
            }
            else
            {
                foreach (var v in repo.Projecten)
                {
                    if (v.Naam == lbProjecten.SelectedItem.ToString())
                    {
                        var formBezoek = new formBezoek(v);
                        formBezoek.ShowDialog();
                    }
                }
            }
        }
    }
}
