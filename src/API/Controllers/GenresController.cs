using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenresController : Controller
    {
        private readonly IRepository<Genre> repo;

        public GenresController(IRepository<Genre> repository)
        {
            this.repo = repository;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Genre> GetAll() 
        {
            return repo.GetAll().ToList();
        }

        [HttpGet]
        [Route("Id/{id}")]
        public Genre GetById(int id)
        {
            return repo.GetById(id) ?? new Genre() { GenreName = "Poba", CreationDate = DateTime.Now, LastModified = DateTime.Now, Books = [], Id = 0 };
        }

        [HttpPost]
        [Route("Add")]
        public void Post(Genre entity)
        {
            repo.Add(entity);
            repo.Save();
        }
    }
}
