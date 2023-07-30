using System.ComponentModel.DataAnnotations;

namespace API_ASP.NET.Models
{
    public class Pessoa
    {
        [Key]
        
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public int Idade{ get; set; }
        
        
    }
}