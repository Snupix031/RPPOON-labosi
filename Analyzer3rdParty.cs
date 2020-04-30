using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lv4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;

        }
       
public double[] PerColumnAverage(double[][] data)
        {
            int row = data.Count();
            int col = data[0].Count();
            double[] results = new double[col];

            for (int i = 0; i < col; i++)
            {

                for (int j = 0; j < row; j++)
                {
                    results[i] += data[j][i];
                }
                results[i] = results[i] / data.Length;
            }

            return results;
        }
    }
}
