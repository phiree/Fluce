﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluce.AutoAssign.DomainModel
{
    public class Period
    {
        /// <summary>
        /// 需求名称
        /// </summary>
        public string RequirementName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}