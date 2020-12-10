using System;
using System.Collections.Generic;
using System.Text;

namespace SportsbookAggregation
{
    class TeamNotFoundException : Exception
    {
        public TeamNotFoundException()
        {
        }

        public TeamNotFoundException(string message)
            : base(message)
        {
        }

        public TeamNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
