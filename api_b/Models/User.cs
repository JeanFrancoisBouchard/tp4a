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
        public string isbnLivrePrefere { get; set; }

        [BsonElement("titreLivrePrefere")]
        public string titreLivrePrefere { get; set; }

        [BsonElement("auteurLivrePrefere")]
        public string auteurLivrePrefere { get; set; }

        [BsonElement("urlCouvertureLivrePrefere")]
        public string urlCouvertureLivrePrefere { get; set; }

        [BsonElement("datePublicationLivrePrefere")]
        public string datePublicationLivrePrefere { get; set; }

        [BsonElement("nomEmissionPreferee")]
        public string nomEmissionPreferee { get; set; }

        [BsonElement("genreEmissionPreferee")]
        public string genreEmissionPreferee { get; set; }

        [BsonElement("jourEmissionPreferee")]
        public string jourEmissionPreferee { get; set; }

        [BsonElement("heureEmissionPreferee")]
        public string heureEmissionPreferee { get; set; }

    }
}
