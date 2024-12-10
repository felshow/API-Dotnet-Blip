var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner.
builder.Services.AddControllers();
// Saiba mais sobre como configurar o Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adicionar o serviço GitHub ao contêiner de injeção de dependência
builder.Services.AddScoped<IGitHubService, GitHubService>();

var app = builder.Build();

// Configurar o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    // Usar Swagger e SwaggerUI apenas no ambiente de desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirecionar HTTP para HTTPS
app.UseHttpsRedirection();

// Usar o middleware de tratamento de exceções
app.UseMiddleware<GitHub_Old_Repos.Middleware.ExceptionHandlingMiddleware>();

// Mapear controladores
app.MapControllers();

// Executar a aplicação
app.Run();
