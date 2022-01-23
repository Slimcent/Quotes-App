using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wise_Quotes_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

            InitializeComponent();
        }

        int x = 0;
        int y = 0;

        bool drag = false;

        int quotesno;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblquotes_MouseDown(object sender, MouseEventArgs e)
        {

            //get original position of cursor on mouseDown
            x = e.X;
            y = e.Y;
            drag = true;
        }

        private void lblquotes_MouseMove(object sender, MouseEventArgs e)
        {

            if (drag)
            {
                // get new position
                lblquotes.Top += e.Y - y;
                lblquotes.Left += e.X - x;

            }
        }

        private void lblquotes_MouseUp(object sender, MouseEventArgs e)
        {

            drag = false;
        }

        private void qoutes_timer_Tick(object sender, EventArgs e)
        {

            quotesno = quotesno + 1;
            if (quotesno > 10) quotesno = 1;

            switch (quotesno)
            {
                case 1:

                    lblquotes.Text = "Until something changes inside of you to be a better person, You will always be the way you are";
                    break;
                case 2:

                    lblquotes.Text = "The slave that loves his chains will forever remain a slave";
                    break;
                case 3:

                    lblquotes.Text = "Until it burns in you to make a difference, nothing will change";
                    break;
                case 4:

                    lblquotes.Text = "Life will always be a mystery";
                    break;

                default:


                    lblquotes.Text = "Better late than never";
                    break;
            }
        }
    }
}
