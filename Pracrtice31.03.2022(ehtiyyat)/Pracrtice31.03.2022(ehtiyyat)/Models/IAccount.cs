using System;
using System.Collections.Generic;
using System.Text;

namespace Pracrtice31._03._2022_ehtiyyat_.Models
{
    interface IAccount
    {
        public bool Passwordchecker(string password);
        public void ShowInfo();
    }
}
