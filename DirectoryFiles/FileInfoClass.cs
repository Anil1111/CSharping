using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFiles
{
    class FileInfoClass
    {
        public void FileInfoClassMethod() {

            string filePath = @"C:\Users\kanna\source\repos\CSharping\DirectoryFiles\ProjectOperations\";
            FileInfo fi = new FileInfo(filePath+"DummyFileInfo.txt");

            //Open file for Read\Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //create byte array of same size as FileStream length
            byte[] fileBytes = new byte[fs.Length];

            //define counter to check how much bytes to read. Decrease the counter as you read each byte
            int numBytesToRead = (int)fileBytes.Length;

            //Counter to indicate number of bytes already read
            int numBytesRead = 0;

            //iterate till all the bytes read from FileStream
            while (numBytesToRead > 0)
            {
                int n = fs.Read(fileBytes, numBytesRead, numBytesToRead);

                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }

            //Once you read all the bytes from FileStream, you can convert it into string using UTF8 encoding
            string filestring = Encoding.UTF8.GetString(fileBytes);
        }
    }
}
