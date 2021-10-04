using System.ComponentModel.DataAnnotations;

namespace Proj01_API.Models
{
    public class Pessoa
    {
        [Key] // Id é chave primaria
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public int Idade { get; set; }
    }
}