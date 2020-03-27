using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Entity
{
    [Table("Cidade")]
    public class Cidade : BaseEntity
    {
        [Key]
        public int idCidade { get; set; }
        public string descricao { get; set; }
        public int fkidEstado { get; set; }
    }
}
