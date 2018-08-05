﻿using App_master.Data.Infrastructure;
using App_master.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Data.Repository
{
    public class GearedRepository : RepositoryBase<Geared>, IGearedRepository
    {
        public GearedRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

    }
    public interface IGearedRepository : IRepository<Geared>
    {

    }
}
