using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers.Extentions
{
   public static class Calculate
    {
        public static int CalculateFactorial(this int num)
        {
            int result = 1;
            if (num==0)
                return 0;
            
                for (int i = num; i >0; i--)
                {
                    result *= i;
                }
            return result;
            

        }

    }
}
