using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab38
{
    public interface IObserver
    {
        void OnSubjectChanged(ISubject subject, int dx, int dy);

        List<ISubject> getSubjects();
    }
}
