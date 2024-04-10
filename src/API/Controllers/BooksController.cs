using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace API.Controllers
{
    public class BooksController : AbstractController<Book>
    {
        private readonly IRepository<Book> repo;
        public BooksController(IRepository<Book> repo) : base(repo)
        {
            this.repo = repo;
        }
    }
}
