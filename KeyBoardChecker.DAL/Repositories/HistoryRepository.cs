using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyBoardChecker.DAL.Interfaces.Repositories;
using KeyBoardChecker.DAL.Models;

namespace KeyBoardChecker.DAL.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly KeyBoardCheckerContext context;

        public HistoryRepository(KeyBoardCheckerContext context)
        {
            this.context = context;
        }
        
        

        public void Add(DateTime dateTime, string value)
        {
            context.Add(new HistoryLog()
            {
                DateTime = dateTime,
                Value = value
            });
            context.SaveChanges();
        }

    }
}
