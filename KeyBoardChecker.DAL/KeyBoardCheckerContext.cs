using KeyBoardChecker.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace KeyBoardChecker.DAL
{
    public class KeyBoardCheckerContext : DbContext
    {
       
        public KeyBoardCheckerContext(DbContextOptions<KeyBoardCheckerContext> options) : base(options)
        {

        }
        public DbSet<HistoryLog>  HistoryLogs { get; set; }
    }
    
}
