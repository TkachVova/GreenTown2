using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenTown.Domain.Entities
{
    public class House
    {
        public int HouseID { get; set; }
        public string Address { get; set; }
        public int AmountOfStores { get; set; }
        public int Square { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
