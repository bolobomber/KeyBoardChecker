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
    public string ClassName { get; set; }

    [Inject] 
    private IHistoryLogService HistoryLogService { get; set; }

    [Inject] 
    public ISoundPlayerService SoundPlayerService { get; set; }

    public List<Pad> pads = new()
    {
        new("KeyA", "clap.wav"),
        new("KeyS", "hihat.wav"),
        new("KeyD", "kick.wav"),
        new("KeyF", "openhat.wav"),
        new("KeyG", "boom.wav"),
        new("KeyH", "ride.wav"),
        new("KeyJ", "snare.wav"),
        new("KeyK", "tom.wav"),
        new("KeyL", "tink.wav")
    };


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender) await referal.FocusAsync();
    }

    public async void OnKeyPressed(KeyboardEventArgs args)
    {
        ClassName = ".key:active";
        var pad = pads.FirstOrDefault(x => x.KeyValue == args.Code);
        if (pad != null)
        {
            await SoundPlayerService.Play($"/sounds/{pad.SoundName}", $"{pad.KeyValue}");
            HistoryLogService.AddHistoryLog(pad.KeyValue[3].ToString());
        }
    }
}