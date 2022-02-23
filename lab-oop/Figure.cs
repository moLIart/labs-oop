using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop
{
    abstract class Figure
    {
        public abstract void Draw(Graphics g, Pen pen);
    }
}
