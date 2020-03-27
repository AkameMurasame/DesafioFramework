﻿using DesafioFramework.Dal.Abstract;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Concrete
{
    public class PacienteDal : BaseDal<Paciente>, IPacienteDal
    {
        private readonly IConnectionDb _connectionDb;

        public PacienteDal(IConnectionDb connectionDb) : base(connectionDb)
        {
            _connectionDb = connectionDb;
        }
    }
}
