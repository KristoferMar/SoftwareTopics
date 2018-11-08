using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Interfaces
{
    /// <summary>
    /// Interfaces are contracts which a object can choose to implement. 
    /// </summary>
    interface IDriveable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
}
