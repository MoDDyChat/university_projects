using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab38
{
    public interface ISubject
    {
        void addObserver(IObserver _observer);

        void removeObserver(IObserver _observer);

        void notifyAll(int dx, int dy);

        List<IObserver> getObservers();
    }
}
