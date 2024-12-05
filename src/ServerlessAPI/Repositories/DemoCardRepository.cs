using ServerlessAPI.Entities;

namespace ServerlessAPI.Repositories;

public class DemoCardRepository : ICardRepository
{
    private readonly ILogger<DemoCardRepository> logger;
    private readonly SetRepository setRepository;

    public DemoCardRepository(ILogger<DemoCardRepository> logger, SetRepository setRepository)
    {
        this.logger = logger;
        this.setRepository = setRepository;
    }

    public Card? GetCardAsync(CardSearchQuery query)
    {
        try
        {
            Set? foundSet = null;

            if (query.TotalCards != null)
            {
                List<Set> possibleSets = setRepository.setList.FindAll(s => s.TotalCards == query.TotalCards);
                if (possibleSets.Count == 1)
                {
                    foundSet = possibleSets[0];
                }
                else if (possibleSets.Count > 1)
                {
                    //search by setCode contains
                    if (!string.IsNullOrEmpty(query.SetCode))
                    {
                        foundSet = possibleSets.First(s => s.SetCode.Contains(query.SetCode));
                    }
                    else {
                        // TODO 
                        logger.LogWarning("Randomly choosing a set...");
                        foundSet = possibleSets[1];
                    }
                }
            }
            else if (!string.IsNullOrEmpty(query.SetCode))
            {
                foundSet = setRepository.setList.FirstOrDefault(s => s.SetCode == query.SetCode);
            }

            var foundCard = foundSet?.Cards.FirstOrDefault(c => c.CardNumber == query.CardNumber);
            return foundCard;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Cannot get card");
            return null;
        }
    }
}