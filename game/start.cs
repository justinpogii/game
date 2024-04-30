using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace game
{
    public partial class start : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
       
        int second;
        int useranswer;
        int answer;
        int a;
        int b;
        int c;
        int d;
        Random random = new Random();
        int score = 0;
        int highscore;
        int averagepoint;
        int highpoint;
       







        public start()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            
            if (int.TryParse(label1.Text, out c)) ;

            if (int.TryParse(label3.Text, out d)) ;

            answer = a * b;

            a = random.Next(0, 11);
            label1.Text = a.ToString();

           b = random.Next(0, 11);
            label3.Text = b.ToString();

        }

        private void start_Load(object sender, EventArgs e)
        {

            second = 10;
            countdown.Start();

            


           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button1.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            var back = new Form1();
            back.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button4.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button8.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Useranswer.Clear();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            
            label6.Text = second--.ToString();

            if(second < 0)
            {
                countdown.Stop();
                var new3 = new Form2();
                new3.Show();
            }

           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Useranswer_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Useranswer.Text, out useranswer)) ;

            if (useranswer == answer)
            {

                second = 10;
                a = random.Next(0, 11);
                label1.Text = a.ToString();

                b = random.Next(0, 11);
                label3.Text = b.ToString();

                score++;

                scorelabel.Text = score.ToString();
                

               

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {


            Useranswer.Clear();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
