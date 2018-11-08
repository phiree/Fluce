using System;
using System.Collections.Generic;
using System.Text;
using Fluce.Core.DomainModel;
namespace Fluce.AutoAssign.DomainModel.Requirement
{
   public  class RequirementId:Identity
    {
        public RequirementId() { }
        public RequirementId(string id) : base(id) { }
    }
}
