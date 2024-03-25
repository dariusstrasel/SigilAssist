using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SigilAssist;

namespace SigilUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var compressedText = new SigilBuilder().GetCompressedText(this.textBox1.Text);

            this.textBox2.Text = compressedText;
        }
    }
}