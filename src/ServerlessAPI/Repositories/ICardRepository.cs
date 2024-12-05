using ServerlessAPI.Entities;

namespace ServerlessAPI.Repositories;

public interface ICardRepository
{
    Card? GetCardAsync(CardSearchQuery query);
}


