using DesafioFramework.Dal.Abstract;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Concrete
{
    public class PaisDal : BaseDal<Pais>, IPaisDal
    {
        private readonly IConnectionDb _connectionDb;

        public PaisDal(IConnectionDb connectionDb) : base(connectionDb)
        {
            _connectionDb = connectionDb;
        }
    }
}
