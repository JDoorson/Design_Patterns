using System;
using Opdracht1.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht1.Views
{
    public partial class TreinDisplay : Form , ITreinDisplay
    {
        private ITreinReis treinReis;

        public TreinDisplay(ITreinReis treinReis)
        {
            InitializeComponent();

            this.treinReis = treinReis;
            treinReis.Add(this);
        }

        private void HuidigStation_Click(object sender, EventArgs e)
        {

        }

        public void Update(string huidigStation, string huidigSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            lblHuidigStation.Text = huidigStation;
            lblSpoor.Text = huidigSpoor;
            lblAankomsttijd.Text = aankomstTijd.ToString("HH:mm");
            lblVertrektijd.Text = vertrekTijd.ToString("HH:mm");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
