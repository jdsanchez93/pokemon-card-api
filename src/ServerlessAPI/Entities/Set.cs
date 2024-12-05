namespace ServerlessAPI.Entities;

public class Set
{

    public string? SetId { get; set; }

    public string SetCode { get; set; } = "";

    public string? SetPath { get; set; }

    public int TotalCards { get; set; }

    public List<Card> Cards { get; set; } = [];
}
