﻿using System;
using System.Collections.Generic;
using System.Text;
using Fluce.Core.DomainModel;
namespace Fluce.AutoAssign.DomainModel.Staff
{
    public class StaffId:Identity
    {
        public StaffId() { }
        public StaffId(string id) : base(id) { }
    }
}
