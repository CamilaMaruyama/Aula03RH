using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03RH.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";

        public string Cpf { get; set; } = string.Empty;
        
        public DateTime DataAdmissao { get; set; }

        public decimal Salario { get; set; }

        

    }
}