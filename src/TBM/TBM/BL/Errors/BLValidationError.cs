using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.BL.Errors
{
    public class BLValidationError : Exception
    {
        public BLValidationError(string message) : base(message)
        {
        }
    }
}
