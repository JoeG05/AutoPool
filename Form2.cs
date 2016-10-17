using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int week = Convert.ToInt32(textBox1.Text);
            int home = Convert.ToInt32(textBox2.Text);
            int away = Convert.ToInt32(textBox3.Text);
            string rossis = "";
            

            if (radioButton1.Checked == true)
            {
                rossis = "Rossis1";
            }
            else if (radioButton2.Checked == true)
            {
                rossis = "Rossis2";
            }

            string q = "UPDATE " + rossis + " SET Home_Score = '" + home + "', Away_Score = '" + away + "' WHERE Week = '" + week + "'";
            sql s = new sql();
            s.Update(q);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
