using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifePerformance___Sven_Nottelman.Models;

namespace LifePerformance___Sven_Nottelman.Forms
{
    public partial class formOpties : Form
    {
        //Object bezoek voor extra opties
        public Bezoek Bezoek { get; set; }

        //Object project, welke is geopend
        public Project Project { get; set; }

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

        private void btnBereken_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProjectSluiten_Click(object sender, EventArgs e)
        {

        }
    }
}
