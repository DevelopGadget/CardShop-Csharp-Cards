using Microsoft.Extensions.Configuration;

namespace eCommerce_Csharp_Cards.Models {
    public class Settings {
        public string ConectionString { get; set; }
        public string Database { get; set; }
        public IConfiguration configuration { get; set; }
    }
}