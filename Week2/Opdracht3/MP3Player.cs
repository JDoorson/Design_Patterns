using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class MP3Player : ISubject
    {
        private List<IObserver> players;
        private List<Nummer> nummers;
        public Nummer HuidigNummer { get; private set; }
        Random rng = new Random();

        public MP3Player()
        {
            players = new List<IObserver>();
            nummers = Nummer.GetList();
        }

        public void NummerGewijzigd() {
            HuidigNummer = nummers[rng.Next(nummers.Count)];
            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            players.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            players.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver io in players)
                io.Update(HuidigNummer);
            Console.WriteLine();
        }
    }
}
