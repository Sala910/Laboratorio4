using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.ChainOfResponsibility
{
    public interface IHandler
    {
        void HandleRequest(string request);
        void SetNext(IHandler handler);
    }

}
