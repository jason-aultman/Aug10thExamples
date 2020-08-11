using System;
using System.IO;

namespace Aug8thExamples
{
    public static class FileUtility
    {
        public static void CreateFile(string name)
        {
            if (!File.Exists(name))
            {
                File.Create(name);
            }
        }

        public static void WriteToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("This is a new string");
            }
        }

        public static void ReadFromfile(string filename)
        {
            using (StreamReader streamReader = new StreamReader(filename))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}