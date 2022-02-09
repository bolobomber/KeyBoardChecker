using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace KeyBoardChecker.UI.Interfaces
{   

    public interface ISoundPlayerService
    {
        public Task Play(string sound, string id);
        public Task Focus(ElementReference element);
        
    }
}
