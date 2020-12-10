using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_JJEZ57.Entities
{
   public class Wheel: Label
    {
        public Wheel()
        {
            Width = 75;
            Height = 75;
            AutoSize = false;
            Paint += Wheel_Paint;
        }

        private void Wheel_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);

        }
        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }
        public void MoveWheel()
        {
            Left += 1;
        }
    }
}
