using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLogic
{
    public class Checks
    {
      public bool hasCutSurface(int[] rectangle1, int[] rectangle2)
      {
         int[] resultRectangle = { Math.Max(rectangle1[0],rectangle2[0]),
                                   Math.Min(rectangle1[1],rectangle2[1]),
                                   Math.Min(rectangle1[2],rectangle2[2]),
                                   Math.Max(rectangle1[3],rectangle2[3])};

         if(resultRectangle[0] > resultRectangle[2] || resultRectangle[1] < resultRectangle[3])
         {
            return false;
         }
         else
         {
            return true;
         }
      }
    }
}
