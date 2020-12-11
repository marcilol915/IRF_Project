using IRF_Project_JJEZ57.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_JJEZ57.Entities
{
    class BMW : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/bmw.jpg");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
