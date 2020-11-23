using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Reflection;

namespace Cookie_clicker
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();

            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = Color.White;

            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = Color.White;

            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = Color.White;

            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = Color.White;

            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = Color.White;

            label6.BackColor = System.Drawing.Color.Transparent;
            label6.ForeColor = Color.White;

            label7.BackColor = System.Drawing.Color.Transparent;
            label7.ForeColor = Color.White;

            label8.BackColor = System.Drawing.Color.Transparent;
            label8.ForeColor = Color.White;

            label9.BackColor = System.Drawing.Color.Transparent;
            label9.ForeColor = Color.White;

            label10.BackColor = System.Drawing.Color.Transparent;
            label10.ForeColor = Color.White;

            label11.BackColor = System.Drawing.Color.Transparent;
            label11.ForeColor = Color.White;

            label12.BackColor = System.Drawing.Color.Transparent;
            label12.ForeColor = Color.White;

            label13.BackColor = System.Drawing.Color.Transparent;
            label13.ForeColor = Color.White;

            label14.BackColor = System.Drawing.Color.Transparent;
            label14.ForeColor = Color.White;

            label15.BackColor = System.Drawing.Color.Transparent;
            label15.ForeColor = Color.White;

            label16.BackColor = System.Drawing.Color.Transparent;
            label16.ForeColor = Color.White;

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.TabStop = false;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.ForeColor = Color.White;

            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.TabStop = false;
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.ForeColor = Color.White;

            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.TabStop = false;
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.ForeColor = Color.White;

            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.TabStop = false;
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.ForeColor = Color.White;

            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.TabStop = false;
            button5.BackColor = System.Drawing.Color.Transparent;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.ForeColor = Color.White;

            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.TabStop = false;
            button6.BackColor = System.Drawing.Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.ForeColor = Color.White;

            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.TabStop = false;
            button7.BackColor = System.Drawing.Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.ForeColor = Color.White;

            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.TabStop = false;
            button8.BackColor = System.Drawing.Color.Transparent;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button8.ForeColor = Color.White;

            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.TabStop = false;
            button9.BackColor = System.Drawing.Color.Transparent;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button9.ForeColor = Color.White;

            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.TabStop = false;
            button10.BackColor = System.Drawing.Color.Transparent;
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button10.ForeColor = Color.White;

            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.TabStop = false;
            button11.BackColor = System.Drawing.Color.Transparent;
            button11.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button11.ForeColor = Color.White;

            panel1.BackColor = System.Drawing.Color.Transparent;
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel4.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox7.BackColor = System.Drawing.Color.Transparent;
            pictureBox8.BackColor = System.Drawing.Color.Transparent;
            pictureBox9.BackColor = System.Drawing.Color.Transparent;
            pictureBox10.BackColor = System.Drawing.Color.Transparent;

            button1.Cursor = new Cursor(Application.StartupPath + "\\Cursor\\cursor.cur");
        }
        long click = 1;
        long cookies = 0;
        long dClick = 10;

        long upgrade = 0;
        long StatClick = 0;

        int upgrade1 = 0;
        long upgrade1Buy = 100;

        int upgrade2 = 0;
        long upgrade2Buy = 1000;

        int upgrade3 = 0;
        long upgrade3Buy = 1000;

        int h = 0, m = 0, s = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            cookies += click;           
            label1.Text = Convert.ToString(cookies) + " Cookies";
            StatClick++;
            label13.Text = "Clicks: " + StatClick;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(cookies >= dClick) 
            {
                click *= 2;             
                cookies -= dClick;
                label1.Text = Convert.ToString(cookies) + " Cookies";                
                dClick *= (dClick % 75);
                label3.Text = Convert.ToString(dClick);
                label11.Text = "CPC: " + click.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Convert.ToInt64(click = 1);
            Convert.ToInt64(cookies = 0);
            Convert.ToInt64(dClick = 10);
            timer1.Stop();
            timer1.Enabled = false;
            upgrade1Buy = 100;
            upgrade = 0;
            label1.Text = Convert.ToString(cookies) + " Cookies";
            label3.Text = Convert.ToString(dClick);
            label4.Text = "Upgrades: " + upgrade.ToString();
            label5.Text = "Upgrade cost: " + Environment.NewLine + upgrade1Buy.ToString();
            upgrade2Buy = 1000;
            upgrade1 = 0;
            upgrade2 = 0;
            label7.Text = "Upgrades: " + upgrade.ToString();
            s = 0;
            m = 0;
            h = 0;
            label12.Text = string.Format("Time Played: {0}:{1}:{2}", h.ToString().PadLeft(1, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            StatClick = 0;
            label14.Text = "CPS: " + upgrade.ToString();
            int upgrade3 = 0;
            long upgrade3Buy = 1000;

            SaveSettings();
            GetSettings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                if(cookies >= upgrade1Buy) 
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    upgrade += 1;
                    upgrade1 += 1;
                    cookies -= upgrade1Buy;
                    upgrade1Buy += (upgrade1Buy % 30);
                    label4.Text = "Upgrades: " + upgrade1.ToString();
                    label5.Text = "Upgrade cost: " + Environment.NewLine + upgrade1Buy.ToString();
                    label1.Text = Convert.ToString(cookies) + " Cookies";
                    label10.Text = "CPS: " + upgrade.ToString();
                    label14.Text = "CPS: " + upgrade.ToString();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cookies += dClick;
            label1.Text = Convert.ToString(cookies) + " Cookies";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cookies += upgrade;
            label1.Text = Convert.ToString(cookies) + " Cookies";
        }

        private void button5_Click(object sender, EventArgs e)
        {
                if (cookies >= upgrade2Buy)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    upgrade2 += 1;
                    upgrade += 5;
                    cookies -= upgrade2Buy;
                    upgrade2Buy += (upgrade2Buy % 300);
                    label7.Text = "Upgrades: " + upgrade2.ToString();
                    label6.Text = "Upgrade cost: " +Environment.NewLine + upgrade2Buy.ToString();
                    label1.Text = Convert.ToString(cookies) + " Cookies";
                    label10.Text = "CPS: " + upgrade.ToString();
                    label14.Text = "CPS: " + upgrade.ToString();
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            panel1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(panel4.Visible == false)
            {
                panel4.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                panel4.Visible = false;
                panel2.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetSettings() 
        {

            click = Properties.Settings.Default.Click; //click
            cookies = Properties.Settings.Default.Cookies; //cookies
            dClick = Properties.Settings.Default.dClicks; //dClick

            upgrade = Properties.Settings.Default.Upgrade; //upgrade
            StatClick = Properties.Settings.Default.StatClicks; //StatClick

            upgrade1 = Properties.Settings.Default.Upgrade1; //upgrade1
            upgrade1Buy = Properties.Settings.Default.Upgrade1Buy; //upgrade1Buy

            upgrade2 = Properties.Settings.Default.Upgrade2; //upgrade2
            upgrade2Buy = Properties.Settings.Default.Upgrade2Buy; //upgrade2Buy

            upgrade3 = Properties.Settings.Default.Upgrade3; //upgrade3
            upgrade3Buy = Properties.Settings.Default.Upgrade3Buy; //upgrade3Buy

            h = Properties.Settings.Default.h; //hours
            m = Properties.Settings.Default.m; //minutes
            s = Properties.Settings.Default.s; //seconds
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Click = click; //click
            Properties.Settings.Default.Cookies = cookies; //cookies
            Properties.Settings.Default.dClicks = dClick; //dClick

            Properties.Settings.Default.Upgrade = upgrade; //upgrade
            Properties.Settings.Default.StatClicks = StatClick; //StatClick

            Properties.Settings.Default.Upgrade1 = (int)upgrade1; //upgrade1
            Properties.Settings.Default.Upgrade1Buy = upgrade1Buy; //upgrade1Buy

            Properties.Settings.Default.Upgrade2 = (int)upgrade2; //upgrade2
            Properties.Settings.Default.Upgrade2Buy = upgrade2Buy; //upgrade2Buy

            Properties.Settings.Default.Upgrade3 = upgrade3; //upgrade3
            Properties.Settings.Default.Upgrade3Buy = upgrade3Buy; //upgrade3Buy

            Properties.Settings.Default.h = (int)h; //hours
            Properties.Settings.Default.m = (int)m; //minutes
            Properties.Settings.Default.s = (int)s; //seconds

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
            label1.Text = Convert.ToString(cookies) + " Cookies";
            label3.Text = Convert.ToString(dClick);
            label4.Text = "Upgrades: " + upgrade1.ToString();
            label5.Text = "Upgrade cost: " + Environment.NewLine + upgrade1Buy.ToString();
            label7.Text = "Upgrades: " + upgrade2.ToString();
            label6.Text = "Upgrade cost: " + Environment.NewLine + upgrade2Buy.ToString();
            label10.Text = "CPS: " + upgrade.ToString();
            label11.Text = "CPC: " + click.ToString();
            label12.Text = string.Format("Time Played: {0}:{1}:{2}", h.ToString().PadLeft(1, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            label13.Text = "Clicks: " + click;
            label14.Text = "CPS: " + upgrade.ToString();
            timer1.Enabled = true;
            label15.Text = "Upgrades: " + upgrade3;
            label16.Text = "Upgrade cost: " + Environment.NewLine + upgrade3Buy.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaveSettings();
            GetSettings();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(cookies >= upgrade3Buy)
            {
                timer1.Enabled = true;
                timer1.Start();
                cookies -= upgrade3Buy;
                upgrade += 10;
                upgrade3++;
                upgrade3Buy += (upgrade3Buy % 3000);
                label15.Text = "Upgrades: " + upgrade3;
                label16.Text = "Upgrade cost: " +Environment.NewLine + upgrade3Buy.ToString();                
                label10.Text = "CPS: " + upgrade.ToString();
                label14.Text = "CPS: " + upgrade.ToString();
            }            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            panel1.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s++;
            if(s == 60)
            {
                s = 0;
                m++;
            }
            if(m == 60)
            {
                m = 0;
                h++;
            }
            label12.Text = string.Format("Time Played: {0}:{1}:{2}", h.ToString().PadLeft(1, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
    }
}