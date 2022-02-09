using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBoardChecker.BLL.Interfaces
{
    public interface IHistoryLogService
    {
        public void AddHistoryLog(string key);
    }
}
