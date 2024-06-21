
using Microsoft.EntityFrameworkCore;

namespace PublicerenWeb.Entities;

public sealed class SQLActiecodeRepository : IActiecodeRepository
{
    private readonly PrulariaComContext context;

    public SQLActiecodeRepository(PrulariaComContext context)
    {
        this.context = context;
    }

    public async Task<List<Actiecode>> GetAll()
    {
        return await context.Actiecodes.ToListAsync();
    }
}
