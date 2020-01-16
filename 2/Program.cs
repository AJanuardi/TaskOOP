using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
  
namespace Cipher 
{  
    public class Program 
    {  
  
        public static char cipher(char ch) 
        {  
            if (!char.IsLetter(ch)) 
            {  
  
                return ch;  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + 3) - d) % 26) + d);  
        }  
        public static char cipher1(char ch) 
        {  
            if (!char.IsLetter(ch)) 
            {  
  
                return ch;  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch - 3) - d) % 26) + d);  
        }
        public static string Encipher(string input, string pass) 
        {  
            if (pass == "'p4$$w0rd'")
            {
                string output = string.Empty;  
                foreach(char ch in input)  
                output += cipher(ch);  
                return output;
            }
            else 
            {
                return "sorry";
            }
            
        }
        public static string Encipher1(string input, string pass) 
        {  
            if (pass == "'p4$$w0rd'")
            {
                string output = string.Empty;  
                foreach(char ch in input)  
                output += cipher1(ch);  
                return output;
            }  
            else
            {
                return "sorry";
            }
        }
        public static string Decipher(string input, string pass) 
        {  

            return Encipher1(input, pass);  
        }  
        static void Main(string[] args) 
        {  
            var message1 = Program.Encipher("password", "'p4$$w0rd'");
            Console.WriteLine(message1);
            var message2 = Program.Decipher("sdvvzrug", "'p4$$w0rd'");
            Console.WriteLine(message2);
        }  
    }  
}  