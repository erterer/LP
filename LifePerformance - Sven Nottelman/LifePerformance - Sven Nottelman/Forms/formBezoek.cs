using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifePerformance___Sven_Nottelman.Data;
using LifePerformance___Sven_Nottelman.Logic;
using LifePerformance___Sven_Nottelman.Models;

namespace LifePerformance___Sven_Nottelman
{
    public partial class formBezoek : Form
    {
        //Het geopende project
        private Project project;

        //Maken van een bezoek
        private Bezoek bezoek;

        private DierenRepository repo;

        //Maken van de form en plaatsen van de plattegrond
        public formBezoek(Project project)
        {
            InitializeComponent();
            this.project = project;
            repo = new DierenRepository(new DierenOracleContext());
            LaadGebied();
            LaadDieren();
        }

        /// <summary>
        /// Deze methode haalt de kaart van het gebied op van de ingegeven link
        /// </summary>
        private void LaadGebied()
        {
            var web = WebRequest.Create("http://i.imgur.com/SjPPFJT.png");

            using (var response = web.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pbGebied.Image = Bitmap.FromStream(stream);
            }
        }

        private void LaadDieren()
        {
            repo.HaalDierenOp();
            if(repo.Error != string.Empty)
            {
                MessageBox.Show(repo.Error);
            }
            lbDieren.Items.Clear();
            foreach(var v in repo.Dieren)
            {
                lbDieren.Items.Add(v.Naam + "  " + v.Afkorting);
            }
        }

        private void pbGebied_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbMaken.Checked == true)
            {
                if (tbNaam.Text != string.Empty && lbDieren.Text != string.Empty && nudPunten.Value != 0)
                {
                    //Aanmaken graphics en zetten tekst
                    Graphics graphics = pbGebied.CreateGraphics();
                    string tekst = tbNaam.Text;
                    tbNaam.Text = string.Empty;

                    //Tekenen van de label met de ingevulde waarde
                    var point = new Point(e.X, e.Y);
                    var sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    graphics.DrawString(tekst, this.Font, Brushes.Black, point, sf);

                    //Maken van een waarneming
                    int uur = Convert.ToInt32(nudUren.Value);
                    int min = Convert.ToInt32(nudMinuten.Value);
                    int punten = Convert.ToInt32(nudPunten.Value);
                    DateTime tijdstip = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, uur, min, 10);

                    //if (cbSoort.Text == "Vogel aanwezig")
                    //{
                    //    bezoek.waarnemingen.Add(new Waarneming(tbNaam.Text, SoortWaarneming.VogelAanwezig, tijdstip, punten, new Vogel(tbNaamDier.Text, tbAfkorting.Text)));
                    //}
                    //else if(cbSoort.Text == "Territorium indicerend")
                    //{
                    //    bezoek.waarnemingen.Add(new Waarneming(tbNaam.Text, SoortWaarneming.TerritorumInciderend, tijdstip, punten, new Vogel(tbNaamDier.Text, tbAfkorting.Text)));
                    //}
                    //else if(cbSoort.Text == "Nest indicerend")
                    //{
                    //    bezoek.waarnemingen.Add(new Waarneming(tbNaam.Text, SoortWaarneming.NestIndicerend, tijdstip, punten, new Vogel(tbNaamDier.Text, tbAfkorting.Text)));
                    //}
                }
                else
                {
                    MessageBox.Show("Er ontbreken gegevens!");
                }
            }
            else if(rbSelecteren.Checked == true)
            {

            }
            
        }
    }
}
