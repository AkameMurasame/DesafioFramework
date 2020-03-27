using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Dto
{
    public class PacienteViewDto
    {
        public int idPaciente { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string fkidPais { get; set; }
        public string fkidEstado { get; set; }
        public string fkidCidade { get; set; }
    }
}
