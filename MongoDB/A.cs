﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDBApp
{

        public class PersonalModel
        {
            [BsonId]
            public Guid ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class MongoCRUD
        {
            private IMongoDatabase db;
            public MongoCRUD(string database)
            {

                var client = new MongoClient();
                db = client.GetDatabase(database);
            }

            public void InsertRecord<T>(string table, T record)
            {
                var collection = db.GetCollection<T>(table);
                collection.InsertOne(record);
            }

        }
}
