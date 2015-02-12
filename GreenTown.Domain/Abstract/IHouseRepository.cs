using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenTown.Domain.Entities;

namespace GreenTown.Domain.Abstract
{
    public interface IHouseRepository
    {
        IQueryable<House> Houses { get; }
    }
}
