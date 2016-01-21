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
using LifePerformance___Sven_Nottelman.Models;

namespace LifePerformance___Sven_Nottelman
{
    public partial class formBezoek : Form
    {
        //Maken van een bezoek
        private Bezoek bezoek;

        //Maken van de form en plaatsen van de plattegrond
        public formBezoek()
        {
            InitializeComponent();
            LaadGebied();
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

        private void pbGebied_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbMaken.Checked == true)
            {
                if (tbNaam.Text != string.Empty && tbNaamDier.Text != string.Empty && tbAfkorting.Text != string.Empty
                    && nudPunten.Value != 0)
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
                    SoortWaarneming soort;
                    DateTime tijdstip = new DateTime()
                    bezoek.waarnemingen.Add(new Waarneming(tbNaamDier.Text, soort, ))
                }
                else
                {
                    MessageBox.Show("Vul een naam in!");
                }
            }
            else if(rbSelecteren.Checked == true)
            {

            }
            
        }
    }
}
