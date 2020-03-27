using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Dto
{
    public class CidadeViewDto
    {
        public int idCidade { get; set; }
        public string Descricao { get; set; }
        public string fkidEstado { get; set; }
        public string fkidPais { get; set; }
    }
}
