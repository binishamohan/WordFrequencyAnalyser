using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFrequencyAnalyzerLibrary
{
    public class WordFrequency : Interfaces.IWordFrequency
    {
        public string Word { get; set; }
        public int Frequency { get; set; }
    }
}
