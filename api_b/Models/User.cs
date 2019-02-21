using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api_b.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("username")]
        public string username { get; set; }

        [BsonElement("isbnLivrePrefere")]
        public string isbn { get; set; }

        [BsonElement("nomEmissionPreferee")]
        public string show { get; set; }

    }
}
