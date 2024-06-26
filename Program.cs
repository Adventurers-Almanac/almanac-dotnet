var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "AllowAnyOrigin",
	policy =>
	{
		policy.AllowAnyOrigin();
		policy.AllowAnyMethod();
		policy.AllowAnyHeader();
		//policy.WithOrigins("http://localhost");
	});
});

var app = builder.Build();

app.UseCors("AllowAnyOrigin");

// Configure the HTTP request pipeline.

//? We need to expose Swagger in all environments
// if (app.Environment.IsDevelopment())
app.UseSwagger();
app.UseSwaggerUI();


//? Not using HTTPS for now
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

