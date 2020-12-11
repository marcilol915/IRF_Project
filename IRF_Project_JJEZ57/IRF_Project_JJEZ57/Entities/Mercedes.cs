﻿using IRF_Project_JJEZ57.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_JJEZ57.Entities
{
    public class Mercedes : Toy
    {
        public Mercedes()
        {
            var img = Image.FromFile("Images/mercedes.jpg");
            Width = img.Width/4;
            Height = img.Height/4;
        }
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/mercedes.jpg");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
