using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;

namespace TflApi.Models
{
    public class LineInfo
    {
        public DateTime Created { get; set; }
        public string Id { get; set; }
        public ICollection<LineStatus> LineStatus { get; set; }
        public string ModeName { get; set; }
        public DateTime? Modified { get; set; }
        public string Name { get; set; }
        public ICollection<MatchedRoute> RouteSections { get; set; }
        public ICollection<LineServiceTypeInfo> ServiceTypes { get; set; }
    }
}
