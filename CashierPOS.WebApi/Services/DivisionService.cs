using CashierPOS.Model.Models.Division;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace CashierPOS.WebApi.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly IRepository<Division> _repo;
        private readonly IRepository<Product> _repoProduct;

        public DivisionService(IRepository<Division> repo, IRepository<Product> repoProduct)
        {
            _repo = repo;
            _repoProduct = repoProduct;
        }

        public Response<List<DivisionResponse>> ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Select(e => new DivisionResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                }).ToList();
                return Response<List<DivisionResponse>>.Success(data, data.Count(), "Successfully");
            }catch (Exception ex)
            {
                return Response<List<DivisionResponse>>.Fail(ex.Message);
            }
        }

        public Response<List<DivisionResponse>> ReadAllByProduct()
        {
            try
            {
                var products = _repoProduct.GetQueryable().Include(e=>e.SubCategory.Category.Menu.Division).ToList();
                var data = products.Select(e => new DivisionResponse()
                {
                    Id = e.SubCategory.Category.Menu.DivisionId,
                    Name = e.SubCategory.Category.Menu.Division.Name,
                }).DistinctBy(e=>e.Id).ToList();
                return Response<List<DivisionResponse>>.Success(data, data.Count(), "Successfully");
            }
            catch (Exception ex)
            {
                return Response<List<DivisionResponse>>.Fail(ex.Message);
            }
        }
    }

    public interface IDivisionService
    {
        public Response<List<DivisionResponse>> ReadAll();
        public Response<List<DivisionResponse>> ReadAllByProduct();
    }
}
