using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TflApi.Repository
{
    public interface ILineRepository
    {
        string LineRoute();
        string LineStopPoints(string ids);

    }
}
