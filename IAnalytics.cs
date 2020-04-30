using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    interface IAnalytics
    {
        public double[] CalculateAveragePerColumn(Dataset dataset);
        public double[] CalculateAveragePerRow(Dataset dataset);

    }
}
