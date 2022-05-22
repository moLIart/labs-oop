using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop
{
    enum FigureType : int
    {
        Rectangle = 0,
        Ellipse,
        StraightLine,
        ArbitraryLine
    }
    public static class Globals
    {
        public static Color rectBackColor = Color.White;
        public static Color rectBorderColor = Color.Black;
        public static Size canvasSize = new Size(640, 480);
        public static int rectBorderWidth = 1;
        public static int figureType = (int)FigureType.Rectangle;
        public static bool isFilling = true;

        // other / technical
        public static Point cursorPosition = new Point(-1, -1);
    }
}
