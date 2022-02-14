using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.UI.Interfaces;
using KeyBoardChecker.UI.Models;
using Microsoft.AspNetCore.Components;

namespace KeyBoardChecker.UI.Components
{
    public partial class SoundButton
    {
        [Inject]
        private IHistoryLogService HistoryLogService { get; set; }
        [Parameter]
        public Pad Pad { get; set; }
        [Inject]
        public ISoundPlayerService SoundPlayerService { get; set; }
        public void OnButtonClick()
        {
            if (Pad == null)
            {
                return;
            }
            SoundPlayerService.Play($"/sounds/{Pad.SoundName}", $"{Pad.KeyValue}");
            HistoryLogService.AddHistoryLog("Mouse_left_click");

        }

    }
}
