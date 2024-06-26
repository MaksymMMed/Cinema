using Cinema.API.Extensions;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Sql Server 
builder.Services.AddDbContext(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAutoMapper();
builder.Services.AddHangfire(builder.Configuration);

StripeConfiguration.ApiKey = builder.Configuration["Payments:Stripe:ApiKey"];

builder.Services.AddIdentity();
builder.Services.AddJwtAuthentication(builder.Configuration);

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddEmailService(builder.Configuration);

builder.Services.AddTokenInSwagger();

var app = builder.Build();

app.CreateRoles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
