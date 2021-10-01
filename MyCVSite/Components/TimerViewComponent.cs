using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVSite.Components
{
    public class TimerViewComponent
    {
        public string Invoke()
        {
            return $"Текущее время: {DateTime.Now.ToString("hh:mm:ss")}";
        }
    }
}
