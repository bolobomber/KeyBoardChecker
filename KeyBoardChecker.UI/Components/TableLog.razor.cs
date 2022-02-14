using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.DAL.Models;
using Microsoft.AspNetCore.Components;

namespace KeyBoardChecker.UI.Components
{
    public partial class TableLog
    {
        [Inject]
        public IHistoryLogService HistoryLogService { get; set; }

        IEnumerable<HistoryLog> historyLogs;
        public ClearHistoryModal Modal { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            historyLogs = HistoryLogService.GetAllHistoryLog().AsEnumerable();
        }
        public void OnClickButton()
        {
            HistoryLogService.ClearAllHistoryLog();
            historyLogs = new   List<HistoryLog>();
        }
    }
}
