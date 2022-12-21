using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Helpers
{
    public static class GetNumsPowers
    {
        public static double GetNumPower(this double num, double power)
        {
            var result = Math.Pow(num, power);

            return result;
        }
    }
}
