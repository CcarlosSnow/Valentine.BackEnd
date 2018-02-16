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
//using Valentine.Application.Category.Queries.GetCategories;
//using Valentine.Application.Product.Queries.GetProducts;
//using Valentine.Application.Product.Queries.GetProductByID;
//using Valentine.Application.Product.Commands.CreateProduct;
//using Valentine.Application.Product.Commands.UpdateProduct;
//using Valentine.Application.Product.Commands.DeleteProduct;
//using Valentine.Application.Category.XML.Queries.GetCategories;
//using Valentine.Application.Category.XML.Queries.GetCategoryByID;
//using Valentine.Application.Product.XML.Queries.GetProducts;
using Valentine.Util;
//using Valentine.Application.Product.XML.Commands.CreateProduct;
//using Valentine.Application.Product.XML.Queries.GetProductByID;
//using Valentine.Application.Product.XML.Commands.UpdateProduct;
//using Valentine.Application.Product.XML.Commands.DeleteProduct;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep;
using Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito;

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
            //kernel.Bind<IGetCategoriesQuery>().To<GetCategoriesQuery>();
            //kernel.Bind<IGetProductsQuery>().To<GetProductsQuery>();
            //kernel.Bind<IGetProductByIDQuery>().To<GetProductByIDQuery>();
            //kernel.Bind<ICreateProductCommand>().To<CreateProductCommand>();
            //kernel.Bind<IUpdateProductCommand>().To<UpdateProductCommand>();
            //kernel.Bind<IDeleteProductCommand>().To<DeleteProductCommand>();
            //kernel.Bind<IGetCategoriesXMLQuery>().To<GetCategoriesXMLQuery>();
            //kernel.Bind<IGetCategoryByIDXMLQuery>().To<GetCategoryByIDXMLQuery>();
            //kernel.Bind<IGetProductsXMLQuery>().To<GetProductsXMLQuery>();
            //kernel.Bind<IGetProductByIDXMLQuery>().To<GetProductByIDXMLQuery>();
            //kernel.Bind<ICreateProductXMLCommand>().To<CreateProductXMLCommand>();
            //kernel.Bind<IUpdateProductXMLCommand>().To<UpdateProductXMLCommand>();
            //kernel.Bind<IDeleteProductXMLCommand>().To<DeleteProductXMLCommand>();
            kernel.Bind<IRegisterFirstStepCommand>().To<RegisterFirstStepCommand>();
            kernel.Bind<IRegisterSecondStepCommand>().To<RegisterSecondStepCommand>();
            kernel.Bind<IGetSolicitudCreditoQuery>().To<GetSolicitudCreditoQuery>();
            kernel.Bind<IUtil>().To<Valentine.Util.Util>();

        }
    }
}