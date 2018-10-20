using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.Domain.DomainModel
{
    public class DomainEntity<Identify>
    {
        public Identify Id { get; set; }
    }
}
