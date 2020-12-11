using IRF_Project_JJEZ57.Abstractions;
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
        private List<Toy> toys = new List<Toy>();
        private IToyFactory _production;
        public IToyFactory Production
        {
            get { return _production; }
            set { _production = value; }
        }
        public Form1()
        {
            InitializeComponent();
            Production = new BmwProduction();
        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var toy = Production.CreateNew();
            toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var wheel in toys)
            {
                wheel.MoveToy();
                if (wheel.Left > maxPosition)
                    maxPosition = wheel.Left;
            }

            if (maxPosition > 1000)
            {
                var oldesttoy = toys[0];
                mainPanel.Controls.Remove(oldesttoy);
                toys.Remove(oldesttoy);
            }
        }
    }
}
