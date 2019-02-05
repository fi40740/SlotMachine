using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class SlotMachine : Form
    {
        public SlotMachine()
        {
            InitializeComponent();
        }

        // DECLARING TOTAL, BET, CREDITS
        public static long credits = 100;
        public static long total = 0;
        public static int bet = 3;

        // DECLARING EACH ITEM
        public static int p1;
        public static int p2;
        public static int p3;
        public static int p4;
        public static int p5;
        public static int p6;
        public static int p7;
        public static int p8;
        public static int p9;
        public static int p10;
        public static int p11;
        public static int p12;
        public static int p13;
        public static int p14;
        public static int p15;


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("1.jpg");
            pictureBox2.Image = Image.FromFile("2.jpg");
            pictureBox3.Image = Image.FromFile("3.jpg");
            pictureBox4.Image = Image.FromFile("4.jpg");
            pictureBox5.Image = Image.FromFile("5.jpg");
            pictureBox6.Image = Image.FromFile("1.jpg");
            pictureBox7.Image = Image.FromFile("2.jpg");
            pictureBox8.Image = Image.FromFile("3.jpg");
            pictureBox9.Image = Image.FromFile("4.jpg");
            pictureBox10.Image = Image.FromFile("5.jpg");
            pictureBox11.Image = Image.FromFile("2.jpg");
            pictureBox12.Image = Image.FromFile("3.jpg");
            pictureBox13.Image = Image.FromFile("4.jpg");
            pictureBox14.Image = Image.FromFile("5.jpg");
            pictureBox15.Image = Image.FromFile("1.jpg");
        }

        // GENERATES RANDOM NUMBERS
        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (credits >= bet)
            {
                credits = credits - bet;
                label1.Text = "Credits: " + credits.ToString();

                for (int i = 0; i < 6; i++)
                {
                    p1 = IntUtil.Random(1, 6);
                    p2 = IntUtil.Random(1, 6);
                    p3 = IntUtil.Random(1, 6);
                    p4 = IntUtil.Random(1, 6);
                    p5 = IntUtil.Random(1, 6);
                    p6 = IntUtil.Random(1, 6);
                    p7 = IntUtil.Random(1, 6);
                    p8 = IntUtil.Random(1, 6);
                    p9 = IntUtil.Random(1, 6);
                    p10 = IntUtil.Random(1, 6);
                    p11 = IntUtil.Random(1, 6);
                    p12 = IntUtil.Random(1, 6);
                    p13 = IntUtil.Random(1, 6);
                    p14 = IntUtil.Random(1, 6);
                    p15 = IntUtil.Random(1, 6);
                }

                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(p1.ToString() + ".jpg");

                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile(p2.ToString() + ".jpg");

                if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile(p3.ToString() + ".jpg");

                if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
                pictureBox4.Image = Image.FromFile(p4.ToString() + ".jpg");

                if (pictureBox5.Image != null) pictureBox5.Image.Dispose();
                pictureBox5.Image = Image.FromFile(p5.ToString() + ".jpg");

                if (pictureBox6.Image != null) pictureBox6.Image.Dispose();
                pictureBox6.Image = Image.FromFile(p6.ToString() + ".jpg");

                if (pictureBox7.Image != null) pictureBox7.Image.Dispose();
                pictureBox7.Image = Image.FromFile(p7.ToString() + ".jpg");

                if (pictureBox8.Image != null) pictureBox8.Image.Dispose();
                pictureBox8.Image = Image.FromFile(p8.ToString() + ".jpg");

                if (pictureBox9.Image != null) pictureBox9.Image.Dispose();
                pictureBox9.Image = Image.FromFile(p9.ToString() + ".jpg");

                if (pictureBox10.Image != null) pictureBox10.Image.Dispose();
                pictureBox10.Image = Image.FromFile(p10.ToString() + ".jpg");

                if (pictureBox11.Image != null) pictureBox11.Image.Dispose();
                pictureBox11.Image = Image.FromFile(p11.ToString() + ".jpg");

                if (pictureBox12.Image != null) pictureBox12.Image.Dispose();
                pictureBox12.Image = Image.FromFile(p12.ToString() + ".jpg");

                if (pictureBox13.Image != null) pictureBox13.Image.Dispose();
                pictureBox13.Image = Image.FromFile(p13.ToString() + ".jpg");

                if (pictureBox14.Image != null) pictureBox14.Image.Dispose();
                pictureBox14.Image = Image.FromFile(p14.ToString() + ".jpg");

                if (pictureBox15.Image != null) pictureBox15.Image.Dispose();
                pictureBox15.Image = Image.FromFile(p15.ToString() + ".jpg");

                total = 0;

                // GET RESULTS FROM PAYTABLE
                // CHECK IF 1, 2, 3, 4 OR 5 OCCURANCES
                if (p1 == 1 & p2 == 1 & p3 == 1) total = total + 1;
                if (p1 == 2 & p2 == 2 & p3 == 2) total = total + 2;
                if (p1 == 3 & p2 == 3 & p3 == 3) total = total + 3;
                if (p1 == 4 & p2 == 4 & p3 == 4) total = total + 4;
                if (p1 == 5 & p2 == 5 & p3 == 5) total = total + 5;
                if (p10 == 1 & p9 == 1 & p8 == 1) total = total + 1;
                if (p10 == 2 & p9 == 2 & p8 == 2) total = total + 2;
                if (p10 == 3 & p9 == 3 & p8 == 3) total = total + 3;
                if (p10 == 4 & p9 == 4 & p8 == 4) total = total + 4;
                if (p10 == 5 & p9 == 5 & p8 == 5) total = total + 5;
                if (p15 == 1 & p14 == 1 & p13 == 1) total = total + 1;
                if (p15 == 2 & p14 == 2 & p13 == 2) total = total + 2;
                if (p15 == 3 & p14 == 3 & p13 == 3) total = total + 3;
                if (p15 == 4 & p14 == 4 & p13 == 4) total = total + 4;
                if (p15 == 5 & p14 == 5 & p13 == 5) total = total + 5;
                if (p1 == 1 & p2 == 1 & p3 == 1 & p4 == 1) total = total + 6;
                if (p1 == 2 & p2 == 2 & p3 == 2 & p4 == 2) total = total + 7;
                if (p1 == 3 & p2 == 3 & p3 == 3 & p4 == 3) total = total + 8;
                if (p1 == 4 & p2 == 4 & p3 == 4 & p4 == 4) total = total + 9;
                if (p1 == 5 & p2 == 5 & p3 == 5 & p4 == 5) total = total + 10;
                if (p10 == 1 & p9 == 1 & p8 == 1 & p7 == 1) total = total + 6;
                if (p10 == 2 & p9 == 2 & p8 == 2 & p7 == 2) total = total + 7;
                if (p10 == 3 & p9 == 3 & p8 == 3 & p7 == 3) total = total + 8;
                if (p10 == 4 & p9 == 4 & p8 == 4 & p7 == 4) total = total + 9;
                if (p10 == 5 & p9 == 5 & p8 == 5 & p7 == 5) total = total + 10;
                if (p15 == 1 & p14 == 1 & p13 == 1 & p12 == 1) total = total + 6;
                if (p15 == 2 & p14 == 2 & p13 == 2 & p12 == 2) total = total + 7;
                if (p15 == 3 & p14 == 3 & p13 == 3 & p12 == 3) total = total + 8;
                if (p15 == 4 & p14 == 4 & p13 == 4 & p12 == 4) total = total + 9;
                if (p15 == 5 & p14 == 5 & p13 == 5 & p12 == 5) total = total + 10;
                if (p1 == 1 & p2 == 1 & p3 == 1 & p4 == 1 & p5 == 1) total = total + 20;
                if (p1 == 2 & p2 == 2 & p3 == 2 & p4 == 2 & p5 == 2) total = total + 25;
                if (p1 == 3 & p2 == 3 & p3 == 3 & p4 == 3 & p5 == 3) total = total + 30;
                if (p1 == 4 & p2 == 4 & p3 == 4 & p4 == 4 & p5 == 4) total = total + 40;
                if (p1 == 5 & p2 == 5 & p3 == 5 & p4 == 5 & p5 == 5) total = total + 50;
                if (p10 == 1 & p9 == 1 & p8 == 1 & p7 == 1 & p6 == 1) total = total + 20;
                if (p10 == 2 & p9 == 2 & p8 == 2 & p7 == 2 & p6 == 2) total = total + 25;
                if (p10 == 3 & p9 == 3 & p8 == 3 & p7 == 3 & p6 == 3) total = total + 30;
                if (p10 == 4 & p9 == 4 & p8 == 4 & p7 == 4 & p6 == 4) total = total + 40;
                if (p10 == 5 & p9 == 5 & p8 == 5 & p7 == 5 & p6 == 5) total = total + 50;
                if (p15 == 1 & p14 == 1 & p13 == 1 & p12 == 1 & p11 == 1) total = total + 20;
                if (p15 == 2 & p14 == 2 & p13 == 2 & p12 == 2 & p11 == 2) total = total + 25;
                if (p15 == 3 & p14 == 3 & p13 == 3 & p12 == 3 & p11 == 3) total = total + 30;
                if (p15 == 4 & p14 == 4 & p13 == 4 & p12 == 4 & p11 == 4) total = total + 40;
                if (p15 == 5 & p14 == 5 & p13 == 5 & p12 == 5 & p11 == 5) total = total + 50;

                credits = credits + total;
                label3.Text = "Win: " + total.ToString();
                label1.Text = "Credits: " + credits.ToString();
            }
        }
    }
}
