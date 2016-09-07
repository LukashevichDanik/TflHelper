using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TflApi.Repository
{
    public class LineRepository:ILineRepository
    {
        public string LineRoute()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString("https://api.tfl.gov.uk/Line/Route?app_id=f66dbb90&app_key=2e8ceea25abd12fa63a772b5e6330e7c ");
                }
            }
            catch
            {
                return "";
            }
        }
        public string LineStopPoints(string ids)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString("https://api.tfl.gov.uk/Line/"+ids+"/StopPoints?app_id=f66dbb90&app_key=2e8ceea25abd12fa63a772b5e6330e7c ");
                }
            }
            catch
            {
                return "";
            }
        }

    }
}
