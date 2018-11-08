using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.Core.DomainModel
{
    public class Identity : IIdentity
    {

        public Identity() : this(Guid.NewGuid().ToString()) { }
        
        public Identity(string id)
        {
            this.Id = id;
        }
        public string Id { get; protected set; }
    }
}
