using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Entity
{
    [Table("Estado")]
    public class Estado : BaseEntity
    {
        [Key]
        public int idEstado { get; set; }
        public string descricao { get; set; }
        public int fkidPais { get; set; }
    }
}
