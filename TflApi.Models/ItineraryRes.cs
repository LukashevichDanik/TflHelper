using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities.JourneyPlanner;

namespace TflApi.Models
{
    public class ItineraryRes
    {
        public JourneyPlannerCycleHireDockingStationData CycleHireDockingStationData { get; set; }
        public List<JourneyModel> Journeys { get; set; }
        public List<LineInfo> Lines { get; set; }
    }
}
