using System;
using System.Collections.Generic;
using System.Text;

namespace Pracrtice31._03._2022_ehtiyyat_.Models
{
    class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
