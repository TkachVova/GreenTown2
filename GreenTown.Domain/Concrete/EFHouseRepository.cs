using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenTown.Domain.Abstract;
using GreenTown.Domain.Entities;

namespace GreenTown.Domain.Concrete
{
    public class EFHouseRepository : IHouseRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<House> Houses { get { return context.Houses; } }
    }
}
