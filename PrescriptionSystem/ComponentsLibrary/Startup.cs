
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ComponentsLibrary
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PrescriptionSystemDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

//            #region Repositories
//            services.AddTransient(typeof(IGenericRepository<>), typeof(BaseRepository<>));
//            services.AddTransient<IExerciseRepository, ExerciseRepository>();
//            services.AddTransient<IMedicalConditionRepository, MedicalConditionRepository>();
//            services.AddTransient<IMedicineRepository, MedicineRepository>();
//            services.AddTransient<IPatientRepository, PatientRepository>();
//            services.AddTransient<IPrescriptionRepository, PrescriptionRepository>();
//            services.AddTransient<ITherapistRepository, TherapistRepository>();
//            services.AddTransient<ITherapySessionRepository, TherapySessionRepository>();
//            services.AddTransient<ITreatmentRepository, TreatmentRepository>();
//            services.AddTransient<IUserRepository, UserRepository>();
//            #endregion

//            #region Services
//#endregion
        }
    }
}