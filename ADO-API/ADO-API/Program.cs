using DataAccess.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// ✅ Setup connection string and services
string connStr = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddScoped(_ => new SQLHelper(connStr));
builder.Services.AddScoped<FormLogic>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Swagger for API testing
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ✅ Serve React build files
app.UseStaticFiles();

app.UseAuthorization();

// ✅ API endpoints
app.MapControllers();

// ✅ Fallback to React index.html for frontend routing (e.g., /form, /about)
app.MapFallbackToFile("index.html");

app.Run();
