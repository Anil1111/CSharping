using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFiles
{
    class Program
    {  //https://www.tutorialsteacher.com/csharp/csharp-stream-io
        static void Main(string[] args)
        {
           

            FileInfoClass fileInfoClass = new FileInfoClass();
            fileInfoClass.FileInfoClassMethod();

            //FileClass files = new FileClass();
            //files.FilesMethod();

            Console.ReadLine();
        }
    }
}
