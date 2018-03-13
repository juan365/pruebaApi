using pruebaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace pruebaApi.Controllers
{
    public class PersonasController : ApiController
    {
        List<Persona> personas;
        public PersonasController()
        {
            personas = new List<Persona>();
            personas.Add(new Persona { Nombre = "Daniel", Email = "daniel@daniel.com", Edad = 25 });
            personas.Add(new Persona { Nombre = "David", Email = "david@david.com", Edad = 21 });
            personas.Add(new Persona { Nombre = "Rober", Email = "Rober@rober.com", Edad = 38 });
            personas.Add(new Persona { Nombre = "Borja", Email = "Borja@Aragoneses.com", Edad = 18 });
        }

        public List<Persona> Get()
        {
            return personas;
        }
        public Persona GetPersona(int id)
        {
            return personas.FirstOrDefault();
        }
    }
}
