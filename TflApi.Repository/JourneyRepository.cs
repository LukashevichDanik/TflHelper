using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TflApi.Repository
{
    public class JourneyRepository:IJourneyRepository
    {
        public string JorneyFromTo(string from, string to)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString("https://api.tfl.gov.uk/journey/journeyresults/"+from+"/to/"+to);
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
