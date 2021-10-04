using Proj01_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Proj01_API.Data
{
    public class DataContext : DbContext // extendendo classe
    {

        // DataContext é a classe que queremos usar para trabalhar com banco de dados
        // é uma espécie de herança
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        // para cada modelo que tivermos teremos um DbSet neste datacontext
        // colocamos todos os modelos aqui
        public DbSet<Pessoa> Pessoa { get; set; }

    }
}