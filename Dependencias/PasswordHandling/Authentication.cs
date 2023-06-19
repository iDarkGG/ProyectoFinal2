using Azure;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Dependencias.PasswordHandling
{
    public class Authentication
    {
        HashCreator passwordhasher = new HashCreator();
        Regex EmailPattern = new Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

        //Login Auth
        public bool SintaxVerifier(string string1, string string2)
        {
            if (!string1.IsNullOrEmpty() & !string2.IsNullOrEmpty())
            {
                return true;
            }
            return false;
        }


        public bool PasswordChecksum(string password)
        {
            if(password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        //Register Auth
        public bool PasswordIsMatch(string password, string confPassword)
        {
            //Verifies if strings that passes thru are not null or empty
            if (SintaxVerifier(password, confPassword))
            {
                //Verifies if both Passwords comply to the "not less than 8 digits rule"
                if(PasswordChecksum(password) & PasswordChecksum(confPassword))
                {
                    //Verifies if both passwords are the same
                    if(password.Equals(confPassword))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool EmailSintaxVerifier(string email)
        {
            if (EmailPattern.IsMatch(email))
            {
                return true;
            }
            return false;
        }

        //LOG IN CHECKSUMS

        public async Task<bool> LogInChechsum(string Username, string password)
        {

            try
            {
                using(HttpClient client = new HttpClient())
                {
                    var APIUrl = new Uri("https://localhost:7274/ApiTienda/Users/Admin");
                    var Response =  client.GetAsync(APIUrl).Result;


                    var output = Response.Content.ReadAsStringAsync().Result;
                    UserScheme DeserializedUser = JsonSerializer.Deserialize<UserScheme>(output);

                    if (passwordhasher.EncryptPassword(password))
                    {
                        return passwordhasher.CompareHash(passwordhasher.FinalHash, DeserializedUser.password);
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            

            return false;
        }

    }
}
