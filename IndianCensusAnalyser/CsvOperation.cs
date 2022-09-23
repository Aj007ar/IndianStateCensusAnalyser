using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyser
{
    public abstract class CsvOperations
        {
            public abstract string[] GetCensusData(string csvFilePath, string dataHeaders);
        }
    
}
