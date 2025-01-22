using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.Model.Interface;

public interface IService<TR, TC, TU, TD> where TR : IResponse where TC : ICreateReq where TU : IUpdateReq where TD : IDelete
{
    public Response<List<TR>>? ReadAll();

    public Response<TR?> Read(Key key);

    public Response<string> Create(TC req);

    public Response<string> Update(TU req);

    public Response<string> Delete(TD key);

}


 