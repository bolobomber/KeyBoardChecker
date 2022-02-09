using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.BLL.Services;
using KeyBoardChecker.DAL.Interfaces.Repositories;
using KeyBoardChecker.DAL.Repositories;
using KeyBoardChecker.UI.Interfaces;
using KeyBoardChecker.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KeyBoardChecker.UI.Extentions
{
    public static class RegisterServices
    {
        public static void AddOwnServices(this IServiceCollection services)
        {
            services.AddScoped<IHistoryRepository, HistoryRepository>();
            services.AddScoped<ISoundPlayerService, SoundPlayerService>();
            services.AddScoped<IHistoryLogService, HistoryLogService>();
        }
    }
}
