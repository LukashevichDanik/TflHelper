using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TflApi.Service;
using TflApi.Service.Interfaces;

namespace TflApi.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILineService _lineService;
        private IJorneyService _jorneyService;
        public HomeController(ILineService lineService, IJorneyService jorneyService)
        {
            _lineService = lineService;
            _jorneyService = jorneyService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("api/journey")]
        public ActionResult Journey(string from, string to)
        {
            return Json(_jorneyService.GetJorneyResults(from, to), JsonRequestBehavior.AllowGet);
        }

        [Route("api/index")]
        public ActionResult GetIndex()
        {
            return Json(_lineService.LineRoute(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("api/stops/{id}")]
        public ActionResult LineStopPoints(string id)
        {
            return Json(_lineService.LineStopPoints(id), JsonRequestBehavior.AllowGet);
        }
    }
}