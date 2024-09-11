using brasilApi.Interfaces;

using brasilApi.Mappings;
using brasilApi.Services;
using BrasilApi.Rest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
builder.Services.AddSingleton<IBancoService, BancoService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));
builder.Services.AddAutoMapper(typeof(BancoMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();


app.MapGet("api/v1/busca/{cep}", (string cep, IEnderecoService service) => service.BuscarEndereco(cep));

app.MapGet("api/v1/busca/todos", (IBancoService service) => service.BuscarTodosBancos());

app.MapGet("api/v1/busca/codigo/{codigoBanco}", (string codigoBanco, IBancoService service) => service.BuscarBanco(codigoBanco));




app.Run();

