using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel.Repository
{
    public interface IRepository<DomainEntity, Identify>
    {
        DomainEntity GetById(Identify Id);
    }
}
