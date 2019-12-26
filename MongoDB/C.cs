using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDBApp
{

    public class PersonalModel1
    {
        [BsonId]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MongoCRUD1
    {
        private IMongoDatabase db;
        public MongoCRUD1(string database)
        {

            var client = new MongoClient("mongodb+srv://kannareddyid:<password>@clusterid-edigr.azure.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

    }
}
