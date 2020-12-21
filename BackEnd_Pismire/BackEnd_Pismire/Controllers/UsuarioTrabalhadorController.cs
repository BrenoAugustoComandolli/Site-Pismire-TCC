using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace BackEnd_Pismire.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class UsuarioTrabalhadorController : ApiController
    {
        PismireEntities2 bd = new PismireEntities2();
        // GET: api/UsuarioTrabalhador
        public IEnumerable<dynamic> Get()
        {
            var usuario = from usu in bd.usuario_trabalhador
                          select new
                          {
                              usu.CPF,
                              usu.RG,
                              usu.dataNascimento,
                              usu.FK_usuario
                          };
            return usuario;
        }
   
        // GET: api/UsuarioTrabalhador/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsuarioTrabalhador
        public string Post([FromBody]usuario_trabalhador trab)
        {
            bd.usuario_trabalhador.Add(trab);
            bd.SaveChanges();
            return "Salvo com sucesso!";
        }

        // PUT: api/UsuarioTrabalhador/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsuarioTrabalhador/5
        public void Delete(int id)
        {
        }
    }
}
