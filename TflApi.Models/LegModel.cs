using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;
using Tfl.Api.Presentation.Entities.JourneyPlanner;

namespace TflApi.Models
{
    public class LegModel
    {
        public Tfl.Api.Presentation.Entities.Point ArrivalPoint { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Tfl.Api.Presentation.Entities.Point DeparturePoint { get; set; }
        public DateTime DepartureTime { get; set; }
        public double? Distance { get; set; }
        public int Duration { get; set; }
        public IEnumerable<Obstacle> Obstacles { get; set; }
        public PathModel Path { get; set; }
        public IEnumerable<PlannedWork> PlannedWorks { get; set; }
        public string Speed { get; set; }
    }
}
