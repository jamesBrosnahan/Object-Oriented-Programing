using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Renci.SshNet;

namespace HomeworkAssignment1
{
    class Employee
    {
        private int _EmployeeID;
        private String _LoginName;
        private String _Password;
        private String _Department;
        private String _Name;
        private SshClient Client;
        //private Regex _ValidPasswordFormatRegex = new Regex("^ (?=.*[a - z])(?=.*[A - Z])(?=.*\d).{8, 15}$");

        private Boolean validatePassword(String PasswordEntered) {
            //todo implement password validation rules
            return true;
        }

        public String Name
        {
            get { return _Name; }
            set { _Name = Name; }
        }

        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { throw new Exception(" Employee ID is immutable"); }
        }

        public String Password
        {
            get { return _Password; }
            set
            {
                if (validatePassword(value)) {
                    _Password = value;
                }
                else
                {
                    throw new Exception("No rules set for password validation, this is impossible.");
                }
            }
        }

        public Employee(int ID, String login, String password, String department, String name) {
            _EmployeeID = ID;
            _LoginName = login;
            _Password = password;
            _Department = department;
            _Name = name;
        }

        public Boolean LoginToServer(String address)
        {
            // assume ssh
            if(Client != null)
            {
                Client.Disconnect();
            }
            Client = new SshClient(address, _LoginName, _Password);
            return true;
        }
        public SshCommand RunCommand(String Command)
        {
            return Client.RunCommand(Command);
        }
        public Boolean LogoffServer()
        {
            Client.Disconnect();
            return true;
        }
    }
}
