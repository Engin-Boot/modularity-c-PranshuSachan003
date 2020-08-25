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
                string str = "";
                for(int i=1;i<26;i++)
                str = str+ string.Format("PairNumber : MajorColor, MinorColor\n", i,Program.colorMapMajor[i],minorColor = Program.colorMapMinor[i]);
                return str;
            }
        }
}
