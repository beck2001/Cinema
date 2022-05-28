using Cinema.Data.Base;
using Cinema.Models;

namespace Cinema.Data.Services;

public class CinemasService:EntityBaseRepository<CinemaPlace>, ICinemasService
{
    public CinemasService(AppDbContext context) : base(context)
    {
        
    }
}