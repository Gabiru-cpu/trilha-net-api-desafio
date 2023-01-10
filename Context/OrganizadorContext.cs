using Microsoft.EntityFrameworkCore;
using trilhaNetApiDesafio7._0.Models;

namespace trilhaNetApiDesafio7._0.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}