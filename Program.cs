
using MC_TwoToFour___Endpoints.Service.Inputs;
using MC_TwoToFour___Endpoints.Service.Nums;
using MC_TwoToFour___Endpoints.Service.Statements;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAcceptsTwoInputs, AcceptsTwoInputs>();
builder.Services.AddScoped<IAcceptsTwoNums, AcceptsTwoNums>();
builder.Services.AddScoped<IAcceptsTwoNumsStatements, AcceptsTwoNumsStatements>();

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
