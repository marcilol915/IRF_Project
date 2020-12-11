
using IRF_Project_JJEZ57.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_JJEZ57.Entities
{
   public class Wheel:Toy
    {
        public SolidBrush WheelColor { get; private set; }

        public Wheel(Color color)
        {
            WheelColor = new SolidBrush(color);
        }


        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(WheelColor, 0, 0, Width, Height);
            g.FillEllipse(new SolidBrush(Color.Black), Width / 4, Height / 4, Width / 2, Height / 2);
        }
    }
}
