using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce_Csharp_Cards.Models;
using MongoDB.Driver;

namespace eCommerce_Csharp_Cards.Interfaces
{
    public interface ICards
    {
    Task<IEnumerable<Cards>> Get();
    Task<Cards> Get(string _id);
    Task Add(Cards user);
    Task<ReplaceOneResult> Update(string _id, Cards Card);
    Task<DeleteResult> Remove(string _id);
    }
}