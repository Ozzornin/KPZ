using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //I don't know what logic can be applied here because runways are typically
    //only used for aircraft operations,
   //and they do not need to send any information to the control center
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusyWithAircraft;
        private CommandCentre _centre;
        
        public Runway(CommandCentre centre)
        {
            _centre = centre;           
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} red light!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} green light!");
        }
    }
}
