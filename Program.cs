using System;
using System.IO;
class fileconsverter 
{

    public static void Main(string[] argv) 
    {
        string s = "";
        string ss = "";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine(argv);
        if (argv.Length > 0)
        {

            s=File.ReadAllText(argv[0]);
            s = s.Replace("\\", "\\\\");
            s = s.Replace("\"","\\\"");
            s = s.Replace("\n", "\\n");
            s = s.Replace("\r", "\\r");
            File.WriteAllText(argv[0]+".txt", s);
        } 
        
        
    
    
    } 




}
