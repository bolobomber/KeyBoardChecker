using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.UI.Interfaces;
using KeyBoardChecker.UI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace KeyBoardChecker.UI.Components
{
    public partial class SoundButtonsArea
    {
        [Inject]
        private IHistoryLogService HistoryLogService { get; set; }
        protected ElementReference referal;
        [Inject]
        public ISoundPlayerService SoundPlayerService { get; set; }
        public List<Pad> pads = new List<Pad>()
        {
            new Pad("KeyA","kick.wav"),
            new Pad("KeyS","clap.wav"),
            new Pad("KeyD","hihat.wav"),
            new Pad("KeyF","boom.wav"),
            new Pad("KeyG","ride.wav"),
            new Pad("KeyH","snare.wav"),
            new Pad("KeyJ","tink.wav"),
            new Pad("KeyK","tom.wav"),
            new Pad("KeyL","frog_chorus.mp3"),
        };

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await referal.FocusAsync();
            }
        }

        public async void OnKeyPressed(KeyboardEventArgs args)
        {
            
            var pad = pads.Where(x => x.KeyValue == args.Code).FirstOrDefault();
            if (pad != null)
            {
                await SoundPlayerService.Play($"/sounds/{pad.SoundName}", $"{pad.KeyValue}");
                HistoryLogService.AddHistoryLog(pad.KeyValue[3].ToString());
            }
           
        }
    }
}
