using Cinema.Data.Base;
using Cinema.Models;

namespace Cinema.Data.Services;

public interface IMoviesService:IEntityBaseRepository<Movie>
{
    Task<Movie> GetMovieByIdAsync(int id);
}