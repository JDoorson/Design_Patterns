using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class ZonnepaneelSysteem : IObservable
    {
        private Random random;
        private List<IObserver> observers;
        
        public int Wattage { get; set; }

        public ZonnepaneelSysteem()
        {
            random = new Random();
            observers = new List<IObserver>();
        }

        public void NieuweMeting()
        {
            Wattage = random.Next();
            NotifyObservers();
        }

        public void RegisterObserver(ZonneDisplay display)
        {
            observers.Add(display);
        }

        public void RemoveObserver(ZonneDisplay display)
        {
            observers.Remove(display);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
                o.Update(Wattage);
        }
    }
}
