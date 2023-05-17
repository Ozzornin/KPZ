using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public enum AircraftState{
        Landing,
        TakingOff,
        InAir
    }
    public class AircraftEventArgs
    {
        public AircraftState AircraftState { get; set; }
        public Guid RunwayID { get; set; }
    }
}
