using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBHelper;
using System;

namespace MyMongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库
            //var client = new MongoClient("mongodb://localhost/");
            ////获取database
            //var mydb = client.GetDatabase("myDb");
            ////获取collection
            //var collection = mydb.GetCollection<BsonDocument>("userinfos");

            var mongoDBHelp = new MongoDBHelp();

            //待添加的document
            var doc = new BsonDocument{
                { "_id",7 },
                { "name", "longfc" },
                { "age", 37 },
                { "ename", new BsonDocument
                    {
                        { "firstname", "jiu" },
                        { "lastname", "wu" }
                    }
                }
            };
            //InsertOne()添加单条docment
            //collection.InsertOne(doc);

            mongoDBHelp.InsertAsync<BsonDocument>("userinfos",doc);

            var list=mongoDBHelp.Find<BsonDocument>("userinfos");

            Console.Read();
        }
    }
}
