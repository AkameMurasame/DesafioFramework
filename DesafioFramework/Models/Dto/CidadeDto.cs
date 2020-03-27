using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Dto
{
    public class CidadeDto : BaseDto
    {
        public int idCidade { get; set; }
        public string Descricao { get; set; }
        public int fkidEstado { get; set; }
        public IEnumerable<EstadoViewDto> estados { get; set; }
    }
}
