var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MasconsultaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("masconsulta"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("PolicyCors",
          builder => builder
          .AllowAnyMethod()
          .AllowAnyHeader()
          .AllowCredentials()
          .SetIsOriginAllowed((hosts) => true));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("PolicyCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();