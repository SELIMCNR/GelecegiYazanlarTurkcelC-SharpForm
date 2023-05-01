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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public  string sifre1;
        private void Form3_Load(object sender, EventArgs e)
        {
            sifre1 = "Sifre = 1234";
            sifre.Text = sifre1;
        }
    }
}
