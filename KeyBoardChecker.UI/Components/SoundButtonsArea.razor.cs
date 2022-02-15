using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.BLL.Interfaces;
using KeyBoardChecker.UI.Interfaces;
using KeyBoardChecker.UI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace KeyBoardChecker.UI.Components;

public partial class SoundButtonsArea
{
    protected ElementReference referal;

    [Inject] 
    private IHistoryLogService HistoryLogService { get; set; }

    [Inject] 
    public ISoundPlayerService SoundPlayerService { get; set; }

    public List<Pad> pads = new()
    {
        new("KeyA", "kick.wav"),
        new("KeyS", "clap.wav"),
        new("KeyD", "hihat.wav"),
        new("KeyF", "boom.wav"),
        new("KeyG", "ride.wav"),
        new("KeyH", "snare.wav"),
        new("KeyJ", "tink.wav"),
        new("KeyK", "tom.wav"),
        new("KeyL", "frog_chorus.mp3")
    };


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender) await referal.FocusAsync();
    }

    public async void OnKeyPressed(KeyboardEventArgs args)
    {
        var pad = pads.FirstOrDefault(x => x.KeyValue == args.Code);
        if (pad != null)
        {
            await SoundPlayerService.Play($"/sounds/{pad.SoundName}", $"{pad.KeyValue}");
            HistoryLogService.AddHistoryLog(pad.KeyValue[3].ToString());
        }
    }
}