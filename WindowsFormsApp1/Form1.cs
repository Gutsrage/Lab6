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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; 
            string str = (string)listBox1.Items[index];
            char[] chars = str.ToCharArray();
            for(int i = 0; i<chars.Length;i++)
            {
                if (char.ToUpper(chars[i]) >= 'A' && char.ToUpper(chars[i]) <= 'Z')
                    chars[i] = '+';
            }
            string str1 = new string(chars);
            label1.Text= str1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }
    }
}
