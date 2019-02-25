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

        [BsonElement("titreLivrePrefere")]
        public string titreLivrePrefere { get; set; }

        [BsonElement("auteurLivrePrefere")]
        public string auteurLivrePrefere { get; set; }

        [BsonElement("urlCouvertureLivrePrefere")]
        public string urlCouvertureLivrePrefere { get; set; }

        [BsonElement("nomEmissionPreferee")]
        public string show { get; set; }

        [BsonElement("genreSeriePreferee")]
        public string genreSeriePreferee { get; set; }

        [BsonElement("jourSeriePreferee")]
        public string jourSeriePreferee { get; set; }

        [BsonElement("heureSeriePreferee")]
        public string heureSeriePreferee { get; set; }

    }
}
