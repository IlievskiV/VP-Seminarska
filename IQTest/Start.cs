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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            AcceptButton = btnStart;
            this.BackColor = Color.Gray;
            btnStart.BackColor = Color.RoyalBlue;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внесете име!");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 nova = new Form1(tbIme.Text);
            this.Hide();
            if( nova.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
