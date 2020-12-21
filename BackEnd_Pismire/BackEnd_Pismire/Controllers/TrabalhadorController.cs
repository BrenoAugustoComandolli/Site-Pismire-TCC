using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.Http.Cors;



namespace BackEnd_Pismire.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class TrabalhadorController : ApiController
    {
        PismireEntities2 bd = new PismireEntities2();
        // GET: api/Trabalhador
        public IEnumerable<dynamic> Get()
        {
            var trabalhador = from trab in bd.usuario
                              select new
                              {
                                  trab.idUsuario,
                                  trab.nomeUsuario,
                                  trab.e_mailUsuario,
                                  trab.senhaUsuario,
                                  trab.tipoUsuario,
                                  trab.telefoneUsuario,
                                  trab.latitudeUsuario,
                                  trab.longitudeUsuario,
                              };
            return trabalhador;
        }

        //GET: api/Email
        [Route("api/Email")]
        public IEnumerable<dynamic> GetEmail()
        {
            var email = from trab in bd.usuario
                              select new
                              { 
                                      trab.e_mailUsuario,                              
                              };
            return email;
        }

        // GET: api/Trabalhador/5
        public string Get(int id)
        {
            return "value"; 
        }

        // POST: api/Trabalhador
        public string Post([FromBody]usuario trab)
        { 
            var userExists = bd.usuario.FirstOrDefault(x => x.e_mailUsuario == trab.e_mailUsuario);
            if (userExists != null)
            {
                return "Usuario já cadastrado!";
            }
            else
            {
                bd.usuario.Add(trab);
                bd.SaveChanges();
                return "Salvo com sucesso!";
            }

        }

        // PUT: api/Trabalhador/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Trabalhador/5
        public void Delete(int id)
        {
        }
    }
}
