﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenTown.Domain.Entities;
using System.Data.Entity;

namespace GreenTown.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
    }
}
