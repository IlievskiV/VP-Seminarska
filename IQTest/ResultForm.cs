using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IQ_Test
{
    public partial class ResultForm : Form
    {
        private IQScaleResult iqscale;
        private int IQCoef;
        private int minIQ;
        private int xcoef;
        private int ycoef;
        private string Ime;
        private Timer timer;
        public ResultForm(int IQcoef,string ime)
        {
            InitializeComponent();
            Ime = ime;
            IQCoef = IQcoef;
            minIQ = 55;
            xcoef = 20;
            ycoef = 200;
            this.BackColor = Color.DarkGray;
            
            iqscale = new IQScaleResult(IQCoef, xcoef, ycoef);
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();  
        }

        void timer_Tick(object sender, EventArgs e)
        {
            increaseX();
            iqscale.increaseCoordinates(xcoef);
            ChangeColor();
            
            if (minIQ == 55) {
                label1.Text = string.Format("{0}, Вашиот IQ е помал од {1} !!!", Ime, minIQ);
            }
            else if (minIQ > 55 && minIQ < 145)
            {
                label1.Text = string.Format("{0}, Вашиот IQ е: {1} !!!", Ime, minIQ);
            }
            else {
                label1.Text = string.Format("{0}, Вашиот IQ е поголем од {1} !!!", Ime, minIQ);
            }
            label2.Text = "";
            if (minIQ == IQCoef)
            {
                TextResult();
            }
            Invalidate(true);
        }

        public void TextResult() {

            if (IQCoef == 55) {
                label2.Text = "Вие спаѓате во групата на екстремно ниска интелигенција!";
            }
            if (IQCoef > 55 && IQCoef <= 79) {
                label2.Text = "Вие спаѓате во групата на луѓе со ниска интелигенција!";
            }
            if (IQCoef > 79 && IQCoef <= 89) {
                label2.Text = "Вие спаѓате во групата на луѓе со подпросечна интелигенција!";
            }
            if (IQCoef > 89 && IQCoef <= 109) {
                label2.Text = "Вие спаѓате во групата на луѓе со просечна интелигенција!";
            }
            if (IQCoef > 109 && IQCoef <= 119) {
                label2.Text = "Честитки! Вие спаѓате во групата на луѓе со надпросечна интелигенција!";
            }
            if (IQCoef > 119 && IQCoef <= 144) {
                label2.Text = "Честитки! Вие спаѓате во групата на луѓе со висока интелигенција!";
            }
            if (IQCoef == 145) {
                label2.Text = "Честитки! Вие спаѓате во групата на генијалци!";
            }
        }

        public void ChangeColor() {
            if (minIQ >= 55 && minIQ <= 79)
            {
                iqscale.Color = Color.Yellow;
            }
            if (minIQ > 79 && minIQ <= 89)
            {
                iqscale.Color = Color.Orange;
            }
            if (minIQ > 89 && minIQ <= 109)
            {
                iqscale.Color = Color.OrangeRed;
            }
            if (minIQ > 109 && minIQ <= 119)
            {
                iqscale.Color = Color.Red;
            }
            if (minIQ > 119 && minIQ <= 145)
            {
                iqscale.Color = Color.DarkRed;
            }
        }
        public void increaseX()
        {
            if (minIQ < IQCoef)
            {
                xcoef += 18;
                minIQ += 3;
            }
            else
            {
                
                timer.Stop();
                
            }
        }


        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ResultForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Brush bgBrush = new SolidBrush(Color.DarkGray);
            e.Graphics.FillRectangle(bgBrush, 0, 0, this.Width, this.Height);
            iqscale.Draw(e.Graphics);
        }
    }
}
