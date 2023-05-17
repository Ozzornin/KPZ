using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public void SetUp(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public Guid Notify(Aircraft sender, AircraftEventArgs e)
        {           
            if(e.AircraftState is AircraftState.Landing)
            {
                var runway = getRunway(e.RunwayID);                
                if(runway != null)
                {
                    runway.HighLightRed();
                    runway.IsBusyWithAircraft = true;
                    return runway.Id;
                }
            }
            else if(e.AircraftState == AircraftState.TakingOff) {
                var runway = _runways.Find(r => r.Id == e.RunwayID);
                if( runway == null) {
                    Console.WriteLine($"{sender.Name} is in the air now");
                    return Guid.Empty;
                }
                runway.IsBusyWithAircraft = false;
                runway.HighLightGreen();
                return Guid.Empty;                
            }
        

            return Guid.Empty;
        }


        private Runway getRunway(Guid runwayGuid)
        {
            Runway runway = _runways.Find(r => r.Id == runwayGuid);
            if (runway.IsBusyWithAircraft)
                runway = _runways.Find(r => r.IsBusyWithAircraft == false);

            return runway;
        }
    }
}
