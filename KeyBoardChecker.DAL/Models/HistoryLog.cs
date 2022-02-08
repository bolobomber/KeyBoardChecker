using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBoardChecker.DAL.Models
{
    public class HistoryLog
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Value { get; set; }
    }
}
