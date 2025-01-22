using AutoMapper;
using CashierPOS.Model.Models.DiscountType;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.IdentityModel.Tokens;

namespace CashierPOS.WebApi.DataMapper
{
    public class DicountTypeProfile : Profile
    {
        public DicountTypeProfile()
        {
            CreateMap<DicountTypeUpdateReq, DiscountType>()
                .ForMember(dest => dest.DiscountPercent, src => src.Condition(e => e.DiscountPercent != null || e.DiscountPercent != 0))
                .ForMember(dest => dest.Name, src => src.Condition(e => e.Description.IsNullOrEmpty() == false))
                .ForMember(dest => dest.Description, src => src.Condition(e => e.Description.IsNullOrEmpty() == false))
                ;
        }
    }
}
