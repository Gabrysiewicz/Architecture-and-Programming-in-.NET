using Laboratorium8.Data;
using AspNetCore.Authentication.Basic;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Laboratorium8.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Laboratorium8IdentityDbContextConnection");builder.Services.AddDbContext<Laboratorium8IdentityDbContext>(options =>
    options.UseSqlite(connectionString));builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Laboratorium8IdentityDbContext>();



// Add services to the container.
builder.Services.AddControllers();
// Add autentication handler
builder.Services.AddAuthentication(BasicDefaults.AuthenticationScheme)
    .AddBasic(options => {
        options.Realm = "Fox API";
        options.Events = new BasicEvents
        {
            OnValidateCredentials = async (context) => {
                var user = context.Username;
                var isValid = user == "user" && context.Password == "password";
                if (isValid)
                {
                    context.Response.Headers.Add("ValidationCustomHeader", "From OnValidateCredentials");
                    var claims = new[]
                    {
                        new Claim(
                            ClaimTypes.NameIdentifier,
                            context.Username,
                            ClaimValueTypes.String,
                            context.Options.ClaimsIssuer
                        ),
                        new Claim(
                            ClaimTypes.Name,
                            context.Username,
                            ClaimValueTypes.String,
                            context.Options.ClaimsIssuer
                        )
                    };
                    context.Principal = new ClaimsPrincipal(new ClaimsIdentity(claims, context.Scheme.Name));
                    context.Success();
                }
                else
                {
                    context.NoResult();
                }
            }
        };
    }
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IFoxesRepository,FoxesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
// Order for these 2 matters
app.UseAuthentication();
app.UseAuthorization();

app.UseFileServer(); // wwwroot/index.html as default web page

app.MapControllers();
app.MapRazorPages();

app.Run();
