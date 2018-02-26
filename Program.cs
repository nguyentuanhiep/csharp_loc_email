using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
                string line;
                StreamReader reader = new StreamReader(args[0]); 
                StreamWriter write = new StreamWriter("./email.txt"); 
                string pattern = @".+[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)"; //regex ra trường Email 
    
                while ((line= reader.ReadLine()) != null)
                {
                    Match email = Regex.Match(line, pattern);
                    if (email.Success) {
                        //string[] result = line.Split(email.Value);
                        write.WriteLine(email);
                    }
                }
                
                
             reader.Close ();
             write.Close();
            
        }
    }
}
