using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.Observer
{ 
    public interface IObserver
    {
        public void Notify(string text);
    }
}
