using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        List<Test> test = new List<Test>();

        public TestController()
        {
            test.Add(new Test { Id = 1, FirstName = "Thomas1", LastName = "Bronola1" });
            test.Add(new Test { Id = 2, FirstName = "Thomas2", LastName = "Bronola2" });
            test.Add(new Test { Id = 3, FirstName = "Thomas3", LastName = "Bronola3" });
            test.Add(new Test { Id = 4, FirstName = "Thomas4", LastName = "Bronola4" });
            test.Add(new Test { Id = 5, FirstName = "Thomas5", LastName = "Bronola5" });

        }

        // GET: api/Test
        public List<Test> Get()
        {
            return test;
        }

        // GET: api/Test/5
        public Test Get(int id)
        {
            return test.Where(x => x.Id == id).FirstOrDefault();
        }







        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
            
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
