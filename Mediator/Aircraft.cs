using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Aircraft
    {
        public string Name;
        public AircraftState state { get; set; } = AircraftState.InAir;
        private CommandCentre _centre;
        private Guid _runway;
        public Aircraft(string name, CommandCentre centre)
        {
            this.Name = name;
            _centre = centre;
        }
        public void Land(Guid runwayId)
        {
            if (state == AircraftState.Landing)
            {
                Console.WriteLine($"{this.Name} is landing rn");
                return;
            }
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            Console.WriteLine($"Checking runway.");
            _runway = (Guid)_centre.Notify(this, new AircraftEventArgs
            {
                AircraftState = AircraftState.Landing,
                RunwayID = runwayId
            });     
            if(_runway == Guid.Empty)
            {
                Console.WriteLine("Aircraft cannot land right now");
                return;
            }
            if (_runway == runwayId)
            {
                Console.WriteLine($"{this.Name} landed on runway {runwayId}");
            }
            else Console.WriteLine($"{this.Name} landed on a free runway {_runway}");
            state = AircraftState.Landing;
            
        }
        public void TakeOff()
        {
            if(state == AircraftState.InAir) {
                Console.WriteLine($"{Name} is in air rn");
                return;
            }
            Console.WriteLine($"Aircraft {this.Name} is taking off.");

            _runway = _centre.Notify(this, new AircraftEventArgs
            {
                RunwayID = _runway,
                AircraftState= AircraftState.TakingOff

            });
            if (_runway != Guid.Empty)
            {
                state = AircraftState.InAir;
                Console.WriteLine($"Aircraft {this.Name} has took off.");
                return;
            }
            Console.WriteLine($"{Name} got some problems with taking off");
        }
    }
}
