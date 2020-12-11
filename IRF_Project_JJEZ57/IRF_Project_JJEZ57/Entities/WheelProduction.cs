using IRF_Project_JJEZ57.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_JJEZ57.Entities
{
    public class WheelProduction:IToyFactory
    {
        public Color WheelColor { get; set; }

        public Toy CreateNew()
        {
            return new Wheel(WheelColor);
        }
    }
}
