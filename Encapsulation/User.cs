using System;
namespace Encapsulation
{
    public class User
    {
        private string _userName;
        private string _password;



        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length > 6 || value.Length < 25)
                {
                    _userName = value;
     
                }
         
            }
        }


        public string Password
        {
            get
            {
                return _password;

            }
            set
            {
                if (value.Length > 8 || value.Length < 25 || HasDigit(value) || HasUpper(value) || HasLower(value))
                {
                    _password = value;

                }     
                
            }
        }

        public  User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public static bool HasDigit(string value)
        {
            foreach (char a in value)
            {
                if (char.IsDigit(a))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasUpper(string value)
        {
            foreach (char a in value)
            {
                if (char.IsUpper(a))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasLower(string value)
        {
            foreach (char a in value)
            {
                if (char.IsLower(a))
                {
                    return true;
                }
            }
            return false;
        }  
    }

}

