using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab04_Ex1
{
    class CustomStackOverFlowException : Exception
    {
        public CustomStackOverFlowException(string message) : base(message)
        {
        }
    }
}
