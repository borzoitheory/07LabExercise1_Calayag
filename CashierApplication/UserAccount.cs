using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string pass_word;
        protected string user_name;

        public UserAccount(string name, string username, string password)
        {
            this.full_name = name;
            this.user_name = username;
            this.pass_word = password;
        }

        public abstract bool checkLogin(string username, string password);

        public string getFullName()
        {
            return this.full_name;
        }

    }
        public class Cashier : UserAccount
        {
            public string department;

            public Cashier(string name, string department, string username, string password)
                : base(name, username, password)
            {
                this.department = department;
            }

            public override bool checkLogin(string username, string password)
            {
                return (this.user_name == username && this.pass_word == password);
            }

            public string getDepartment()
            {
                return this.department;
            }
        }
}
