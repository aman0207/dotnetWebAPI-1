using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace test1_webapi {
    public class UserModel {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id {get; set;}
        public string Name { get; set;}
        public long Age { get; set;}
    }
}