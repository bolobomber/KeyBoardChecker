using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KeyBoardChecker.UI.Models
{
    public class Pad
    {
       
        public string KeyValue { get; set; }
       
        public string SoundName { get; set; }

        public Pad(string keyValue, string soundName)
        {
            KeyValue = keyValue;
            SoundName = soundName;
        }
    }
}
