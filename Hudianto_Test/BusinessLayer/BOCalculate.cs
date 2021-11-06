using Hudianto_Test.Interface;
using Hudianto_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hudianto_Test.BusinessLayer
{
    public class BOCalculate : IAvgCalculate
    {
        
        public double Find(Person person)
        {
            try
            {
                int selisih1 = person.YearOfDeath1 - person.AgeOfDeath1;
                int selisih2 = person.YearOfDeath2 - person.AgeOfDeath2;

                double killed1 = this.CalculateKilled(selisih1);
                double killed2 = this.CalculateKilled(selisih2);

                double avg = this.GetAverageKilled(killed1, killed2);

                return avg;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public int CalculateKilled(int year)
        {
            int vreturn = 0;
            int x = 0;
            int y = 1;
            int z;
            int[] result = new int[year];
            result[0] = 1;
            for (int a = 1; a <= year-1; a++)
            {
                z = x + y;
                result[a] = z;
                x = y;
                y = z;
            }

            foreach (var item in result)
            {
                vreturn += item;
            }

            return vreturn;
        }

        public double GetAverageKilled(double value1, double value2)
        {
            double result = (value1 + value2) / 2;
            return result;
        }
    }
}
