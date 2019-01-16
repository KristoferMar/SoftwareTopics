using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Interfaces
{
    class CarMain
    {
        //This would be Main(string[] args)
        public void MainClass()
        {
            Vechicle buick = new Vechicle("Buick", 4, 160);

            if (buick is IDriveable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("the {0} can't be driven", buick.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();
        }
    }
}
