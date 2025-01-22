using CashierPOS.Model.Models.Response;
using System.Net;
using System.Net.Sockets;

namespace CashierPOS.WebApi.Test
{
    public class OpenCashDrawerService : IOpenCashDrawerService
    {
        public Response<string> OpenCashDrawer(CashDrawOpenReq request)
        {
            try
            {
                var client = new TcpClient();

                // Connect to the cash drawer
                client.Connect(request.IpAddress, request.Port);

                // Send the command to open the cash drawer
                NetworkStream stream = client.GetStream();
                byte[] command = new byte[] { 27, 112, 0, 25, 250 }; // Replace with the appropriate control command
                stream.Write(command, 0, command.Length);

                return Response<string>.Success(null, 1, "Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
    }

    public interface IOpenCashDrawerService
    {
        public Response<string> OpenCashDrawer(CashDrawOpenReq request);
    }

    public class CashDrawOpenReq
    {
        public IPAddress IpAddress { get; set; } = null!;
        public int Port { get; set; }  
    }
}
