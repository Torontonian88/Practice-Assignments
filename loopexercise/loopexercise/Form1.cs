using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopexercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;

            int loopStart;
            int loopEnd;

            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);

            for (int i = loopStart; i < loopEnd; i++)
            {
                answer = answer + i;
            }

            MessageBox.Show(answer.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
