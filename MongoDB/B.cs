using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDBApp
{
    class B
    {
        public void MongoMethod()
        {
            var client = new MongoClient("mongodb+srv://kannareddyid:<password>@clusterid-edigr.azure.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("Jabardasth");
           
        }

    }
}
