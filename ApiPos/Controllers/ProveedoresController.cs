using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using HCSoft.POS;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        // GET: api/<ProveedoresController>
        [HttpGet]
        public string Get()
        {
            try
            {
                DataTable dt = new Usuarios().Listar();
                if (dt.Rows.Count > 0) { 
                   return JsonConvert.SerializeObject(new { completado = true, mensaje = "", data = dt });
                }
                return JsonConvert.SerializeObject(new { completado = true, mensaje = "No se han encontrado datos registrados",  });

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        // GET api/<ProveedoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProveedoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            string x = "";
        }

        // PUT api/<ProveedoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProveedoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
