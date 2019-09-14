using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            int num = int.Parse(txtnumeros.Text);
           
            int i = 1;

            listBox1.Items.Clear();

            while (i <= num)
            {
                listBox1.Items.Add(i++);
             
            }




        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
