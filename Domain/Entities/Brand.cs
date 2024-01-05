using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarCleanArcitecture.Entities
{
    //Entities klasörü karşılığı
    public class Brand : Entity<Guid>
    {
        public string Name { get; set; }
    }
}
