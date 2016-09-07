using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TflApi.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/app/libs/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/angualr-route").Include(
                        "~/Scripts/app/libs/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/ngLoader").Include(
                        "~/Scripts/app/libs/ngLoader.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/app/libs/jquery-3.1.0.min.js"));



            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                                        "~/Scripts/app/main/main.module.js",
                                        "~/Scripts/app/main/main.config.js",
                                        "~/Scripts/app/main/main.controller.js"));


            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                                       "~/Scripts/app/index/index.module.js",
                                       "~/Scripts/app/index/index.config.js",
                                       "~/Scripts/app/index/index.controller.js"));


            bundles.Add(new ScriptBundle("~/bundles/stops").Include(
                                       "~/Scripts/app/stops/stops.module.js",
                                       "~/Scripts/app/stops/stops.config.js",
                                       "~/Scripts/app/stops/stops.controller.js"));


            bundles.Add(new ScriptBundle("~/bundles/journey").Include(
                                       "~/Scripts/app/journey/journey.module.js",
                                       "~/Scripts/app/journey/journey.config.js",
                                       "~/Scripts/app/journey/journey.controller.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                                        "~/Content/Site.css",
                                        "~/Content/bootstrap.min.css",
                                        "~/Content/customStyle.css"));
        }
    }
}