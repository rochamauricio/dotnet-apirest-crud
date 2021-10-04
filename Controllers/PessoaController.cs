using System.Diagnostics;
using System.Data.Common;
using System.Threading.Tasks;
using Proj01_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proj01_API.Models;

namespace Proj01_API.Controllers
{
    [Controller]
    [Route("[controller]")] // pega o nome da controller sem a palavra controller: https://localhost:5001/pessoa/oi
    public class PessoaController : ControllerBase
    {
        private DataContext dc;
        public PessoaController(DataContext context)
        {
            this.dc = context;
        }

        // https://localhost:5001/pessoa/api
        [HttpPost("api")]
        public async Task<ActionResult> cadastrar([FromBody] Pessoa p)
        {
            dc.Pessoa.Add(p);
            await dc.SaveChangesAsync(); // trava aqui até o ef efetuar o cadastro
            return Created("Objeto pessoa", p);
        }

        [HttpGet("api")]
        public async Task<ActionResult> listar()
        {
            var dados = await dc.Pessoa.ToListAsync();
            return Ok(dados);
        }

        [HttpGet("api/{codigo}")]
        public Pessoa filtrar(int codigo)
        {
            Pessoa p = dc.Pessoa.Find(codigo);
            return p;
        }

        [HttpPut("api")]
        public async Task<ActionResult> editar([FromBody] Pessoa p)
        {
            // precisa passar todos campos do objeto para funcionar o put
            dc.Pessoa.Update(p);
            await dc.SaveChangesAsync(); // tranca e só segue após realizar mudanças no banco de dados.
            return Ok(p);
        }

        [HttpDelete("api/{codigo}")]
        public async Task<ActionResult> deletar(int codigo)
        {
            Pessoa p = filtrar(codigo);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                dc.Pessoa.Remove(p);
                await dc.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpGet("oi")]
        public string oi()
        {
            return "Hello World";
        }
    }
}