using dependency;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddTransient<OperationTransient, Dependency>();
builder.Services.AddScoped<OperationScoped, Dependency>();
builder.Services.AddSingleton<OperationSingleTone, Dependency>();
builder.Services.AddScoped<OperationSingleToneInstance, Dependency>(a => new Dependency(Guid.Empty));



builder.Services.AddScoped<DependencyClass1, DependencyClass1>();
builder.Services.AddScoped<DependencyClass2, DependencyClass2>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
