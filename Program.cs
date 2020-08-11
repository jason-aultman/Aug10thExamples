using System;
using System.IO;

namespace Aug8thExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "jasonsFile";
            FileUtility.CreateFile(name);
            FileUtility.WriteToFile(name);
            FileUtility.ReadFromfile(name);
        }

       
    }
}