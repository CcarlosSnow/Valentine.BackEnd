using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep;
using Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito;

namespace Valentine.Application.Infraestructure
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<RegisterFirstStepCommandModel, Data.T_SolicitudCredito>()
                .ForMember(dest => dest.nombreSolicitante, opt => opt.MapFrom(src => src.nombreSolicitante))
                .ForMember(dest => dest.apellidoPaternoSolicitante, opt => opt.MapFrom(src => src.apellidoParternoSolicitante))
                .ForMember(dest => dest.apellidoMaternoSolicitante, opt => opt.MapFrom(src => src.apellidoMaternoSolicitante))
                .ForMember(dest => dest.fechaNacimiento, opt => opt.MapFrom(src => src.fechaNacimiento))
                .ForMember(dest => dest.tipoDocumento, opt => opt.MapFrom(src => src.tipoDocumento))
                .ForMember(dest => dest.numeroDocumento, opt => opt.MapFrom(src => src.numeroDocumento))
                .ForMember(dest => dest.digitoVerificacion, opt => opt.MapFrom(src => src.digitoVerificacion))
                .ForMember(dest => dest.genero, opt => opt.MapFrom(src => src.genero))
                .ForMember(dest => dest.correoElectronico, opt => opt.MapFrom(src => src.correoElectronico))
                .ForMember(dest => dest.numeroCelular, opt => opt.MapFrom(src => src.numeroCelular))
                .ForMember(dest => dest.ingresoMensual, opt => opt.MapFrom(src => src.ingresosMensuales))
                .ForMember(dest => dest.gradoInstruccion, opt => opt.MapFrom(src => src.gradoInstruccion))
                .ForMember(dest => dest.destinoCredito, opt => opt.MapFrom(src => src.destinoCredito))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<Data.T_SolicitudCredito, RegisterFirstStepCommandModel>()
                .ForMember(dest => dest.codigoSolCredito, opt => opt.MapFrom(src => src.codigoSolCredito))
                .ForMember(dest => dest.nombreSolicitante, opt => opt.MapFrom(src => src.nombreSolicitante))
                .ForMember(dest => dest.apellidoParternoSolicitante, opt => opt.MapFrom(src => src.apellidoPaternoSolicitante))
                .ForMember(dest => dest.apellidoMaternoSolicitante, opt => opt.MapFrom(src => src.apellidoMaternoSolicitante))
                .ForMember(dest => dest.fechaNacimiento, opt => opt.MapFrom(src => src.fechaNacimiento))
                .ForMember(dest => dest.tipoDocumento, opt => opt.MapFrom(src => src.tipoDocumento))
                .ForMember(dest => dest.numeroDocumento, opt => opt.MapFrom(src => src.numeroDocumento))
                .ForMember(dest => dest.digitoVerificacion, opt => opt.MapFrom(src => src.digitoVerificacion))
                .ForMember(dest => dest.genero, opt => opt.MapFrom(src => src.genero))
                .ForMember(dest => dest.correoElectronico, opt => opt.MapFrom(src => src.correoElectronico))
                .ForMember(dest => dest.numeroCelular, opt => opt.MapFrom(src => src.numeroCelular))
                .ForMember(dest => dest.ingresosMensuales, opt => opt.MapFrom(src => src.ingresoMensual))
                .ForMember(dest => dest.gradoInstruccion, opt => opt.MapFrom(src => src.gradoInstruccion))
                .ForMember(dest => dest.destinoCredito, opt => opt.MapFrom(src => src.destinoCredito))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<RegisterSecondStepCommandModel, Data.T_SolicitudCredito>()
                .ForMember(dest => dest.direccionSolicitante, opt => opt.MapFrom(src => src.direccionSolicitante))
                .ForMember(dest => dest.codigoPostal, opt => opt.MapFrom(src => src.codigoPostalSolicitante))
                .ForMember(dest => dest.paisSolicitante, opt => opt.MapFrom(src => src.pais))
                .ForMember(dest => dest.dptoSolicitante, opt => opt.MapFrom(src => src.departamento))
                .ForMember(dest => dest.provinciaSolicitante, opt => opt.MapFrom(src => src.provincia))
                .ForMember(dest => dest.distritoSolicitante, opt => opt.MapFrom(src => src.distrito))
                .ForMember(dest => dest.montoSolicitado, opt => opt.MapFrom(src => src.montoSolicitado))
                .ForMember(dest => dest.plazoPrestamo, opt => opt.MapFrom(src => src.plazoPrestamo))
                .ForMember(dest => dest.seguroDesgravamen, opt => opt.MapFrom(src => src.seguroDesgravamen))
                .ForMember(dest => dest.estadoCivil, opt => opt.MapFrom(src => src.estadoCivil))
                .ForMember(dest => dest.apellidoPaternoConyuge, opt => opt.MapFrom(src => src.apellidoPaternoConyuge))
                .ForMember(dest => dest.apellidoMaternoConyuge, opt => opt.MapFrom(src => src.apellidoMaternoConyuge))
                .ForMember(dest => dest.nombreConyuge, opt => opt.MapFrom(src => src.nombresConyuge))
                .ForMember(dest => dest.tipoDocumentoConyuge, opt => opt.MapFrom(src => src.tipoDocumentoConyuge))
                .ForMember(dest => dest.numeroDocConyuge, opt => opt.MapFrom(src => src.numeroDocConyuge))
                .ForMember(dest => dest.areaActividad, opt => opt.MapFrom(src => src.tipoActividad))
                .ForMember(dest => dest.ocupacion, opt => opt.MapFrom(src => src.rubroActividad))
                .ForMember(dest => dest.lugarTrabajo, opt => opt.MapFrom(src => src.lugarTrabajo))
                .ForMember(dest => dest.tipoCuenta, opt => opt.MapFrom(src => src.tipoCuenta))
                .ForMember(dest => dest.nombreEntidad, opt => opt.MapFrom(src => src.banco))
                .ForMember(dest => dest.codigoInterbancario, opt => opt.MapFrom(src => src.cuentaInterbancaria))
                .ForMember(dest => dest.esPEP, opt => opt.MapFrom(src => src.esPEP))
                .ForMember(dest => dest.cargoPEP, opt => opt.MapFrom(src => src.cargoPEP))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<Data.T_SolicitudCredito, RegisterSecondStepCommandModel>()
                .ForMember(dest => dest.direccionSolicitante, opt => opt.MapFrom(src => src.direccionSolicitante))
                .ForMember(dest => dest.codigoPostalSolicitante, opt => opt.MapFrom(src => src.codigoPostal))
                .ForMember(dest => dest.pais, opt => opt.MapFrom(src => src.paisSolicitante))
                .ForMember(dest => dest.departamento, opt => opt.MapFrom(src => src.dptoSolicitante))
                .ForMember(dest => dest.provincia, opt => opt.MapFrom(src => src.provinciaSolicitante))
                .ForMember(dest => dest.distrito, opt => opt.MapFrom(src => src.distritoSolicitante))
                .ForMember(dest => dest.montoSolicitado, opt => opt.MapFrom(src => src.montoSolicitado))
                .ForMember(dest => dest.plazoPrestamo, opt => opt.MapFrom(src => src.plazoPrestamo))
                .ForMember(dest => dest.seguroDesgravamen, opt => opt.MapFrom(src => src.seguroDesgravamen))
                .ForMember(dest => dest.estadoCivil, opt => opt.MapFrom(src => src.estadoCivil))
                .ForMember(dest => dest.apellidoPaternoConyuge, opt => opt.MapFrom(src => src.apellidoPaternoConyuge))
                .ForMember(dest => dest.apellidoMaternoConyuge, opt => opt.MapFrom(src => src.apellidoMaternoConyuge))
                .ForMember(dest => dest.nombresConyuge, opt => opt.MapFrom(src => src.nombreConyuge))
                .ForMember(dest => dest.tipoDocumentoConyuge, opt => opt.MapFrom(src => src.tipoDocumentoConyuge))
                .ForMember(dest => dest.numeroDocConyuge, opt => opt.MapFrom(src => src.numeroDocConyuge))
                .ForMember(dest => dest.tipoActividad, opt => opt.MapFrom(src => src.areaActividad))
                .ForMember(dest => dest.rubroActividad, opt => opt.MapFrom(src => src.ocupacion))
                .ForMember(dest => dest.lugarTrabajo, opt => opt.MapFrom(src => src.lugarTrabajo))
                .ForMember(dest => dest.tipoCuenta, opt => opt.MapFrom(src => src.tipoCuenta))
                .ForMember(dest => dest.banco, opt => opt.MapFrom(src => src.nombreEntidad))
                .ForMember(dest => dest.cuentaInterbancaria, opt => opt.MapFrom(src => src.codigoInterbancario))
                .ForMember(dest => dest.esPEP, opt => opt.MapFrom(src => src.esPEP))
                .ForMember(dest => dest.cargoPEP, opt => opt.MapFrom(src => src.cargoPEP))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<GetSolicitudCreditoQueryModel, Data.T_SolicitudCredito>();
            CreateMap<Data.T_SolicitudCredito, GetSolicitudCreditoQueryModel>();

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
