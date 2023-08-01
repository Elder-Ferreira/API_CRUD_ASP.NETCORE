using System.Threading.Tasks;
using API_ASP.NET.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API_ASP.NET.Controllers
{
    [Controller]
    [Route("[controller]")] 

    public class PessoaController
    {
        [HttpGet("oi")]
        public string oi() 
        {
            return "Hello World";
        }
    }
}