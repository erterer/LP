using System;
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

namespace LifePerformance___Sven_Nottelman
{
    public partial class FormInloggen : Form
    {
        private string error;
        private GebruikerRepository gebruiker;
        public FormInloggen()
        {
            InitializeComponent();
            lblSucces.Visible = false;
            gebruiker = new GebruikerRepository(new GebruikerOracleContext());
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                if (gebruiker.Login(tbUsername.Text, tbPassword.Text, out error) == true)
                {
                    lblSucces.Visible = true;
                }
                else
                {
                    lblSucces.Visible = false;
                    if (error == string.Empty)
                    {
                        error = "Geen resultaat gevonden";
                    }
                    MessageBox.Show(error);
                }
            }
        }
    }
}
