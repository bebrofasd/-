using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utka
{
    public partial class Form1 : Form
    {
        int b = 0;
        char fun;
        int v = 1;
        char d, z, x, c, n, m, a, s, g, h, j, r, t, y, u, o, i, f, k;
        char da;
        char daa;
        char zx, xc, cv, vb, nm, mn, bv, vc;
        Random num = new Random();
        SoundPlayer ass = new SoundPlayer("roblox-tycoon-music.wav");
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (b >= 50)
            {
                SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                sp2.Play();
                b = b - 50;
                label2.Text = b.ToString();
                fun = '-';
                button1.Visible = false;
                label3.Visible = false;
                v = v + 1;
                label8.Text = v.ToString();
                d = '!';
            }
        }
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (fun == '-') { b = b + 1; }
            if (fun == '+') { b = b + 3; }
            if (fun == '*') { b = b + 7; }
            if (fun == '/') { b = b + 13; }
            if (fun == '!') { b = b + 21; }
            if (fun == '@') { b = b + 31; }
            if (fun == '%') { b = b + 43; }
            if (fun == ':') { b = b + 59; }
            SoundPlayer sp = new SoundPlayer("mac-quack.wav");
            sp.Play();

            b = b + 1;

            label2.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button1.Visible == false)
            {
                if (b >= 150)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 150;
                    label2.Text = b.ToString();
                    fun = '+';
                    button2.Visible = false;
                    label4.Visible = false;
                    v = v + 2;
                    label8.Text = v.ToString();
                    z = '!';
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button2.Visible == false)
            {
                if (b >= 300)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 300;
                    label2.Text = b.ToString();
                    fun = '*';
                    button4.Visible = false;
                    label6.Visible = false;
                    v = v + 4;
                    label8.Text = v.ToString();
                    x = '!';
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button4.Visible == false)
            {
                if (b >= 800)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 800;
                    label2.Text = b.ToString();
                    fun = '/';
                    button3.Visible = false;
                    label5.Visible = false;
                    v = v + 6;
                    label8.Text = v.ToString();
                    c = '!';
                    daa = '!';
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (b >= 150)
            {
                SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                sp2.Play();
                b = b - 150;
                label2.Text = b.ToString();
                button10.Visible = false;
                label12.Visible = false;
                v = 3;
                label13.Text = v.ToString();
                timer1.Start();
                n = '!';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b = b + 3;
            label2.Text = b.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button10.Visible == false)
            {
                if (b >= 400)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 400;
                    label2.Text = b.ToString();
                    button9.Visible = false;
                    label11.Visible = false;
                    v = 6;
                    label13.Text = v.ToString();
                    timer1.Stop();
                    timer2.Start();
                    m = '!';
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp2 = new SoundPlayer("windows-vista-startup.wav");
            sp2.Play();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp2 = new SoundPlayer("clicksoundeffect.wav");
            sp2.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (da == '!')
            {
                if (b >= 4000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 4000;
                    label2.Text = b.ToString();
                    button14.Visible = false;
                    label18.Visible = false;
                    v = 20;
                    label13.Text = v.ToString();
                    timer4.Stop();
                    timer5.Start();
                    r = '!';
                    nm = '!';
                }
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            b = b + 20;
            label2.Text = b.ToString();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            b = b + 40;
            label2.Text = b.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
            button17.Visible = false;
            button16.Visible = false;
            button15.Visible = false;
            button14.Visible = false;
            button13.Visible = false;
            button12.Visible = false;
            button11.Visible = false;

            label22.Visible = false;
            label21.Visible = false;
            label20.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            label16.Visible = false;
            label15.Visible = false;
            SoundPlayer sp2 = new SoundPlayer("clicksoundeffect.wav");
            sp2.Play();

            label23.Visible = true;
            button20.Visible = true;
            if (o == '!') { label23.Visible = false; button20.Visible = false; }
            button6.Visible = false;
            button21.Visible = true;

            button22.Visible = true;
            label24.Visible = true;

            label25.Visible = true;
            textBox1.Visible = true;
            button23.Visible = true;

            button19.Visible = false;
            if (k == '!') { button22.Visible = false; label24.Visible = false; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button16.Visible == false)
            {
                if (b >= 150)
                {
                    pictureBox2.Visible = true;
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 150;
                    label2.Text = b.ToString();
                    button20.Visible = false;
                    label23.Visible = false;

                    ass.PlayLooping();
                    o = '!';
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ass.Stop();
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label22.Visible = true;
            button18.Visible = true;
            if (zx == '!') { button18.Visible = false; label22.Visible = false; }

            label21.Visible = true;
            button17.Visible = true;
            if (xc == '!') { button17.Visible = false; label21.Visible = false; }

            label20.Visible = true;
            button16.Visible = true;
            if (cv == '!') { button16.Visible = false; label20.Visible = false; }

            label19.Visible = true;
            button15.Visible = true;
            if (vb == '!') { button15.Visible = false; label19.Visible = false; }

            label18.Visible = true;
            button14.Visible = true;
            if (nm == '!') { button14.Visible = false; label18.Visible = false; }

            label17.Visible = true;
            button13.Visible = true;
            if (mn == '!') { button13.Visible = false; label17.Visible = false; }

            label16.Visible = true;
            button12.Visible = true;
            if (bv == '!') { button12.Visible = false; label16.Visible = false; }

            label15.Visible = true;
            button11.Visible = true;
            if (vc == '!') { button11.Visible = false; label15.Visible = false; }

            button20.Visible = false;
            label23.Visible = false;

            SoundPlayer sp2 = new SoundPlayer("clicksoundeffect.wav");
            sp2.Play();
            button21.Visible = false;
            button6.Visible = true;

            button22.Visible = false;
            label24.Visible = false;

            label25.Visible = false;
            textBox1.Visible = false;

            button19.Visible = true;

            button23.Visible = false;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (b >= 100000)
            {
                SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                sp2.Play();
                b = b - 100000;
                label2.Text = b.ToString();
                button22.Visible = false;
                label24.Visible = false;
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
                k = '!';
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SoundPlayer sp2 = new SoundPlayer("echl-sound-effect-slot-machine.wav");
            sp2.Play();
            int num2 = num.Next(1, 10);
            int q = Convert.ToInt32(textBox1.Text);
            if (num2 >= 5) { b = b - q; label2.Text = b.ToString(); }
            if (num2 < 5) { b = b + q; label2.Text = b.ToString(); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ass.PlayLooping();
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button14.Visible == false)
            {
                if (b >= 9000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 9000;
                    label2.Text = b.ToString();
                    button13.Visible = false;
                    label17.Visible = false;
                    v = 40;
                    label13.Text = v.ToString();
                    timer5.Stop();
                    timer6.Start();
                    t = '!';
                    mn = '!';
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button13.Visible == false)
            {
                if (b >= 12000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 16000;
                    label2.Text = b.ToString();
                    button12.Visible = false;
                    label16.Visible = false;
                    v = 60;
                    label13.Text = v.ToString();
                    timer6.Stop();
                    timer7.Start();
                    y = '!';
                    bv = '!';
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            b = b + 60;
            label2.Text = b.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button12.Visible == false)
            {
                if (b >= 25000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 25000;
                    label2.Text = b.ToString();
                    button11.Visible = false;
                    label15.Visible = false;
                    v = 100;
                    label13.Text = v.ToString();
                    timer7.Stop();
                    timer8.Start();
                    u = '!';
                    vc = '!';
                }
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            b = b + 100;
            label2.Text = b.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label9.Visible = false;
            button7.Visible = false;

            label10.Visible = false;
            button8.Visible = false;

            label11.Visible = false;
            button9.Visible = false;

            label12.Visible = false;
            button10.Visible = false;

            label16.Visible = true;
            button12.Visible = true;
            if (y == '!') { button12.Visible = false; label16.Visible = false; }

            label15.Visible = true;
            button11.Visible = true;
            if (u == '!') { button11.Visible = false; label15.Visible = false; }

            label17.Visible = true;
            button13.Visible = true;
            if (t == '!') { button13.Visible = false; label17.Visible = false; }

            label18.Visible = true;
            button14.Visible = true;
            if (r == '!') { button14.Visible = false; label18.Visible = false; }

            label19.Visible = true;
            button15.Visible = true;
            if (j == '!') { button15.Visible = false; label19.Visible = false; }

            label20.Visible = true;
            button16.Visible = true;
            if (h == '!') { button16.Visible = false; label20.Visible = false; }

            label21.Visible = true;
            button17.Visible = true;
            if (g == '!') { button17.Visible = false; label21.Visible = false; }

            label22.Visible = true;
            button18.Visible = true;
            if (i == '!') { button18.Visible = false; label22.Visible = false; }

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            SoundPlayer sp2 = new SoundPlayer("clicksoundeffect.wav");
            sp2.Play();

            button6.Visible = true;
            button5.Visible = false;
            button19.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button9.Visible == false)
            {
                if (b >= 800)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 800;
                    label2.Text = b.ToString();
                    button8.Visible = false;
                    label10.Visible = false;
                    v = 9;
                    label13.Text = v.ToString();
                    timer2.Stop();
                    timer3.Start();
                    a = '!';
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button17.Visible == false)
            {
                if (b >= 7000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 7000;
                    label2.Text = b.ToString();
                    fun = '%';
                    button16.Visible = false;
                    label20.Visible = false;
                    v = v + 12;
                    label8.Text = v.ToString();
                    h = '!';
                    cv = '!';
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button16.Visible == false)
            {
                if (b >= 12000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 12000;
                    label2.Text = b.ToString();
                    fun = ':';
                    button15.Visible = false;
                    label19.Visible = false;
                    v = v + 16;
                    label8.Text = v.ToString();
                    j = '!';
                    vb = '!';
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            b = b + 6;
            label2.Text = b.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            b = b + 9;
            label2.Text = b.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            b = b + 12;
            label2.Text = b.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button8.Visible == false)
            {
                if (b >= 1500)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 1500;
                    label2.Text = b.ToString();
                    button7.Visible = false;
                    label9.Visible = false;
                    v = 12;
                    label13.Text = v.ToString();
                    timer3.Stop();
                    timer4.Start();
                    s = '!';
                    da = '!';
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label3.Visible = true;
            if (d == '!') { button1.Visible = false; label3.Visible = false; }

            label4.Visible = true;
            button2.Visible = true;
            if (z == '!') { button2.Visible = false; label4.Visible = false; }

            label5.Visible = true;
            button3.Visible = true;
            if (c == '!') { button3.Visible = false; label5.Visible = false; }

            label6.Visible = true;
            button4.Visible = true;
            if (x == '!') { button4.Visible = false; label6.Visible = false; }

            label9.Visible = true;
            button7.Visible = true;
            if (s == '!') { button7.Visible = false; label9.Visible = false; }

            label10.Visible = true;
            button8.Visible = true;
            if (a == '!') { button8.Visible = false; label10.Visible = false; }

            label11.Visible = true;
            button9.Visible = true;
            if (m == '!') { button9.Visible = false; label11.Visible = false; }

            label12.Visible = true;
            button10.Visible = true;
            if (n == '!') { button10.Visible = false; label12.Visible = false; }

            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;

            label19.Visible = false;
            button15.Visible = false;

            label20.Visible = false;
            button16.Visible = false;

            label21.Visible = false;
            button17.Visible = false;

            label22.Visible = false;
            button18.Visible = false;


            label18.Visible = false;
            label17.Visible = false;
            label16.Visible = false;
            label15.Visible = false;

            SoundPlayer sp2 = new SoundPlayer("clicksoundeffect.wav");
            sp2.Play();

            button6.Visible = false;
            button5.Visible = true;
            button19.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (daa == '!')
            {
                if (b >= 1500)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 1500;
                    label2.Text = b.ToString();
                    fun = '!';
                    button18.Visible = false;
                    label22.Visible = false;
                    v = v + 8;
                    label8.Text = v.ToString();
                    f = '!';
                    i = '!';
                    zx = '!';
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SoundPlayer sp3 = new SoundPlayer("spongebob-fail.wav");
            sp3.Play();
            if (button18.Visible == false)
            {
                if (b >= 4000)
                {
                    SoundPlayer sp2 = new SoundPlayer("iphone-apple-store-sound.wav");
                    sp2.Play();
                    b = b - 4000;
                    label2.Text = b.ToString();
                    fun = '@';
                    button17.Visible = false;
                    label21.Visible = false;
                    v = v + 10;
                    label8.Text = v.ToString();
                    g = '!';
                    xc = '!';
                }
            }
        }
    }
}
