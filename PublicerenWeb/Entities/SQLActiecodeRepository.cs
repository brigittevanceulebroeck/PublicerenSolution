
using Microsoft.EntityFrameworkCore;

namespace PublicerenWeb.Entities;

public sealed class SQLActiecodeRepository(PrulariaComContext context) : IActiecodeRepository
{
    private readonly PrulariaComContext context = context;

    public async Task<List<Actiecode>> GetAll()
    {
        return await context.Actiecodes.ToListAsync();
    }
}
