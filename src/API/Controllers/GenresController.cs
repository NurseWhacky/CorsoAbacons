using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace API.Controllers
{
    public class GenresController : AbstractController<Genre>
    {
        private readonly IRepository<Genre> repo;

        public GenresController(IRepository<Genre> repo) : base(repo)
        {
            this.repo = repo;
        }

    }
}
