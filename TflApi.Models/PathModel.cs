using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TflApi.Models
{
    public class PathModel
    {
        public string LineString { get; set; }
        public IEnumerable<Tfl.Api.Presentation.Entities.Identifier> StopPoints { get; set; }
    }
}
