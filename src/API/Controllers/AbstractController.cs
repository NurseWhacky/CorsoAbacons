using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class AbstractController<T> : Controller
    {
        private readonly IRepository<T> repo;

        public AbstractController(IRepository<T> repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("All")]
        public virtual IEnumerable<T> GetAll()
        {
            return repo.GetAll().ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public virtual T GetById(int id)
        {
            return repo.GetById(id);
        }

        [HttpPost]
        [Route("Add")]
        public virtual void Add(T entity)
        {
            repo.Add(entity);
            repo.Save();
        }

        [HttpPut]
        [Route("Update")]
        public virtual void Update(T entity)
        {
            repo.Update(entity);
            repo.Save();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public virtual void Delete(int id)
        {
            repo.Delete(id);
            repo.Save();
        }

        [HttpGet]
        [Route("Poba")]
        public virtual string Get()
        {
            return "Web service for Library management";
        }
    }
}
