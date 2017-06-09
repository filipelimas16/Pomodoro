using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        int minutes = 0;
        string showseconds = "00";
        string showminutes = "00";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "Iniciar")
            {
                timer1.Start();
                btn_Start.Text = "Pausar";
            }
            else
            {
                timer1.Stop();
                btn_Start.Text = "Iniciar";
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_Start.Text = "Iniciar";
            label2.Text = "00:00";
            seconds = 0;
            minutes = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 59)
            {
                seconds = 0;
                if (minutes == 59)
                {
                    minutes = 0;
                }
                else
                {
                    minutes = minutes + 1;
                }
            }
            else
            {
                seconds = seconds + 1;
            }
            if (seconds == 0 || seconds == 1 || seconds == 2 || seconds == 3 || seconds == 4 || seconds == 5 || seconds == 6 || seconds == 7 || seconds == 8 || seconds == 9)
            {
                showseconds = "0" + seconds;
            }
            else
            {
                showseconds = Convert.ToString(seconds);
            }
            if (minutes == 0 || minutes == 1 || minutes == 2 || minutes == 3 || minutes == 4 || minutes == 5 || minutes == 6 || minutes == 7 || minutes == 8 || minutes == 9)
            {
                showminutes = "0" + minutes;
            }
            else
            {
                showminutes = Convert.ToString(minutes);
            }
            label2.Text = showminutes + ":" + showseconds;
            if (label2.Text == "25:00")
            {
                timer1.Stop();
                MessageBox.Show("Pomodoro acabou!!!");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }
    }
}
