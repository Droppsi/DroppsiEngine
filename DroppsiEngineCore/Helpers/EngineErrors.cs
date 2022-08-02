using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngineCore.Helpers
{
    public class EngineErrors : Exception
    {
        public EngineErrors()
        {
        }

        public EngineErrors(string message) : base(message)
        {
        }

        public EngineErrors(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
