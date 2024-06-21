namespace PublicerenWeb.Entities;

public interface IActiecodeRepository
{
    public Task<List<Actiecode>> GetAll();
}
