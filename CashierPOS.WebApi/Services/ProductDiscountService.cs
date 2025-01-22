using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.DiscountProduct;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace CashierPOS.WebApi.Services
{
    public class ProductDiscountService : IProductDiscountService
    {
        private readonly IRepository<ProductDiscount> _repo;
        private readonly IRepository<DiscountType> _repoDiscount;
        private readonly IRepository<Product> _repoProduct;

        public ProductDiscountService(IRepository<ProductDiscount> repo, IRepository<Product> repoProduct, IRepository<DiscountType> repoDiscount)
        {
            _repo = repo;
            _repoProduct = repoProduct;
            _repoDiscount = repoDiscount;
        }

        public Response<string> ActiveDiscount(DiscountProductActiveReq request)
        {
            try
            {
                var dataErrors = DataValidation<DiscountProductActiveReq>.ValidateDynamicTypes(request);
                if (dataErrors != null)
                {
                    return Response<string>.Fail(dataErrors.First().ToString());
                }
                var productDiscount = _repo.GetById(request.DiscountId);
                if (productDiscount==null)
                {
                    return Response<string>.NotFound("Disocunt not found.");
                }
                productDiscount.Status = Status.Enable;

                int result = _repo.SaveChanges();

                return result > 0 ? Response<string>.Success(null, 0, "Successfully") : Response<string>.Fail("Fail to create discount");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Create(DiscountProductCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<DiscountProductCreateReq>.ValidateDynamicTypes(request);
                if(dataErrors.Count > 0)
                {
                    return Response<string>.Fail(dataErrors.First().ToString());
                }
                
                var products = _repoProduct.GetAll().ToList();
                var discount = _repoDiscount.GetById(request.DiscountId);
                if (discount == null)
                {
                    return Response<string>.NotFound("Disocunt not found");
                }
                var productDiscounts = new List<ProductDiscount>();

                foreach (var item in request.Products)
                {
                    var product = products?.FirstOrDefault(e=>e.Id == item.ProductId);
                    if (product != null)
                    {
                        var productDiscount = new ProductDiscount()
                        {
                            Id = Guid.NewGuid().ToString(),
                            ProductId = product.Id,
                            CreatedAt = DateTime.Now,
                            Description = request.Description,
                            DiscountId = request.DiscountId,
                            StartDate = request.StartDate,
                            EndDate = request.EndDate,
                            IsDeleted = false,
                            Status = Status.Disable,
                        };
                        productDiscounts.Add(productDiscount);
                    }
                }
                _repo.AddRange(productDiscounts);
                int result = _repo.SaveChanges();

                return result > 0 ? Response<string>.Success(null,0,"Successfully") : Response<string>.Fail("Fail to create discount");
            }catch (Exception ex)
            {
                _repo.Rollback();
                throw ex.InnerException!;
            }
        }
 
        public Response<string> InActiveDiscount(DiscountProductActiveReq request)
        {
            try
            {
                var dataErrors = DataValidation<DiscountProductActiveReq>.ValidateDynamicTypes(request);
                if (dataErrors != null)
                {
                    return Response<string>.Fail(dataErrors.First().ToString());
                }
                var productDiscount = _repo.GetById(request.DiscountId);
                if (productDiscount == null)
                {
                    return Response<string>.NotFound("Product Discount not found.");
                }
                productDiscount.Status = Status.Disable;

                int result = _repo.SaveChanges();

                return result > 0 ? Response<string>.Success(null, 0, "Successfully") : Response<string>.Fail("Fail to inactive discount");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<DiscountProductResponse>> ReadAll()
        {
            try
            {
                var discount = _repo.GetQueryable().Include(e=>e.DiscountType)
                .Select(e=> new DiscountProductResponse()
                {
                    Id = e.Id,
                    ProductId = e.ProductId,
                    Discount = e.DiscountType.DiscountPercent,
                    Description = e.Description,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    DiscountName = e.DiscountType.Name,
                    Status = e.Status,
                }).ToList();
                return Response<List<DiscountProductResponse>>.Success(discount,discount.Count,"Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Update(DicountProductUpdateReq request)
        {
            try
            {

                return Response<string>.Success();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
    }
}
