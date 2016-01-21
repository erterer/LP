using LifePerformance___Sven_Nottelman.Data;
using LifePerformance___Sven_Nottelman.Logic;
using System;
using System.Windows.Forms;

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
            //Controle of de gegevens goed worden ingevuld
            if (lbProjecten.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een project");
            }
            else if(nudMinutenStart.Value == 0 && nudMinutenEind.Value == 0 && nudUrenStart.Value == 0 && nudUrenEind.Value == 0)
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
                //Openen project en aanmaken nieuw bezoek
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
