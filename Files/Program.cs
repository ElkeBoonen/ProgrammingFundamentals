using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(folder, "file.txt");
            StreamWriter output = File.CreateText(path);
            output.WriteLine("This is a test file");
            output.Close();

            if (File.Exists(path))
            {
                output = File.AppendText(path);
                output.WriteLine("This is another line in the test file");
                output.Close();
            }
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            Console.Write(text);
            input.Close();

            input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();
            while (line != null)
            {
                Console.WriteLine("LINE : " + line);
                line = input.ReadLine();
            }
            input.Close();

            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                char c = (char)input.Read();
                Console.Write(c + " ");
            }
            input.Close();

            input = File.OpenText("Rapunzel.txt");
            text = input.ReadToEnd();
            foreach (char c in text)
            {
                Console.Write(c + " ");
            }
            input.Close();

            Regex rx = new Regex(@"Rapunzel",RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine("\n\n" + matches.Count + " matches found!");
        }
    }
}
