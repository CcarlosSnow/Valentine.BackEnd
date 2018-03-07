using AutoMapper;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Valentine.Util;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep;
using Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito;
using Valentine.Application.T_Parametro.Queries.GetParametroByIdPadre;
using Valentine.Application.T_Ubigeo.Queries.GetUbigeoByIdPadre;
using Valentine.Application.T_Archivo.Commands.UploadFile;
using Valentine.Application.T_Archivo.Queries.GetByCodigoSolCredito;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Valentine.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Valentine.Web.App_Start.NinjectWebCommon), "Stop")]

namespace Valentine.Web.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        public static IKernel Kernel;

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            Kernel = kernel;
            return kernel;
        }
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRegisterFirstStepCommand>().To<RegisterFirstStepCommand>();
            kernel.Bind<IRegisterSecondStepCommand>().To<RegisterSecondStepCommand>();
            kernel.Bind<IGetSolicitudCreditoQuery>().To<GetSolicitudCreditoQuery>();
            kernel.Bind<IGetParametroByIdPadreQuery>().To<GetParametroByIdPadreQuery>();
            kernel.Bind<IGetUbigeoByIdPadreQuery>().To<GetUbigeoByIdPadreQuery>();
            kernel.Bind<IGetUbigeoByIdPadreQuery>().To<GetUbigeoByIdPadreQuery>();
            kernel.Bind<IUploadFileCommand>().To<UploadFileCommand>();
            kernel.Bind<IGetArchivoByCodigoSolCreditoQuery>().To<GetArchivoByCodigoSolCreditoQuery>();
            kernel.Bind<IUtil>().To<Util.Util>();

        }
    }
}