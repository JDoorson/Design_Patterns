using Opdracht1.Models;
using Opdracht1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Controllers
{
    class TreinController : ITreinController
    {
        private ITreinReis treinreis;   // = new TreinReis();

        public TreinController(ITreinReis treinreis)
        {
            this.treinreis = treinreis; 
        }

       
        public void VoegDisplayToe()
        {
            ITreinDisplay display = new TreinDisplay(treinreis);
            treinreis.Add(display);
        }
    

        public bool Notify(bool heen)
        {
           bool eindstation = treinreis.VolgendStation(heen);
           return eindstation;
        }
    }
}
