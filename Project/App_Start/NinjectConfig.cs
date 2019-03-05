using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System;
using System.Web.Mvc;

namespace Project
{
    public class NinjectConfig
    {
        public static void RegisterDependencies()
        {
            NinjectModule nj = new NinjectIoC();
            var kernel = new StandardKernel(nj);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}