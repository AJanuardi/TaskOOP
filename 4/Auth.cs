using System;

namespace Auth
{
    public class Auth
    {
        //Varibel untuk menyimpan user yang log in
        public string logged_in = "";
        //Varibel untuk menyimpan password yang log in
        public string logpass_out = ""; 

        //Varibel untuk menyimpan id_user yang log in
        public string id_user_in = "";

        public string username = "root";
        public string password = "secret";

        public void login(string _user,string _password)
        {
            string username = "root";
            string password = "secret";
            

            if(username == _user && password == _password)
            {
                logged_in = _user;
                logpass_out = _password;
                id_user_in = "USR0001";
                Console.WriteLine("Successfull to Log In");
            }
            else if(username == _user && password != _password)
            {
                Console.WriteLine("Password Salah");
            }
            else if(username != _user && password == _password)
            {
                Console.WriteLine("Username Salah");
            }
            else
            {
                Console.WriteLine("Username dan Password Salah");
            }
        }

        public void validate(string _user,string _password)
        {

            if(username == _user && password == _password)
            {   
                Console.WriteLine("Akun anda tersedia dan ada");
            }
            else if(username == _user && password != _password)
            {
                Console.WriteLine("Password Salah");
            }
            else if(username != _user && password == _password)
            {
                Console.WriteLine("Username Salah");
            }
            else
            {
                Console.WriteLine("Username dan Password Salah");
            }
        }

        public void logout()
        {
            logged_in.Remove(0);
            logpass_out.Remove(0);
            Console.WriteLine("Berhasil Logout");
        }

        public void user()
        {
            Console.WriteLine("user :" + logged_in);
            Console.WriteLine("password :" + logpass_out);
        }

        public void id()
        {
            Console.WriteLine("id_user :" + id_user_in);
        }

        public bool check()
        {   
            if(logged_in == username)
            {
                Console.WriteLine("true");
                return true;
            }
            else 
            {
                Console.WriteLine("false");
                return false;
            }
        }

        public bool guest()
        {
            if(logged_in =="")
            {
                Console.WriteLine("true");
                return true;
            }
            else 
            {
                Console.WriteLine("false");
                return false;
            }
        }

        public void lastLogin()
        {
            Console.WriteLine("last login :" + logged_in);
        }
    }
}