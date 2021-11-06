using Hudianto_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hudianto_Test.Interface
{
    interface IAvgCalculate
    {
        double Find(Person person);
        int CalculateKilled(int year);
        double GetAverageKilled(double value1, double value2);
    }
}
