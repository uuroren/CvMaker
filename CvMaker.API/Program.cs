using CvMaker.Common.MongoDB;
using CvMaker.Models.User;
using Microsoft.OpenApi.Models;
namespace CvMaker.API {
    public class Program {
        public static void Main(string[] args) {

            const string AllowedOrigin = "*";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(swagger => {
                swagger.UseInlineDefinitionsForEnums();
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "Medibaby Api", Version = "v1" });
                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() {
                    In = ParameterLocation.Header,
                    Description = "Please Enter Your JWT Token Here",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                });
                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
                }
            });
            });

            builder.Services.AddMongo()
                .AddMongoRepository<UserAuthenticationModel>("Users");


            var app = builder.Build();

            
            

            app.UseSwagger();
            app.UseSwaggerUI(swagger => {
                swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "CvMaker Api");
            });

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseDeveloperExceptionPage();

                app.UseCors(builder => {
                    builder.WithOrigins(AllowedOrigin)
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });

            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}