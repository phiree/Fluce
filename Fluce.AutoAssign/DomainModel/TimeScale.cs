using System;
using System.Collections.Generic;
using System.Text;

namespace Fluce.AutoAssign.DomainModel
{
    public class TimeScale
    {
        public TimeScale(TimeScaleType scaleType, int scaleValue)
        {
            this.ScaleType = scaleType;
            this.Scale = scaleValue;
        }
        public int Scale { get; protected internal set; }
        public TimeScaleType ScaleType { get; protected internal set; }
        
    }
    /// <summary>
    /// 时间单位
    /// </summary>
    public enum TimeScaleType
    {
        Hour,
        Day,
        Week
    }
}
