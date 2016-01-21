using LifePerformance___Sven_Nottelman.Models;
using System;
using System.Windows.Forms;

namespace LifePerformance___Sven_Nottelman.Forms
{
    public partial class formOpties : Form
    {
        //Object bezoek voor extra opties
        public Bezoek Bezoek { get; set; }

        //Object project, welke is geopend
        public Project Project { get; set; }

        //Gebied voor het berekenen van alle broedparen
        public Gebied Gebied { get; set; }

        /// <summary>
        /// Zetten van de objecten
        /// </summary>
        /// <param name="bezoek"></param>
        /// <param name="project"></param>
        public formOpties(Bezoek bezoek, Project project)
        {
            InitializeComponent();
            Bezoek = bezoek;
            Project = project;
        }

        /// <summary>
        /// Berekenen van alle broedparen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBereken_Click(object sender, EventArgs e)
        {
            foreach(var v in Bezoek.waarnemingen)
            {
                Gebied.PrintBroedparen(v.Dier);
            }
            //De broedparen worden wegens tijdgebrek niet in een file afgedrukt
        }

        private void btnProjectSluiten_Click(object sender, EventArgs e)
        {
            //Als de uitdraai van alle broedparen succesvol is kan het project worden verwijderd.
            //Wegens tijdgebrek heb ik dit nog niet kunnen realiseren, de stap die hiervoor komt is het schrijven van de broedparen
        }
    }
}
