using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.DAL.Interfaces.Repositories;
using KeyBoardChecker.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace KeyBoardChecker.UI.Extentions
{
    public static class RegisterServices
    {
        public static void AddOwnServices(this IServiceCollection services)
        {
            services.AddScoped<IHistoryRepository, HistoryRepository>();
        }
    }
}
