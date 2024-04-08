using Marketplace.Infrastructure.Migrations;
using Marketplace.Infrastructurel;
using Martkeplace.Domain.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// custom services

builder.Services.AddRepository(builder.Configuration);



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

UpdateDatabase();

app.Run();




void UpdateDatabase()
{
    var connectionString = builder.Configuration.GetConnection();
    var dbName = builder.Configuration.GetDatabaseName();

    Database.CreateDatabase(connectionString, dbName);

    app.MigrateDatabase();
}
