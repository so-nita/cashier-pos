using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Source;
using Microsoft.AspNetCore.Hosting.Server;

namespace CashierPOS.WebApi.Interfaces
{
    public interface ISourceService : IService<SourceResponse,SourceCreateReq,SourceUpdateReq,Key>
    {

    }

    

    
}