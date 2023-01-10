using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilhaNetApiDesafio7._0.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}