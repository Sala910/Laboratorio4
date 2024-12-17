using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.ChainOfResponsibility
{
    public class HandlerB : IHandler
    {
        private IHandler _next;

        public void HandleRequest(string request)
        {
            if (request == "TypeB")
                Console.WriteLine("HandlerB обработал запрос.");
            else
                _next?.HandleRequest(request);
        }

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }
    }

}
