using Laboratorium8.Data;
using AspNetCore.Authentication.Basic;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Laboratorium8.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Laboratorium8IdentityDbContextConnection");
builder.Services.AddDbContext<Laboratorium8IdentityDbContext>(options =>options.UseSqlite(connectionString));
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = true;
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 8;
        options.Password.RequiredUniqueChars = 0;
    })
    .AddRoles<IdentityRole>()
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

// Cookies
builder.Services
    .AddAuthentication()
    .AddCookie()
    .AddJwtBearer( JwtBearerDefaults.AuthenticationScheme, options => {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Tokens:Issuer"],
            ValidAudience = builder.Configuration["Tokens:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes(builder.Configuration["Tokens:Key"])
            )
        };
    }
);
builder.Services.AddAuthorization();

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

using (var scope = app.Services.CreateScope()){
    using (var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>())
    using (var userManager = scope.ServiceProvider.GetService<UserManager<IdentityUser>>())
    {
        roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
        foreach (var user in userManager.Users.Where(x => x.Email.EndsWith("@example.com")))
        {
            userManager.AddToRoleAsync(user, "Admin").Wait();
        }
    }
}

app.Run();
