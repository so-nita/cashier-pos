using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/sellInvoice")]
    public class SellInvoiceController : Controller
    {
        private readonly ISellInvoiceService _service;
        private readonly IHttpClientFactory _httpClientFactory;

        public SellInvoiceController(ISellInvoiceService service, IHttpClientFactory httpClientFactory)
        {
            _service = service;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("exportPdf")]
        public async Task<IActionResult> ExternlDomainPdf()
        {
            try
            {
                string url = "http://172.20.10.51:8055/images/sample.pdf"; // URL to the PDF file
                var httpClient = _httpClientFactory.CreateClient("PdfDomain");
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    byte[] pdfBytes = await response.Content.ReadAsByteArrayAsync();

                    return new FileStreamResult(new MemoryStream(pdfBytes), "application/pdf");
                }
                return BadRequest(response.RequestMessage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpGet("{invoiceNo}")]
        public IActionResult Get(string invoiceNo)
        {
            var invoice = new Key()
            {
                Id = invoiceNo
            };
            var data = _service.Read(invoice);

            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }

            return Ok(data);
        }


        [HttpPost]
        public IActionResult Create([FromBody] SellInvoiceCreateReq request)
        {
            var data = _service.Create(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("createAndPrint")]
        public IActionResult CreateAndPrint([FromBody] SellInvoiceCreateReq request)
        {
            var data = _service.CreateAndPrint(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("reprintByLast")]
        public async Task<IActionResult> RePrintReceipt([FromBody] ReprintInvoiceByLast request)
        {
            var data = await _service.ReprintByLast(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("reprintByNo")]
        public IActionResult RePrintReceiptByNo([FromBody] ReprintInvoiceByNo request)
        {
            var data = _service.ReprintByNo(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }
    }
}
