using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.Source;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.Services
{
    public class SourceService : ISourceService
    {
        private readonly IRepository<Source> _repo;

        public SourceService(IRepository<Source> repo)
        {
            _repo = repo;
        }

        public Response<List<SourceResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Select(e => new SourceResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                }).OrderByDescending(e=>e.Name).ToList();

                return Response<List<SourceResponse>>.Success(data, data.Count(), "Successfully");
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Create(SourceCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Response<string> Delete(Key key)
        {
            throw new NotImplementedException();
        }

        public Response<SourceResponse?> Read(Key key)
        {
            throw new NotImplementedException();
        }

        
        public Response<string> Update(SourceUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}
