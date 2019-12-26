using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace FirebaseApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

            FirestoreDb db = FirestoreDb.Create("dsdss");
            Console.WriteLine("Created Cloud Firestore client with project ID");

            Console.ReadLine();
        }
    }
}
