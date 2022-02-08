using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyBoardChecker.DAL.Interfaces.Repositories;

namespace KeyBoardChecker.DAL.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly KeyBoardCheckerContext context;

        public HistoryRepository(KeyBoardCheckerContext context)
        {
            this.context = context;
        }
        
    }
}
