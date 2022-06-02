using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class User
    {

        public User(string us)
        {
            UserName = UserName;
        }
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
                for(int i = 0; i < value.Length; i++)
                {
                    if (value.Length > 5 && value.Length < 25)
                    {
                        _userName = value;
                    }

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
                if (!String.IsNullOrEmpty(value) && (value.Length > 5 && value.Length < 25) && HasUpper(value) && HasLower(value) && IsDigit(value)) ;
                _password = value;




            }





        }
        static bool HasUpper(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsUpper(value[i]))
                    return true;
            }
            return false;
        }
        static bool HasLower(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLower(value[i]))
                    return true;
            }
            return false;
        }


        static bool IsDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsDigit(value[i]))
                    return true;
            }
            return false;


        }

        

        








        }








    
}
