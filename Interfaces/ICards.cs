using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce_Csharp_Cards.Models;
using MongoDB.Driver;

namespace eCommerce_Csharp_Cards.Interfaces {
    public interface ICards {
        Task<IEnumerable<Cards>> GetAmazon ();
        Task<IEnumerable<Cards>> GetGooglePlay ();
        Task<IEnumerable<Cards>> GetiTunes ();
        Task<IEnumerable<Cards>> GetSteam ();
        Task<IEnumerable<Cards>> GetPlayStation ();
        Task<IEnumerable<Cards>> GetXbox ();
        Task<IEnumerable<Cards>> GetPaypal ();
        Task<Cards> GetAmazon (string _id);
        Task<Cards> GetGooglePlay (string _id);
        Task<Cards> GetiTunes (string _id);
        Task<Cards> GetSteam (string _id);
        Task<Cards> GetPlayStation (string _id);
        Task<Cards> GetXbox (string _id);
        Task<Cards> GetPaypal (string _id);
        Task PostAmazon (Cards Card);
        Task PostGooglePlay (Cards Card);
        Task PostiTunes (Cards Card);
        Task PostSteam (Cards Card);
        Task PostPlayStation (Cards Card);
        Task PostXbox (Cards Card);
        Task PostPaypal (Cards Card);
        Task<ReplaceOneResult> PutAmazon (string _id, Cards Card);
        Task<ReplaceOneResult> PutGooglePlay (string _id, Cards Card);
        Task<ReplaceOneResult> PutiTunes (string _id, Cards Card);
        Task<ReplaceOneResult> PutSteam (string _id, Cards Card);
        Task<ReplaceOneResult> PutPlayStation (string _id, Cards Card);
        Task<ReplaceOneResult> PutXbox (string _id, Cards Card);
        Task<ReplaceOneResult> PutPaypal (string _id, Cards Card);
        Task<DeleteResult> DeleteAmazon (string _id);
        Task<DeleteResult> DeleteGooglePlay (string _id);
        Task<DeleteResult> DeleteiTunes (string _id);
        Task<DeleteResult> DeleteSteam (string _id);
        Task<DeleteResult> DeletePlayStation (string _id);
        Task<DeleteResult> DeleteXbox (string _id);
        Task<DeleteResult> DeletePaypal (string _id);
    }
}