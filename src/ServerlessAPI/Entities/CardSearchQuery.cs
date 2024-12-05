namespace ServerlessAPI.Entities;

public class CardSearchQuery
{
    public string? CardNumber { get; set; }
    public string? SetCode { get; set; }

    public int? TotalCards { get; set; }

}