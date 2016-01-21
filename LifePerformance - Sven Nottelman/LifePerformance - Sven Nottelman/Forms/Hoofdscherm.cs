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
            else if(nudMinutenStart.Value == 0 || nudMinutenEind.Value == 0 || nudUrenStart.Value == 0 || nudUrenEind.Value == 0)
            {
                MessageBox.Show("Vul geldige tijden in");
            }
            else if(dateStart.Value.Year == 2010 && dateStart.Value.Day == 1 && dateStart.Value.Month == 1)
            {
                MessageBox.Show("Vul een geldige datum in");
            }
            else if (dateEind.Value.Year == 2010 && dateEind.Value.Day == 1 && dateEind.Value.Month == 1)
            {
                MessageBox.Show("Vul een geldige datum in");
            }
            else
            {
                foreach (var v in repo.Projecten)
                {
                    if (v.Naam == lbProjecten.SelectedItem.ToString())
                    {
                        DateTime start = new DateTime(dateStart.Value.Year, dateStart.Value.Month, dateStart.Value.Day, Convert.ToInt32(nudUrenStart.Value), Convert.ToInt32(nudMinutenStart.Value), 0);
                        DateTime eind = new DateTime(dateEind.Value.Year, dateEind.Value.Month, dateEind.Value.Day, Convert.ToInt32(nudUrenEind.Value), Convert.ToInt32(nudMinutenEind.Value), 0);
                        var formBezoek = new formBezoek(v, start, eind);
                        formBezoek.ShowDialog();
                    }
                }
            }
        }
    }
}
