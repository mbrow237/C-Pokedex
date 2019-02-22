/* This class help create retangle and color of stat bar
 * I used Colormine nuget to convert HSL to RGB
 * The color change is
 * 
 */ 

using System.Drawing;
using System.Windows.Forms;
using ColorMine.ColorSpaces.Comparisons;
using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Conversions;
using System;

namespace PokedexApplication
{
    internal class statBar
    {
        SolidBrush b1;
        Rectangle rectangle1;
        int rectX = 0;
        int rectY = 0;
        int rectWid = 0;
        
        

        public statBar(int x, int y, int wid)
        {
            rectX = x;
            rectY = y;
            rectWid = wid;
            rectangle1 = new Rectangle(rectX, rectY, rectWid, 10);//10px height 
            b1 = new SolidBrush(setColor(wid));//create brush for fill rectangle
        }

        public SolidBrush getBrush()
        {
            return b1; 
        }

        public Rectangle GetRectangle()
        {
            return rectangle1;
        }

        public void setRect(int x, int y, int wid)
        {
            rectX = x;
            rectY = y;
            rectWid = wid;
            rectangle1 = new Rectangle(rectX, rectY, rectWid, 10);//10px height
            b1 = new SolidBrush(setColor(wid));//create brush for fill rectangle
        }

        public double convertMaxNumber(double h)//takes in the stat and convert it to the porportional number
        {
            double newStat = h;
            newStat = newStat * (.705);//I want the max pokemon stat, which is 255 to be light blue. which is a hue of 180. By multiplying it by .705, 255 will be porportional to 180
            return newStat;
        }

        public Color setColor(int h)
        {
            
            double stat = Convert.ToDouble(h);
            if (stat > 360)
            {
                stat = 360;//If pokemon stat is over 360, set it to 360. The highest hue number is 360. This shouldn't occur since the largest pokemon stat is 255
            }

            stat = convertMaxNumber(stat);//convert to porportional number
            var myHSL = new Hsl { H = stat, S = 100, L = 65 }; //the hue determines the color(S and L always stay the same), goes from red -> light blue as number increases. You need colormine nuget for this to work. 
            var myRGB = myHSL.To<Rgb>();//converts HSL to RGB. 
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(255, Convert.ToInt16(myRGB.R), Convert.ToInt16(myRGB.G), Convert.ToInt16(myRGB.B));//set color object. The 255 is aplha and set the color to a visible color.
            return myRgbColor;
        }

    }
}