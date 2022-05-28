using Cinema.Data.Base;
using Cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
