using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            imgLuna.Left = imgLuna.Left + 20;

            if (imgLuna.Left >= 500 && imgLuna.Top <= 20)
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            imgLuna.Left = imgLuna.Left - 20;

            if (imgLuna.Left >= 500 && imgLuna.Top <= 20)
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            imgLuna.Top = imgLuna.Top - 20;

            if (imgLuna.Left >= 500 && imgLuna.Top <= 20)
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            imgLuna.Top = imgLuna.Top + 20;

            if (imgLuna.Left >= 500 && imgLuna.Top <= 20)
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
        }
    }    
}
