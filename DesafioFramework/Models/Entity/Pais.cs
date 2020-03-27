using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Models.Entity
{
    [Table("Pais")]
    public class Pais : BaseEntity
    {
        [Key]
        public int idPais { get; set; }
        public string Descricao { get; set; }
    }
}
