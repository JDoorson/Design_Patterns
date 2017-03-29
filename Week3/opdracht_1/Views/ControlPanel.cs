using Opdracht1.Views;
using Opdracht1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht1.Controllers
{
    public partial class ControlPanel : Form
    {
        private ITreinReis treinreis = new TreinReis();
        private ITreinController treincontroller;
        private bool richtingZuid = true;

        public ControlPanel()
        {
            InitializeComponent();
            treincontroller = new TreinController(treinreis);
        }

        private void bttnVoegDisplayToe_Click(object sender, EventArgs e)
        {
            TreinDisplay display = new TreinDisplay(this.treinreis);
            treinreis.NotifyObservers();
            display.Show();
        }

        private void bttnVolgendStation_Click(object sender, EventArgs e)
        {
            bool eindstation = treincontroller.Notify(richtingZuid);

            if (eindstation)
            {
                bttnVolgendStation.Visible = false;
            }
        }

        private void bttnKeerOm_Click(object sender, EventArgs e)
        {
            bttnVolgendStation.Visible = true;
        }
    }
}
