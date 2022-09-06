using GraphiQl;
using GraphQL.Types;
using NetGraphQL.Domain.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDomainServices(builder.Configuration);
builder.Services.AddDataAccessServices(builder.Configuration);
builder.Services.AddServiceServices(builder.Configuration);

builder.Services.AddGraphQL(ops =>
{
    ops.EnableMetrics = false;
});

builder.Services.AddControllers();

//(o =>o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseGraphiQl("/graphql");
}
app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();
app.UseHttpsRedirection();

//app.UseGraphiQl("/graphql");
//app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
