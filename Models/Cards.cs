using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eCommerce_Csharp_Cards.Models {
    public class Cards : IValidatableObject {

        [BsonId]
        [BsonRepresentation (BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string UrlIcon { get; set; }

        [Required]
        public string UrlCard { get; set; }

        [Required]
        public double Valor { get; set; }

        [Required]
        public int Disponible { get; set; }
        
        public Cards (string id, string nombre, string urlIcon, string urlCard, double valor, int disponible) {
            this.Id = id;
            this.Nombre = nombre;
            this.UrlIcon = urlIcon;
            this.UrlCard = urlCard;
            this.Valor = valor;
            this.Disponible = disponible;

        }
        public IEnumerable<ValidationResult> Validate (ValidationContext validationContext) {
            var Err = new List<ValidationResult> ();
            if (Disponible < 0) Err.Add (new ValidationResult ("La disponibilidad tiene que ser mayor o igual a 0", new string[] { "1" }));
            if (Valor <= 0) Err.Add (new ValidationResult ("El valor tiene que ser mayor a 0", new string[] { "2" }));
            return Err;
        }
    }
}