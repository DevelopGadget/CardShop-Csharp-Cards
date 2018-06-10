using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace eCommerce_Csharp_Cards.Models
{
    public class ObjectContext
    {
        public IConfiguration Configuration { get; set; }
        private IMongoDatabase _database = null;
        public ObjectContext(IOptions<Settings> Setting)
        {
            Configuration = Setting.Value.configuration;
            Setting.Value.ConectionString = Configuration["ConectionMlab"].ToString();
            Setting.Value.Database = Configuration["Database"].ToString();
            var Client = new MongoClient(Setting.Value.ConectionString);
            if (Client != null) { _database = Client.GetDatabase(Setting.Value.Database);}
        }

        public IMongoCollection<Cards> Amazon
        {
            get { return _database.GetCollection<Cards>("Amazon"); }
        }

        public IMongoCollection<Cards> GooglePlay
        {
            get { return _database.GetCollection<Cards>("GooglePlay"); }
        }
        public IMongoCollection<Cards> iTunes
        {
            get { return _database.GetCollection<Cards>("iTunes"); }
        }
        public IMongoCollection<Cards> Steam
        {
            get { return _database.GetCollection<Cards>("Steam"); }
        }
        public IMongoCollection<Cards> PlayStation
        {
            get { return _database.GetCollection<Cards>("PlayStation"); }
        }
        public IMongoCollection<Cards> Xbox
        {
            get { return _database.GetCollection<Cards>("Xbox"); }
        }
        public IMongoCollection<Cards> Paypal
        {
            get { return _database.GetCollection<Cards>("Paypal"); }
        }
    }
}