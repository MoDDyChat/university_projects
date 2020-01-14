using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Lab32_Server
{
    public class Account
    {
        private string _userName;
        private string _passWord;

        public string UserName
        {
            get { return _userName; }
        }

        public string Password
        {
            get { return _passWord; }
        }

        public Account(string name, string pass)
        {
            _userName = name;
            _passWord = pass;
        }
    }
}
