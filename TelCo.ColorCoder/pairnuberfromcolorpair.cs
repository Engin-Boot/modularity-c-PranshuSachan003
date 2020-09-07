using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
   class PairNumberEncoder
   {
       // Find the major color in the array and get the index
    public static int CalculateMajorColorIndex(ColorPair pair)
    {
     int calculateMajorIndex = -1;
            for (int i = 0; i < Program.returnLengthOfColorMapMajor(); i++)
            {
                if (Program.returnMajorColorFromColorMapMajor(i) == pair.majorColor)
                {
                    calculateMajorIndex = i;
                    break;
                }
            }
       return calculateMajorIndex;
    }
    // Find the minor color in the array and get the index
    public static int CalculateMinorColorIndex(ColorPair pair)
    {
            int calculateMinorIndex = -1;
            for (int i = 0; i < Program.returnLengthOfColorMapMinor(); i++)
            {
                if (Program.returnMinorColorFromColorMapMinor(i) == pair.minorColor)
                {
                    calculateMinorIndex = i;
                    break;
                }
            }
       return calculateMinorIndex;
    }
      public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = CalculateMajorColorIndex(pair);
            int minorIndex = CalculateMinorColorIndex(pair);
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * Program.returnLengthOfColorMapMinor()) + (minorIndex + 1);
        }
   }
}
