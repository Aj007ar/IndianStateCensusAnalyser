using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyser
{
    public class CensusAdapter
    {
        public string[] GetCensusData(string csvFilePath,string dataHeaders)
        {
            string[] censusData;
            censusData = File.ReadAllLines(csvFilePath);
            return censusData;
        }
    }
}
