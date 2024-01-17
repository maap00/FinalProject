using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class User
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _userName;
        private string _password;
        private string _email;

        public User() {
            this._id = 0;
            this._name = string.Empty;
            this._lastName = string.Empty;
            this._userName = string.Empty;
            this._password = string.Empty;
            this._email = string.Empty;        
        }

        public User(int id, string name, string lastName, string userName, string password, string email)
        {
            this._id = id;
            this._name = name;
            this._lastName = lastName;
            this._userName = userName;
            this._password = password;
            this._email = email;

        }

        public void showDates()
        {
            Console.WriteLine(this._id.ToString());
            Console.WriteLine(this._name.ToString());
            Console.WriteLine(this._lastName.ToString());
            Console.WriteLine(this._userName.ToString());
            Console.WriteLine(this._password.ToString());
            Console.WriteLine(this._email.ToString());

        }

        public int id
        {
            get
            {
                return this._id;

            }
            set
            {
                this._id = value;
            }
        }


        public string name {
            get
            {               
               return this._name;
            }
            set
            {
               this._name = value;
            }
        }
        public string lastName
        {
            get
            {
               return this._lastName;
            }
            set
            {
               this._lastName = value;
            }
        }

        public string userName
        {
            get
            {
              return this._userName;
               
            }
            set
            {
                this._userName = value;
            }
        }

        public string password
        {
            get
            {
                return this._password;

            }
            set
            {
                this._password = value;
            }
        }
        public string email
        {
            get
            {
                return this._email;

            }
            set
            {
                this._email = value;
            }
        }
    }
}
