using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities.JourneyPlanner;

namespace TflApi.Models
{
    public class JourneyModel
    {
        public DateTime ArrivalDateTime { get; set; }
        public int Duration { get; set; }
        public List<LegModel> Legs { get; set; }
        public DateTime StartDateTime { get; set; }
    }
}
