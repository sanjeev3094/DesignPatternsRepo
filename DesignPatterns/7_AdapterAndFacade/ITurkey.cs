using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterAndFacade
{
    /// <summary>
    /// Adaptee Interface.
    /// This is adapted by the Adapater i.e. wrapped by the Adapter.
    /// </summary>
    public interface ITurkey
    {
        void Gobble();

        void Fly();
    }
}
