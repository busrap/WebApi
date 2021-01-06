using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Api.Data;

namespace WebApi.Api.Controllers
{
    public class CategoryController : ApiController
    {
        NorthwindEntities db;
        public CategoryController()
        {
            db = new NorthwindEntities();
        }
        // GET: api/Category
        [HttpGet]
        public IEnumerable<Categories> Get()
        {
            var categoryList = db.Categories.ToList();
            return categoryList;
        }

        // GET: api/Category/5
        [HttpGet]
        public Categories Get(int id)
        {
            var category = db.Categories.Single(x => x.CategoryID == id);
            return category;
        }

        // POST: api/Category
        [HttpPost]
        public void Post(Categories value)
        {
            db.Categories.Add(value);
            db.SaveChanges();
        }

        // PUT: api/Category/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
