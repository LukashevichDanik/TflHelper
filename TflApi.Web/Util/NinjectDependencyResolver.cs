using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TflApi.Repository;
using TflApi.Service;
using TflApi.Service.Interfaces;

namespace TflApi.Web.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IJourneyRepository>().To<JourneyRepository>();
            kernel.Bind<ILineRepository>().To<LineRepository>();
            kernel.Bind<ILineService>().To<LineService>();
            kernel.Bind<IJorneyService>().To<JorneyService>();
        }
    }
}