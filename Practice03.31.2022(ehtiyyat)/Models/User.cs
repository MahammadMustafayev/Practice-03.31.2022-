using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_.Models
{
    class User : IAccount
    {
        private static  int _id;
        public int Id { get;  }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        static User()
        {
            _id = 0;
        }
        private User()
        {
            ++_id;
            Id = _id;
        }

        public User(string email,string password):this()
        {
            this.Email = email;
            this.Password = password;
        }
        public bool Passwordchecker(string password)
        {
            bool IsUpper = false;
            bool IsDigit = false;
            bool IsLower = false;
            if (password.Length >= 8 && !String.IsNullOrWhiteSpace(password) && !String.IsNullOrEmpty(password))
            {
                for (int i = 0; i < password.Length; i++)
                {

                    if (char.IsUpper(password[i])) IsUpper = true;
                    else if (char.IsDigit(password[i])) IsDigit = true;
                    else if (char.IsDigit(password[i])) IsLower = true;
                    if (IsUpper == true && IsLower == true && IsDigit == true) return true;
                }
            }
            return false;
        }      
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} FullName:{FullName} Email:{Email}");
        }

       
    }
}
