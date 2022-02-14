using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBoardChecker.UI.Models;
using Microsoft.AspNetCore.Components;

namespace KeyBoardChecker.UI.Components
{
    public partial class NavButton
    {
        [Parameter]
        public string Value { get; set; }


    }
}
