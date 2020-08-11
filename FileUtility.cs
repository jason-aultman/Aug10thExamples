using System;
using System.Collections.Generic;
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

        public static void ModifyFile(string filename, bool canAppend,  List<string>input=null)
        {
            using (StreamWriter writer = new StreamWriter(filename , canAppend))
            {
                if (input == null)
                {
                    writer.WriteLine("This is a new string");
                }
                else
                {
                    foreach (var v in input)
                    {
                        writer.WriteLine(v);
                    }
                }
               
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

        public static void Delete(string fileName)
        {
            File.Delete(fileName);
        }
            
    }
}