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
                string line="";
                StreamReader reader = new StreamReader(args[0]); 
                StreamWriter write = new StreamWriter("./email.txt"); 
                Regex pattern = new Regex(@".+[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)"); //regex ra trường Email 
                List<string> input = new List<string>();
                while (line != null)
                {
                    input.Add(line);
                    line = reader.ReadLine();
                }
                foreach (var output in input)
                {
                    Match result = pattern.Match(output);
                    if (result.Success)
                    {
                        write.WriteLine(result);
                    }
                }
                
             reader.Close ();
             write.Close();
            
        }
    }
}
