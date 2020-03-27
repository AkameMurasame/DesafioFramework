using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Entity
{
    [Table("Paciente")]
    public class Paciente : BaseEntity
    {
        [Key]
        public int idPaciente { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int fkidPais { get; set; }
        public int fkidEstado { get; set; }
        public int fkidCidade { get; set; }
    }
}
