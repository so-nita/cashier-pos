using AutoMapper;
using CashierPOS.Model.Models.SubCategory;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.DataMapper
{
    public class SubCategoryProfile : Profile
    {
        public SubCategoryProfile() 
        {
            CreateMap<SubCategoryUpdateReq, SubCategory>()
                .ForMember(des => des.Name, op => op.Condition(e => e.Name != null))
                .ForMember(des => des.Main_Category_Id, op => op.Condition(e => e.Main_Category_Id != null))
                .ForMember(des => des.Image, op => op.Condition(e => e.Image != null))
                .ForMember(des => des.Description, op => op.Condition(e => e.Description != null))
                .ForMember(des => des.Status, op => op.Condition(e => e.Status != null))
                ;
        }
    }
}
