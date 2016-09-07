using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TflApi.Models;
using TflApi.Repository;

namespace TflApi.Service
{
    public class JorneyService:IJorneyService
    {
        private IJourneyRepository _journeyRepo;
        public JorneyService(IJourneyRepository journeyRepo)
        {
            _journeyRepo = journeyRepo;
        }

        public ItineraryRes GetJorneyResults(string from, string to)
        {
            return  JsonConvert.DeserializeObject<ItineraryRes>(_journeyRepo.JorneyFromTo(from, to));
        }
    }
}
