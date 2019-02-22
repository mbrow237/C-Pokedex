using System.Drawing;

namespace PokedexApplication
{
    internal class statBar
    {
        Pen p1;
        Rectangle rectangle1;
        int rectX = 0;
        int rectY = 0;
        int rectWid = 0;

        public statBar(int x, int y, int wid)
        {
            rectX = x;
            rectY = y;
            rectWid = wid;
            rectangle1 = new Rectangle(rectX, rectY, rectWid, 100);
            p1 = new Pen(Color.Black);
        }

        public Pen getPen()
        {
            return p1;
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
            rectangle1 = new Rectangle(rectX, rectY, rectWid, 10);
        }

    }
}