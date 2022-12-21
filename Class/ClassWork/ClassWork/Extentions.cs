using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Extentions
    {
        public static string IsMarriedOr(this bool isMarried)
        {
            if (isMarried)
            {
                return "isMarried";
                
            }
            else
            {
                return "notMarried";
            }
            
        }
    }
}
