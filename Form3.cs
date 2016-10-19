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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            sql s = new sql();
            List < string > l = new List<string>();
            string q = "SELECT DISTINCT Player FROM Stats";
            l = s.Select(q);
            playerBox0.Text = l[0];
            playerBox1.Text = l[1];
            playerBox2.Text = l[2];
            playerBox3.Text = l[3];
            playerBox4.Text = l[4];
            playerBox5.Text = l[5];
            playerBox6.Text = l[6];
            playerBox7.Text = l[7];
            playerBox8.Text = l[8];
            playerBox9.Text = l[9];

                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TextBox[] names = { playerBox0, playerBox1, playerBox2, playerBox3, playerBox4, playerBox5, playerBox6, playerBox7, playerBox8, playerBox9 };
            TextBox[] wins = { winBox0, winBox1, winBox2, winBox3, winBox4, winBox5, winBox6, winBox7, winBox8, winBox9 };
            CheckBox[] eb = { eBox0, eBox1, eBox2, eBox3, eBox4, eBox5, eBox6, eBox7, eBox8, eBox9 };
            CheckBox[] runs = { rBox0, rBox1, rBox2, rBox3, rBox4, rBox5, rBox6, rBox7, rBox8, rBox9 };
            int wk = Convert.ToInt32(week.Text);

            for (int i = 0; i < 10; i++)
            {
                string name;
                int w, l, b = 0, r = 0;
                name = names[i].Text;
                w = Convert.ToInt32(wins[i].Text);
                l = 2 - w;
                if (eb[i].Checked)
                {
                    b = 1;
                }
                if (runs[i].Checked)
                {
                    r = 1;
                }
                string q = "INSERT INTO Stats (Player, W, L, Eight, Run, Week) VALUES('" + name + "', '"
                    + w + "', '" + l + "', '" + b + "', '" + r + "', '" + wk + "')";
                sql s = new sql();
                s.Insert(q);

            }

            this.Close();

        }

        
    }
}
