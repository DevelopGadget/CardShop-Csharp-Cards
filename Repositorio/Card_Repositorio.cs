using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce_Csharp_Cards.Interfaces;
using eCommerce_Csharp_Cards.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace eCommerce_Csharp_Cards {
  public class Card_Repositorio : ICards {
    private readonly ObjectContext context = null;
    public Card_Repositorio (IOptions<Settings> settings) => context = new ObjectContext (settings);
    public async Task<DeleteResult> DeleteAmazon (string _id) => await context.Amazon.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<DeleteResult> DeleteGooglePlay (string _id) => await context.GooglePlay.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<DeleteResult> DeleteiTunes (string _id) => await context.iTunes.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<DeleteResult> DeletePaypal (string _id) => await context.Paypal.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<DeleteResult> DeletePlayStation (string _id) => await context.PlayStation.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<DeleteResult> DeleteSteam (string _id) => await context.Steam.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<DeleteResult> DeleteXbox (string _id) => await context.Xbox.DeleteOneAsync (Builders<Cards>.Filter.Eq ("Id", _id));
    public async Task<IEnumerable<Cards>> GetAmazon () => await context.Amazon.Find (x => true).ToListAsync ();
    public async Task<Cards> GetAmazon (string _id) => await context.Amazon.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task<IEnumerable<Cards>> GetGooglePlay () => await context.GooglePlay.Find (x => true).ToListAsync ();
    public async Task<Cards> GetGooglePlay (string _id) => await context.GooglePlay.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task<IEnumerable<Cards>> GetiTunes () => await context.iTunes.Find (x => true).ToListAsync ();
    public async Task<Cards> GetiTunes (string _id) => await context.iTunes.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task<IEnumerable<Cards>> GetPaypal () => await context.Paypal.Find (x => true).ToListAsync ();
    public async Task<Cards> GetPaypal (string _id) => await context.Paypal.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task<IEnumerable<Cards>> GetPlayStation () => await context.PlayStation.Find (x => true).ToListAsync ();
    public async Task<Cards> GetPlayStation (string _id) => await context.PlayStation.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task<IEnumerable<Cards>> GetSteam () => await context.Steam.Find (x => true).ToListAsync ();
    public async Task<Cards> GetSteam (string _id) => await context.Steam.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task<IEnumerable<Cards>> GetXbox () => await context.Xbox.Find (x => true).ToListAsync ();
    public async Task<Cards> GetXbox (string _id) => await context.Xbox.Find (Builders<Cards>.Filter.Eq ("Id", _id)).FirstOrDefaultAsync ();
    public async Task PostAmazon (Cards Card) => await context.Amazon.InsertOneAsync (Card);
    public async Task PostGooglePlay (Cards Card) => await context.GooglePlay.InsertOneAsync (Card);
    public async Task PostiTunes (Cards Card) => await context.iTunes.InsertOneAsync (Card);
    public async Task PostPaypal (Cards Card) => await context.Paypal.InsertOneAsync (Card);
    public async Task PostPlayStation (Cards Card) => await context.PlayStation.InsertOneAsync (Card);
    public async Task PostSteam (Cards Card) => await context.Steam.InsertOneAsync (Card);
    public async Task PostXbox (Cards Card) => await context.Xbox.InsertOneAsync (Card);
    public async Task<ReplaceOneResult> PutAmazon (string _id, Cards Card) => await context.Amazon.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
    public async Task<ReplaceOneResult> PutGooglePlay (string _id, Cards Card) => await context.GooglePlay.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
    public async Task<ReplaceOneResult> PutiTunes (string _id, Cards Card) => await context.iTunes.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
    public async Task<ReplaceOneResult> PutPaypal (string _id, Cards Card) => await context.Paypal.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
    public async Task<ReplaceOneResult> PutPlayStation (string _id, Cards Card) => await context.PlayStation.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
    public async Task<ReplaceOneResult> PutSteam (string _id, Cards Card) => await context.Steam.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
    public async Task<ReplaceOneResult> PutXbox (string _id, Cards Card) => await context.Xbox.ReplaceOneAsync (o => o.Id.Equals (_id), Card);
  }
}