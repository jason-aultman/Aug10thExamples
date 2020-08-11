using System;
using System.Collections.Generic;
using System.IO;

namespace Aug8thExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "jasonsFile";
            FileUtility.CreateFile(name);
            FileUtility.ModifyFile(name, false);
            FileUtility.ReadFromfile(name);
            var linesOfInput = new List<string> {"Jason", "This is the next line", "I am cool"};
            FileUtility.ModifyFile(name, true, linesOfInput);
            FileUtility.Delete(name);
        }

       
    }
}