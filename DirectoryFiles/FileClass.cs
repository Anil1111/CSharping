using System;
using System.Collections.Generic;
using System.IO;  //For file and folders management
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFiles
{
    //***File*** is the keyword
    class FileClass
    {
        public void FilesMethod()
        {
            string filePath = @"C:\Users\kanna\source\repos\CSharping\DirectoryFiles\ProjectOperations\";

            //Opens DummyFile.txt and write texts. If file is not exists then create and open.
            File.WriteAllText(filePath+"DummyFile.txt", "This is dummy text");

            //Check whether file is exists or not at particular location
            bool isFileExists = File.Exists(filePath+"DummyFile.txt"); // returns false
            Console.WriteLine("Is File Exists: "+isFileExists);

            //Copy DummyFile.txt as new file DummyFileNew.txt
            //File.Copy(filePath+"DummyFile.txt", filePath+"NewDummyFile.txt");

            //Get when the file was accessed last time 
            DateTime lastAccessTime = File.GetLastAccessTime(filePath+"DummyFile.txt");
            Console.WriteLine("The file was accessed last time : " + lastAccessTime);

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime(filePath+"DummyFile.txt");
            Console.WriteLine("The file was written last time : " + lastWriteTime);

            //// Move file to new location
            //File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

            ////Open file and returns FileStream for reading bytes from the file
            //FileStream fs = File.Open(@"D:\DummyFile.txt", FileMode.OpenOrCreate);

            ////Open file and return StreamReader for reading string from the file
            //StreamReader sr = File.OpenText(@"D:\DummyFile.txt");

            ////Delete file
            //File.Delete(@"C:\DummyFile.txt");

            Console.ReadLine();
        }
    }
}
