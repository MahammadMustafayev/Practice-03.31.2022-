using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_.Models
{
    interface IAccount
    {
        public bool Passwordchecker(string password);
        public void ShowInfo();
    }
}
