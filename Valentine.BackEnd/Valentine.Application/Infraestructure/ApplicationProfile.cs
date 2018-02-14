using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.Infraestructure
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            //CreateMap<Data.Category, GetCategoriesModel>();
            //CreateMap<Data.Product, GetProductsModel>();
            //CreateMap<Data.Product, GetProductByIDModel>();
            //CreateMap<Data.Product, CreateProductModel>();
            //CreateMap<CreateProductCommandModel, Data.Product>();
            //CreateMap<Data.Product, UpdateProductModel>();

            //CreateMap<UpdateProductCommandModel, Data.Product>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            //    .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
            //    .ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.CategoryID))
            //    .ForMember(dest => dest.Category, opt => opt.Ignore())
            //    .ForMember(dest => dest.ID, opt => opt.Ignore());

            //CreateMap<Data.Product, DeleteProductModel>();
            //CreateMap<CreateProductXMLCommandModel, CreateProductXMLModel>();
            //CreateMap<UpdateProductXMLCommandModel, UpdateProductXMLModel>();
        }
    }
}
