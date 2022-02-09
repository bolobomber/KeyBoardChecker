using System;

namespace KeyBoardChecker.DAL.Interfaces.Repositories
{
    public interface IHistoryRepository
    {
        public void Add(DateTime dateTime, string value);
        

    }
}
