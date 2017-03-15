using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    interface IObservable
    {
        void RegisterObserver(ZonneDisplay display);
        void RemoveObserver(ZonneDisplay display);
        void NotifyObservers();
    }
}
