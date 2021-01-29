using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_patch_RESTful.Utilities;

namespace E_patch_RESTful.Repositories
{
    public class StatisticsRepository
    {
        private readonly DataAnalyzer _dataAnalyzer;
        public StatisticsRepository(DataAnalyzer dataAnalyzer)
        {
            _dataAnalyzer = dataAnalyzer;
        }

        public async Task<object> GetDailyStatistics(object data)
        {
            await _dataAnalyzer.Analyze(data);
            return null;
        }
    }
}
