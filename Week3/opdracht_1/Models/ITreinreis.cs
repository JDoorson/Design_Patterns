using Opdracht1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Models
{
    public interface ITreinReis
    {
        void Add(ITreinDisplay display);
        void Remove(ITreinDisplay display);
        void NotifyObservers();
        bool VolgendStation(bool heen);
    }
}
