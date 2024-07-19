using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Question02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string[] storedName;
        private int[] storedPassword;
        private string[] role;
        private int size;
        public BasicAuthenticationService(int[] SP , string[] SN ,string[] R)
        {
            storedName =SN;
            storedPassword =SP;
            role = R;
        }
        
       

        public bool AuthenticateUser(string username, int password)
        {
            if (storedName is not null && storedPassword is not null )
            {
                for (int i = 0; i < storedName.Length; i++)
                {
                    if (storedName[i] == username && storedPassword[i] == password)
                    { return true; }
                }
            }
            
            return false;
        }

        public bool AuthorizeUser(string username , string r)
        {
            if (storedName is not null && role is not null)
            {
                for (int i = 0; i < storedName.Length; i++)
                {
                    if (storedName[i] == username && role[i] == r)
                    { return true; }
                }
            }

            return false;
        }

        public string[] StoredName
        {
            get 
            {
                return storedName; 
            }
        }
        public int[] StoredPassword { 
            get 
            { 
                return storedPassword;
            } 
        }

    }
}
