using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyBoardChecker.DAL.Models;

namespace KeyBoardChecker.DAL.Interfaces.Repositories
{
    public interface IHistoryRepository
    {
        public void Add(DateTime dateTime, string value);
        public void Clear();
        public void DeleteElement(string value);
        public List<HistoryLog> GetAllHistoryLog();
    }
}
