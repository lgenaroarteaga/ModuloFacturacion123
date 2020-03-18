using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Aggregate
{
    public interface IInternalEventHandler<EventArgs> 
    {
        event EventHandler<EventArgs> Handle;

    }
}
