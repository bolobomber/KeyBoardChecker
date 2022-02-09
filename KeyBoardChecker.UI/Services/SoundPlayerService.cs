using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.UI.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace KeyBoardChecker.UI.Services
{
    public class SoundPlayerService : ISoundPlayerService
    {
        private readonly IJSRuntime jsRuntime;

        public SoundPlayerService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task Focus(ElementReference element)
        {
            await jsRuntime.InvokeVoidAsync("SetFocusToElement", element);

        }
        public async Task Play(string sound, string id)
        {
            if (string.IsNullOrEmpty(sound))
            {
                return;
            }

            await jsRuntime.InvokeAsync<string>("PlayAudio", $"{id}");
        }

       
    }
}
