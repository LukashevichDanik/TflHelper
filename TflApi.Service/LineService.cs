using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;
using TflApi.Models;
using TflApi.Repository;
using TflApi.Service.Interfaces;

namespace TflApi.Service
{
    public class LineService:ILineService
    {
        private ILineRepository _lineRepo;
        public LineService(ILineRepository lineRepo)
        {
            _lineRepo = lineRepo;
        }

        public ICollection<TflApi.Models.LineInfo> LineRoute()
        {
            return JsonConvert.DeserializeObject<ICollection<TflApi.Models.LineInfo>>(_lineRepo.LineRoute());
        }
        public ICollection<LineStopPointModel> LineStopPoints(string ids)
        {
            var stopPoints = JsonConvert.DeserializeObject<ICollection<LineStopPointModel>>(_lineRepo.LineStopPoints(ids));
            return stopPoints;
        }
    }
}
