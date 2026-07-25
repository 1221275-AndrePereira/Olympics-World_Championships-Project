using Microsoft.EntityFrameworkCore;

using Backend_App.DataModel.Repository;

namespace Backend_App.WebApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		protected virtual void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			services
				.AddEndpointsApiExplorer()
				.AddSwaggerGen()
				.AddDbContext<AppDbContext>(options =>
				{
					options.UseSqlServer(Configuration["ConnectionString"],
							b => b.MigrationsAssembly("DataModel"));
				});
		}

		public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();
			app.UseRouting();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}