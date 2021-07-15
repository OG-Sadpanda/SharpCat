using System;
using System.IO;

namespace SharpCat
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"
 _____ _                      _____       _   
/  ___| |                    /  __ \     | |  
\ `--.| |__   __ _ _ __ _ __ | /  \/ __ _| |_ 
 `--. \ '_ \ / _` | '__| '_ \| |    / _` | __|
/\__/ / | | | (_| | |  | |_) | \__/\ (_| | |_ 
\____/|_| |_|\__,_|_|  | .__/ \____/\__,_|\__|
                       | |                    
                       |_|                    
" +
"" +
"Developed By: @sadpanda_sec\n\n" +
"Description: C# alternative to the linux \"cat\" command... Prints file contents to console.\n\n" +
"Usage: SharpCat.exe C:\\Some\\Path\\To\\File");
                System.Environment.Exit(0);

            }
            else if (args.Length == 1)
            {
                if (File.Exists(args[0]))
                {
                    string path = Path.GetFullPath(args[0]);
                    string text = File.ReadAllText(path);
                    DateTime date = DateTime.Now;
                    Console.WriteLine("\n" + date + ": " + "Reading File: " + path + "\n\n");
                    Console.WriteLine(text);
                    System.Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("File Does Not Exist");
                    System.Environment.Exit(0);

                }
            }
            else
            {
                if (args.Length > 1)
                {
                    Console.WriteLine("Error...Provided more than one command line argument\n\n" +
                        "Usage: SharpCat.exe C:\\Some\\Path\\To\\File");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
            
