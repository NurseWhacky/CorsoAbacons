using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// 3 different ways to generate IRepository instances:
//builder.Services.AddSingleton(typeof(IRepository<>), typeof(EFRepository<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
//builder.Services.AddTransient(typeof(IRepository<>), typeof(EFRepository<>));

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
