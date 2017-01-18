using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KidsXl
{
    public partial class Form1 : Form
    {
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScore.Text = score.ToString();
            nextQuestion();
            
        }

        public void setOp(string s)
        {
            lblOp.Text = s;
        }

        public void nextQuestion()
        {
            int num1=0, num2=0,ch;
            Random rnd = new Random();

            
            if (lblOp.Text == "*")
            {
                num1 = rnd.Next() % 10 + 1;
                num2 = rnd.Next() % 10 + 1;
            }
            else if (lblOp.Text == "/")
            {
                do
                {
                    num1 = rnd.Next() % 20 + 1;
                    num2 = rnd.Next() % 20 + 1;
                } while ((num1 % num2 != 0) || num2>num1);
            }
            else
            {
                do
                {
                    num1 = rnd.Next() % 20 + 1;
                    num2 = rnd.Next() % 20 + 1;
                } while (num2 > num1);
            }

            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();

            //chose a button to be the correct answer
            ch = rnd.Next() % 3 + 1;
            switch (ch)
            {
                case 1:
                    if (lblOp.Text == "+")
                        btn1.Text = (num1 + num2).ToString();
                    else if (lblOp.Text == "-")
                        btn1.Text = (num1 - num2).ToString();
                    else if (lblOp.Text == "*")
                        btn1.Text = (num1 * num2).ToString();
                    else if (lblOp.Text == "/")
                        btn1.Text = (num1 / num2).ToString();
                    break;

                case 2:
                    if (lblOp.Text == "+")
                        btn2.Text = (num1 + num2).ToString();
                    else if(lblOp.Text == "-")
                        btn2.Text = (num1 - num2).ToString();
                    else if (lblOp.Text == "*")
                        btn2.Text = (num1 * num2).ToString();
                    else if (lblOp.Text == "/")
                        btn2.Text = (num1 / num2).ToString();
                    break;

                case 3:
                    if (lblOp.Text == "+")
                        btn3.Text = (num1 + num2).ToString();
                    else if (lblOp.Text == "-")
                        btn3.Text = (num1 - num2).ToString();
                    else if (lblOp.Text == "*")
                        btn3.Text = (num1 * num2).ToString();
                    else if (lblOp.Text == "/")
                        btn3.Text = (num1 / num2).ToString();
                    break;
            }

            if (lblOp.Text == "*")
            {
                if (ch != 1)
                    btn1.Text = (rnd.Next() % 10 + 1).ToString();
                if (ch != 2)
                    btn2.Text = (rnd.Next() % 10 + 1).ToString();
                if (ch != 3)
                    btn3.Text = (rnd.Next() % 10 + 1).ToString();
            }
            else
            {
                if (ch != 1)
                    btn1.Text = (rnd.Next() % 20 + 1).ToString();
                if (ch != 2)
                    btn2.Text = (rnd.Next() % 20 + 1).ToString();
                if (ch != 3)
                    btn3.Text = (rnd.Next() % 20 + 1).ToString();
            }

            lblWrong.Visible = false;
        }

        public bool isTrue(int x)
        {
            int num1 = int.Parse(lblNum1.Text);
            int num2 = int.Parse(lblNum2.Text);

            if (lblOp.Text == "+")
            {
                if (x == (num1 + num2))
                    return true;
            }
            else if (lblOp.Text == "-")
            {
                if (x == (num1 - num2))
                    return true;
            }
            else if (lblOp.Text == "*")
            {
                if (x == (num1 * num2))
                    return true;
            }
            else if (lblOp.Text == "/")
            {
                if (x == (num1 / num2))
                    return true;
            }

            return false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isTrue(int.Parse(btn1.Text)))
            {
                lblScore.Text = (++score).ToString();
                nextQuestion();
            }
            else
            {
                lblWrong.Visible = true;
                if (score > 0)
                    lblScore.Text = (--score).ToString();
                else if (score == 0)
                {
                    MessageBox.Show("You lose!");
                    Close();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isTrue(int.Parse(btn2.Text)))
            {
                lblScore.Text = (++score).ToString();
                nextQuestion();
            }
            else
            {
                lblWrong.Visible = true;
                if (score > 0)
                    lblScore.Text = (--score).ToString();
                else if (score == 0)
                {
                    MessageBox.Show("You lose!");
                    Close();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isTrue(int.Parse(btn3.Text)))
            {
                lblScore.Text = (++score).ToString();
                nextQuestion();
            }
            else
            {
                lblWrong.Visible = true;
                if (score > 0)
                    lblScore.Text = (--score).ToString();
                else if (score == 0)
                {
                    MessageBox.Show("You lose!");
                    Close();
                }
            }
        }

        private void lblScore_TextChanged(object sender, EventArgs e)
        {
            if (score == 5 && star1.Visible == false)
            {
                star1.Visible = true;
                MessageBox.Show("Good Job..you got a star!");
            }
            else if (score == 10 && star2.Visible == false)
            {
                star2.Visible = true;
                MessageBox.Show("You got a second star wohoooo!");
            }
            else if (score == 15 && star3.Visible == false)
            {
                star3.Visible = true;
                MessageBox.Show("You win");
                Close();
            }
        }

    }
}
