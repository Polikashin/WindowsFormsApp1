using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void TsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Программа Мои утилиты, содержит ряд небольших программ, которые могут пригодиться в жизни. А главное, научить меня основам программирования на C#.\nАвтор: Поликашин А.М.", caption: "О программе");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();         
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            count=0;
            lblCount.Text = Convert.ToString(count);
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)+1);
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
                int i = 0; 
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;
                    if (i > 1000) break;
                }                    
                if (i < 1000) tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
        }

        private void TbRandom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void BtnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }
    }
}
