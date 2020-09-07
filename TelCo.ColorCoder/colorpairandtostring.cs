using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
   internal class ColorPair
        {
            internal Color majorColor;
            internal Color minorColor;
            public override string ToString()
            {
                int totalnumberofcolorpairpossible = returnLengthOfColorMapMinor()*returnLengthOfColorMapMajor();
                string str = "";
                for(int i=1;i<=totalnumberofcolorpairpossible;i++)
                str = str+ string.Format("PairNumber : MajorColor, MinorColor\n", i,ValueOfColorPair.GetColorFromPairNumber(i));
                return str;
            }
        }
}
