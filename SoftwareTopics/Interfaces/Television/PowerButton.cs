using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Interfaces
{
    class PowerButton : ICommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
