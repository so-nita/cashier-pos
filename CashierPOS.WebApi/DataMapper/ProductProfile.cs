using AutoMapper;
using CashierPOS.Model.Models.Product;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.DataMapper
{
    public class ProductProfile : Profile 
    {
        public ProductProfile()
        {
            CreateMap<ProductUpdateReq, Product>()
                .ForMember(dest => dest.Code, opt => opt.Condition(src => src.Code != null))
                .ForMember(dest => dest.Name, op => op.Condition(src => src.Name != null))
                .ForMember(dest => dest.Code, opt => opt.Condition(src => src.Code != null))
                .ForMember(dest => dest.NameKh, opt => opt.Condition(src => src.NameKh != null))
                //.ForMember(dest => dest.Company_Id, opt => opt.Condition(src => src.com != null))
                .ForMember(dest => dest.SubCategory, opt => opt.Condition(src => src.SubCategory != null))
                .ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image != null))
                .ForMember(dest => dest.Cost, opt => opt.Condition(src => src.Cost != null))
                .ForMember(dest => dest.Price, opt => opt.Condition(src => src.Price != null))
                .ForMember(dest => dest.Description, opt => opt.Condition(src => src.Description != null))
                .ForMember(dest => dest.Status, opt => opt.Condition(src => src.Status != null))
                .ForMember(dest => dest.Is_Deleted, opt => opt.Condition(src => src != null))   
                ;
        }
    }
}
