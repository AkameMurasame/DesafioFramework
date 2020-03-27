using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Dto
{
    public class PaisDto : BaseDto
    {
        public int idPais { get; set; }
        public string Descricao { get; set; }
    }
}
