using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public string sourcePath;
        public string disfile;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            //sourcePath = System.IO.Path.GetFullPath(ofd.Filename);
            sourcePath = ofd.FileName;
            disfile = Path.GetFullPath(ofd.FileName);
            textBox1.Text = disfile;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(disfile);
            textBox1.Text = "Файл удалён!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
