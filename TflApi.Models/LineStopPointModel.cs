using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;

namespace TflApi.Models
{
    public class LineStopPointModel
    {
        public string AccessibilitySummary { get; set; }
        public string commonName { get; set; }
        public string HubNaptanCode { get; set; }
        public string IcsCode { get; set; }
        public string Indicator { get; set; }
        public List<LineGroup> LineGroup { get; set; }
        public List<LineModeGroup> LineModeGroups { get; set; }
        public List<Identifier> Lines { get; set; }
        public ModeList Modes { get; set; }
        public string NaptanId { get; set; }
        public string NaptanMode { get; set; }
        public string PlatformName { get; set; }
        public string SMSCode { get; set; }
        public string StationNaptan { get; set; }
        public bool Status { get; set; }
        public string StopLetter { get; set; }
        public string StopType { get; set; }
        public string lat {get; set;}
        public string lon { get; set; }

    }
}
