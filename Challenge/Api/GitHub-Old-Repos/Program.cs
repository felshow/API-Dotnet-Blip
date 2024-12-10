var builder = WebApplication.CreateBuilder(args);

// Adicionar servi�os ao cont�iner.
builder.Services.AddControllers();
// Saiba mais sobre como configurar o Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adicionar o servi�o GitHub ao cont�iner de inje��o de depend�ncia
builder.Services.AddScoped<IGitHubService, GitHubService>();

var app = builder.Build();

// Configurar o pipeline de requisi��es HTTP.
if (app.Environment.IsDevelopment())
{
    // Usar Swagger e SwaggerUI apenas no ambiente de desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirecionar HTTP para HTTPS
app.UseHttpsRedirection();

// Usar o middleware de tratamento de exce��es
app.UseMiddleware<GitHub_Old_Repos.Middleware.ExceptionHandlingMiddleware>();

// Mapear controladores
app.MapControllers();

// Executar a aplica��o
app.Run();
