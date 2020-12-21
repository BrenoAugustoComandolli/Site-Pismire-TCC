using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace BackEnd_Pismire.Controllers
{

    public class EmailController : ApiController
    {
        PismireEntities2 bd = new PismireEntities2();
        // GET: api/Email
        public IEnumerable<dynamic> Get()
        {
            var email = from trab in bd.usuario
                        select new
                        {
                            trab.idUsuario,
                            trab.e_mailUsuario,
                        };
            return email;
        }

        // GET: api/Email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Email
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Email/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Email/5
        public void Delete(int id)
        {
        }
    }
}
