using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;


namespace AutomationFramework
{
    public class TestDataReader
    {

        public static string[] GetLoginCredentials(string credtype)
        {
            string[] allLines = File.ReadAllLines(@"Test Data/LoginPageTestData.csv");
            var query = from line in allLines

                let data = line.Split(',')

                select new

                {

                    Type = data[0],

                    Username = data[1],

                    Password = data[2]

                };

            string[] credentials = new string[2];
            foreach (var s in query)
            {
                if (s.Type == credtype)
                {
                    credentials[0] = s.Username;
                    credentials[1] = s.Password;
                }
            }
            return credentials;
        }

     }
}




    


