using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textEditor
{
    class UserList
    {
        private List<User> users;
        private User loggedIn;
        // userList constructor
        public UserList()
        {
            // Create an instance of List<>
            users = new List<User>();
        }

        // Method to process a string which contain a single line for the emp.txt
        // The lfile name is passed as a parameter to the Method
        public void LoadUsers(string filename)
        {
            // Read the file content using the StreamReader
            StreamReader fileContent = new StreamReader(filename);
            // Create an object of user class
            User empTemp;

            // Read the StremReader till the last line
            while (!fileContent.EndOfStream)
            {
                // there are still users to be loaded
                empTemp = new User();
                // Read each line and from the StreamReader
                string line = fileContent.ReadLine();
                // Load the user detail from file to respective fields
                empTemp.LoadUser(line);
                // Add the detall to the list collection
                users.Add(empTemp);
            }
            // Close the StreamReader
            fileContent.Close();
        }

        public User Login(String username, String password)
        {
            foreach (User tempUser in users)
            {
                if (tempUser.getUsername().Equals(username) && tempUser.getPassword().Equals(password))
                {
                    loggedIn = tempUser;
                    return tempUser;
                }
            }
            return null;
        }

        public bool UsernameExists(String username)
        {
            foreach (User tempUser in users)
            {
                return (tempUser.getUsername().Equals(username));
            }
            return false;
        }

        public void NewUser(String username, String password, String userType, String fName, String lName, String dob)
        {
            User user = new User(username, password, userType, fName, lName, dob);
            File.AppendAllText(@"login.txt", Environment.NewLine + username + "," + password + "," + userType + "," + fName + "," + lName + "," + dob);
            users.Add(user);
            loggedIn = user;
        }

        public User GetLoggedIn()
        {
            return this.loggedIn;
        }

        public String getAccountType()
        {
            return this.loggedIn.getAccountType();
        }
    }
}
