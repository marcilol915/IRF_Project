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
        CarsEntities1 context = new CarsEntities1();
        private List<Toy> toys = new List<Toy>();
        public void Keszletfrissites()
        {
            var keszlet = from x in context.Termek
                          select new
                          {
                              Termék = x.Nev,
                              Db = x.Darab
                          };
            dataGridView1.DataSource = keszlet.ToList();

        }
        public void WheelAdd()
        {
            var db = (from x in context.Termek
                     where x.Nev == "Kerek"
                     select x.Darab).FirstOrDefault();
            var egysar = (from x in context.Termek
                          where x.Nev == "Kerek"
                          select x.Egységár).FirstOrDefault();
            var del = (from x in context.Termek
                      where x.Nev == "Kerek"
                      select x).FirstOrDefault();
            context.Termek.Remove(del);
            Termek t = new Termek();
            t.Nev = "Kerek";
            t.Darab = Convert.ToInt32(db)+1;
            t.Egységár = Convert.ToInt32(egysar);
            context.Termek.Add(t);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BmwAdd()
        {
            var db = (from x in context.Termek
                      where x.Nev == "BMW"
                      select x.Darab).FirstOrDefault();
            var egysar = (from x in context.Termek
                          where x.Nev == "BMW"
                          select x.Egységár).FirstOrDefault();
            var del = (from x in context.Termek
                       where x.Nev == "BMW"
                       select x).FirstOrDefault();
            context.Termek.Remove(del);
            Termek t = new Termek();
            t.Nev = "BMW";
            t.Darab = Convert.ToInt32(db) + 1;
            t.Egységár = Convert.ToInt32(egysar);
            context.Termek.Add(t);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AudiAdd()
        {
            var db = (from x in context.Termek
                      where x.Nev == "Audi"
                      select x.Darab).FirstOrDefault();
            var egysar = (from x in context.Termek
                          where x.Nev == "Audi"
                          select x.Egységár).FirstOrDefault();
            var del = (from x in context.Termek
                       where x.Nev == "Audi"
                       select x).FirstOrDefault();
            context.Termek.Remove(del);
            Termek t = new Termek();
            t.Nev = "Audi";
            t.Darab = Convert.ToInt32(db) + 1;
            t.Egységár = Convert.ToInt32(egysar);
            context.Termek.Add(t);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MercedesAdd()
        {
            var db = (from x in context.Termek
                      where x.Nev == "Mercedes"
                      select x.Darab).FirstOrDefault();
            var egysar = (from x in context.Termek
                          where x.Nev == "Mercedes"
                          select x.Egységár).FirstOrDefault();
            var del = (from x in context.Termek
                       where x.Nev == "Mercedes"
                       select x).FirstOrDefault();
            context.Termek.Remove(del);
            Termek t = new Termek();
            t.Nev = "Mercedes";
            t.Darab = Convert.ToInt32(db) + 1;
            t.Egységár = Convert.ToInt32(egysar);
            context.Termek.Add(t);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private IToyFactory _production;
        public IToyFactory Production
        {
            get { return _production; }
            set { _production = value; }
        }
        public Form1()
        {
            InitializeComponent();
            Production =new AudiProduction();
            Keszletfrissites();
            timerAudi.Enabled = true;
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

        private void buttonWheel_Click(object sender, EventArgs e)
        {
            Production = new WheelProduction();
            timerWheel.Enabled = true;
            timerMercedes.Enabled = false;
            timerBmw.Enabled = false;
            timerAudi.Enabled = false;
        }

        private void buttonAudi_Click(object sender, EventArgs e)
        {
            Production = new AudiProduction();
            timerWheel.Enabled = false;
            timerMercedes.Enabled = false;
            timerBmw.Enabled = false;
            timerAudi.Enabled = true;
        }

        private void buttonBmw_Click(object sender, EventArgs e)
        {
            Production = new BmwProduction();
            timerWheel.Enabled = false;
            timerMercedes.Enabled = false;
            timerBmw.Enabled = true;
            timerAudi.Enabled = false;
        }

        private void buttonMercedes_Click(object sender, EventArgs e)
        {
            Production = new MercedesProduction();
            timerWheel.Enabled = false;
            timerMercedes.Enabled = true;
            timerBmw.Enabled = false;
            timerAudi.Enabled = false;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();
            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
            Production = new WheelProduction
            { WheelColor=buttonColor.BackColor};
        }

        private void timerWheel_Tick(object sender, EventArgs e)
        {
            WheelAdd();
            Keszletfrissites();
        }

        private void timerBmw_Tick(object sender, EventArgs e)
        {
            BmwAdd();
            Keszletfrissites();
        }

        private void timerAudi_Tick(object sender, EventArgs e)
        {
            AudiAdd();
            Keszletfrissites();
        }

        private void timerMercedes_Tick(object sender, EventArgs e)
        {
            MercedesAdd();
            Keszletfrissites();
        }
    }
}
