using KeyBoardChecker.BLL.Interfaces;
using Microsoft.AspNetCore.Components;

namespace KeyBoardChecker.UI.Components
{
    public partial class ClearHistoryLogButton
    {
        [Inject]
        private IHistoryLogService HistoryLogService { get; set; }

        public void OnClickButton()
        {   
            HistoryLogService.ClearAllHistoryLog();

            
        }
    }
}
