using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;
using TflApi.Models;

namespace TflApi.Service.Interfaces
{
    public interface ILineService
    {
        ICollection<TflApi.Models.LineInfo> LineRoute();
        ICollection<LineStopPointModel> LineStopPoints(string ids);
    }
}
