using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TflApi.Models;

namespace TflApi.Service
{
    public interface IJorneyService
    {
        ItineraryRes GetJorneyResults(string from, string to);
    }
}
