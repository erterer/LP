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

        //Repository dieren
        private DierenRepository repo;

        //Diereninformatie
        string dierNaam;
        string dierAfkorting;

        //Maken van de form en plaatsen van de plattegrond
        public formBezoek(Project project, DateTime start, DateTime eind)
        {
            InitializeComponent();
            this.project = project;
            repo = new DierenRepository(new DierenOracleContext());
            LaadGebied();
            LaadDieren();
            bezoek = new Bezoek(start, eind);
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

        /// <summary>
        /// Deze methode haalt alle dieren op en zet ze in de lijst
        /// </summary>
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
                lbDieren.Items.Add(v.Naam);
            }
        }

        private void WisInput()
        {
            tbNaam.Text = string.Empty;
            cbSoort.SelectedItem = string.Empty;
            nudMinuten.Value = 0;
            nudPunten.Value = 0;
            nudUren.Value = 0;
            rbMaken.Checked = false;
            rbSelecteren.Checked = false;
        }

        /// <summary>
        /// Deze muisklik maakt een label aan op de kaart en maakt hier direct een waarneming van, hiervoor worden
        /// de ingevulde gegevens gebruikt
        /// </summary>
        /// <param name="sender">Event mouseclick</param>
        /// <param name="e">Event mouseclick</param>
        private void pbGebied_MouseClick(object sender, MouseEventArgs e)
        {
            //Dier toevoegen
            if (rbMaken.Checked == true)
            {
                //Controle op de input
                if (tbNaam.Text != string.Empty || lbDieren.SelectedItem == null || nudPunten.Value != 0)
                {
                    //Aanmaken graphics en zetten tekst
                    Graphics graphics = pbGebied.CreateGraphics();
                    string tekst = tbNaam.Text;

                    //Tekenen van de label met de ingevulde waarde
                    var point = new Point(e.X, e.Y);
                    var sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    graphics.DrawString(tekst, this.Font, Brushes.Black, point, sf);

                    //Tijdstip en punten verzamelen
                    int uur = Convert.ToInt32(nudUren.Value);
                    int min = Convert.ToInt32(nudMinuten.Value);
                    int punten = Convert.ToInt32(nudPunten.Value);
                    DateTime tijdstip = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, uur, min, 10);

                    //Ophalen geselecteerd dier
                    foreach(var v in repo.Dieren)
                    {
                        if (repo.Dieren.IndexOf(v) == lbDieren.SelectedIndex)
                        {
                            dierNaam = v.Naam;
                            dierAfkorting = v.Afkorting;
                        }
                    }

                    //Aanmaken waarneming
                    if (cbSoort.Text == "Vogel aanwezig")
                    {
                        bezoek.waarnemingen.Add(new Waarneming(tbNaam.Text, SoortWaarneming.VogelAanwezig, tijdstip, punten, new Vogel(dierNaam, dierAfkorting)));
                    }
                    else if (cbSoort.Text == "Territorium indicerend")
                    {
                        bezoek.waarnemingen.Add(new Waarneming(tbNaam.Text, SoortWaarneming.TerritorumInciderend, tijdstip, punten, new Vogel(dierNaam, dierAfkorting)));
                    }
                    else if (cbSoort.Text == "Nest indicerend")
                    {
                        bezoek.waarnemingen.Add(new Waarneming(tbNaam.Text, SoortWaarneming.NestIndicerend, tijdstip, punten, new Vogel(dierNaam, dierAfkorting)));
                    }
                }
                else
                {
                    MessageBox.Show("Er ontbreken gegevens!");
                }
                WisInput();
            }
            else if(rbSelecteren.Checked == true)
            {
                //nog niet ingevoegd
            }
            
        }

        /// <summary>
        /// Deze button zorgt ervoor dat alle waarnemingen lokaal kunnen worden opgeslagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if(bezoek.SaveToXML(bezoek) == true)
            {
                MessageBox.Show("Bezoek opgeslagen");
            }
            else
            {
                MessageBox.Show("Er is een onbekende fout opgetreden bij het opslaan");
            }
        }

        /// <summary>
        /// Achter deze button bevind zich een form met extra mogelijkheden voor het project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpties_Click(object sender, EventArgs e)
        {
            var f = new Forms.formOpties();
            f.ShowDialog();
        }
    }
}
