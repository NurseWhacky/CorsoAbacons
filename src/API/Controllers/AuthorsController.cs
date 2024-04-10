using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace API.Controllers
{
    public class AuthorsController : AbstractController<Author>
    {
        private readonly IRepository<Author> repo;
        public AuthorsController(IRepository<Author> repo) : base(repo)
        {
            this.repo = repo;
        }
    }
}
