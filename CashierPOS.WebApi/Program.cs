using CashierPOS.WebApi.DataContext;
using CashierPOS.Model.Interface;
using CashierPOS.WebApi.Interface.ISubCategory;
using CashierPOS.WebApi.Interface.Product;
using CashierPOS.WebApi.Interface;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using CashierPOS.WebApi.Services;
using CashierPOS.WebApi.Repository;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.Model.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CashierPOSContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderPaymentService, OrderPaymentService>();
builder.Services.AddScoped<IChangeShiftService, ChangeShiftService>();
builder.Services.AddScoped<ISellInvoiceService, SellInvoiceService>();
builder.Services.AddScoped<ICustomerTypeService, CustomerTypeService>();
builder.Services.AddScoped<ISourceService, SourceService>();
builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();
builder.Services.AddScoped<IReasonReturnTypeService, ReasonReturnTypeService>();
builder.Services.AddScoped<IReasonTypeService, ReasonTypeService>();
builder.Services.AddScoped<IDicountTypeService, DicountTypeService>();
builder.Services.AddScoped<IProductDiscountService, ProductDiscountService>();
builder.Services.AddScoped<IPaymentTypeService, PaymentTypeService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductBrand, BrandService>();
builder.Services.AddScoped<IDivisionService, DivisionService>();

builder.Services.AddScoped<IApprovalStrategy, UserApprovalStrategy>();

//builder.Services.AddSingleton<IWebHostEnvironment, IWebHostEnvironment>();
builder.Services.AddHttpClient();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
