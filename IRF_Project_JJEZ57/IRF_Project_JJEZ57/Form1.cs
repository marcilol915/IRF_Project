using IRF_Project_JJEZ57.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_JJEZ57
{
    public partial class Form1 : Form
    {
        private List<Wheel> wheels = new List<Wheel>();
        private WheelProduction _production;
        public WheelProduction Production
        {
            get { return _production; }
            set { _production = value; }
        }
        public Form1()
        {
            InitializeComponent();
            Production = new WheelProduction();
        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var wheel = Production.Create();
            wheels.Add(wheel);
            wheel.Left = -wheel.Width;
            mainPanel.Controls.Add(wheel);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var wheel in wheels)
            {
                wheel.MoveWheel();
                if (wheel.Left > maxPosition)
                    maxPosition = wheel.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestWheel = wheels[0];
                mainPanel.Controls.Remove(oldestWheel);
                wheels.Remove(oldestWheel);
            }
        }
    }
}
