using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eCommerce_Csharp_Cards.Models
{
    public class Cards
    {
        [BsonId]
        [BsonRepresentation (BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        public string Nombre {get; set;}
        [Required]
        public string Url {get; set;}
        [Required]
        public double Valor {get; set;}
        [Required]
        public int Disponible {get; set;}
    }
}