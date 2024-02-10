using dependency;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddTransient<AddTransientOperation, Dependency>();
builder.Services.AddScoped<AddScopeOperation, Dependency>();
builder.Services.AddSingleton<AddSingleToneOperation, Dependency>();
builder.Services.AddScoped<AddSingleToneInstance,Dependency>(a => new Dependency(Guid.Empty));



builder.Services.AddScoped<Class1, Class1>();
builder.Services.AddScoped<Class2,Class2>();

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
