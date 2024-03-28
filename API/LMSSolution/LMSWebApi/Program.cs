using LMS.Application.Service.Customer;
using LMS.Application.Services.Book;
using LMS.Application.Services.Borrow;
using LMS.Application.Services.Common;
using LMS.Application.Services.Customer;
using LMS.Application.Services.Membership;
using LMS.Application.Services.Payment;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Configuration.AddJsonFile("appsettings.json");

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<ICommonService, CommonService>();
        builder.Services.AddScoped<IBookService, BookService>();
        builder.Services.AddScoped<IBorrowService, BorrowService>();
        builder.Services.AddScoped<IMemebershipService, MembershipService>();
        builder.Services.AddScoped<IPaymentService, PaymentService>();
        builder.Services.AddScoped<ICustomerService, CustomerService>();

        builder.Services.AddCors((setup) =>
        {
            setup.AddPolicy("default", (options) =>
            {
                options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
            });

        });

        var app = builder.Build();

        var configuration = app.Configuration;

        RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c => c.AddDbProviderFactory(typeof(System.Data.SqlClient.SqlClientFactory)));
        RuntimeConfiguration.AddConnectionString(configuration["ConnectionStrings:StringKey"], configuration["ConnectionStrings:DefaultConnection"]);
        RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c => c.SetDefaultCompatibilityLevel(SqlServerCompatibilityLevel.SqlServer2012));
        RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c => c.AddCatalogNameOverwrite("*", configuration["ConnectionStrings:CatalogNameToUse"]));


        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors("default");
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}