using System;
using System.IO;


namespace ConvertCharact
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No targets specified.");
                return;
            }
            foreach (string arg in args)
            {
                DirectoryInfo d = new DirectoryInfo(arg);
                FileInfo[] infos = d.GetFiles();
                string[] files = Directory.GetFiles(arg);
                foreach (string file in files)
                {
                    if (file[file.Length-1] == 't') File.Delete(file);
                }
                foreach (FileInfo f in infos)
                {
                    File.Move(f.FullName, f.FullName.Replace("_перевод", ""));
                    File.Move(f.FullName, f.FullName.Replace("_perevod", ""));
                    File.Move(f.FullName, f.FullName.Replace("+", ""));
                    File.Move(f.FullName, f.FullName.Replace("с", "c"));
                    File.Move(f.FullName, f.FullName.Replace("s0", "c0"));
                    File.Move(f.FullName, f.FullName.Replace("_US", ""));
                    File.Move(f.FullName, f.FullName.Replace(".ttf", ""));
                    File.Move(f.FullName, f.FullName.Replace(".srd", ".stx"));
                    File.Move(f.FullName, f.FullName.Replace("RU.png", "US"));
                }
            }
        }
    }
}
