using Amazon.DynamoDBv2.DataModel;
using Microsoft.AspNetCore.Mvc;
using ServerlessAPI.Entities;
using ServerlessAPI.Repositories;

namespace ServerlessAPI.Controllers;

[Route("api/[controller]")]
[Produces("application/json")]
public class CardsController : ControllerBase
{
    private readonly ILogger<CardsController> logger;
    private readonly ICardRepository cardRepository;

    public CardsController(ILogger<CardsController> logger, ICardRepository cardRepository)
    {
        this.logger = logger;
        this.cardRepository = cardRepository;
    }

    // GET api/cards
    [HttpGet]
    public ActionResult<Card> Get([FromQuery] string cardNumber, [FromQuery] string? setCode, [FromQuery] int? totalCards)
    {
        try
        {
            if (string.IsNullOrEmpty(cardNumber) || (string.IsNullOrEmpty(setCode) && totalCards == null))
            {
                return BadRequest("Please supply cardNumber and one or more of: (setCode, totalCards)");
            }

            var query = new CardSearchQuery
            {
                CardNumber = cardNumber,
                SetCode = setCode,
                TotalCards = totalCards
            };
            Card? c = cardRepository.GetCardAsync(query);
            if (c == null)
            {
                return NotFound("Card not found. Try refining search criteria");
            }
            c.Url = string.Format("https://tcgcollector.com/cards/{0}", c.CardId);
            return Ok(c);
        }
        catch (System.Exception e)
        {
            logger.LogError(e, "Error generating presigned url");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

}
