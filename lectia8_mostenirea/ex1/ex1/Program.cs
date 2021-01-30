using System;
using static System.Console;

namespace ex1
{
    class User
    {
        protected string id, password;

        public void DateUser()
        {
            WriteLine("ID-ul: " + id + " are parola:" + password);
        }
    }

    class UserInregistrat : User
    {
        public string username;
        public UserInregistrat(string _id, string _password, string _username)
        {
            id = _id;
            password = _password;
            username = _username;
        }

        public void Logare()
        {
            WriteLine("Utilizatorul " + username + " logat cu succes");
            DateUser();
        }
    }



    class Executie
    {
        static void Main(string[] args)
        {
            UserInregistrat U = new UserInregistrat("2153214", "pass123", "adfgadfg");

            U.Logare();
        }
    }
}
