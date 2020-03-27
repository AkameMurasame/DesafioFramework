using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Dto
{
    public class EstadoViewDto
    {
        public int idEstado { get; set; }
        public string descricao { get; set; }
        public string fkidPais { get; set; }
    }
}
