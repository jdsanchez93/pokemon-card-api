using ServerlessAPI.Entities;

namespace ServerlessAPI.Repositories;

public class SetRepository
{
    private readonly ILogger<SetRepository> logger;
    public List<Set> setList;


    public SetRepository(ILogger<SetRepository> logger)
    {
        this.logger = logger;
        this.setList = SetList.GetSetList();
    }
}