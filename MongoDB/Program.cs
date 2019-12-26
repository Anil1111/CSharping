using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();

            //clusterid-edigr.azure.mongodb.net
            MongoCRUD1 mongoCRUD1 = new MongoCRUD1("BigBoss");
            mongoCRUD1.InsertRecord<PersonalModel1>("Season1", new PersonalModel1 { FirstName = "Kanna", LastName = "Reddy" });

            //localhost:27017
            MongoCRUD mongoCRUD = new MongoCRUD("BigBosss");
            mongoCRUD.InsertRecord<PersonalModel>("Season1", new PersonalModel { FirstName = "Kanna", LastName = "Reddy" });

            Console.ReadLine();
        }
    }

   
}
