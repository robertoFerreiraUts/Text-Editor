using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textEditor
{
    class User 
    {
        String userName, password, accountType, fName, lName, dob;

        public User(String userName, String password, String accountType, String fName, String lName, String dob)
        {
            this.userName = userName;
            this.password = password;
            this.accountType = accountType;
            this.fName = fName;
            this.lName = lName;
            this.dob = dob;
        }

        public User()
        {
            this.userName = "";
            this.password = "";
            this.accountType = "";
            this.fName = "";
            this.lName = "";
            this.dob = "";
        }

        public void LoadUser(string fileLine)
        {
            // Split the comma seperated string into fields 
            string[] fields = fileLine.Split(',');

            // Assign values to respective properties/ members
            userName = fields[0];
            password = fields[1];
            accountType = fields[2];
            fName = fields[3];
            lName = fields[4];
            dob = fields[5];
        }

        public String getUsername()
        {
            return userName;
        }
        public String getPassword()
        {
            return password;
        }
        public String getAccountType()
        {
            return accountType;
        }
        public String getFName()
        {
            return fName;
        }
        public String getLName()
        {
            return lName;
        }
        public String getDob()
        {
            return dob;
        }
        public void setUserName(String userName)
        {
            this.userName = userName;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setAccountType(String accountType)
        {
            this.accountType = accountType;
        }
        public void setFName(String fName)
        {
            this.fName = fName;
        }
        public void setLName(String lName)
        {
            this.lName = lName;
        }
        public void setDob(String dob)
        {
            this.dob = dob;
        }
    }
}
