using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppassignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello world!!");
            Button b = new Button();//Reference to the byutton
            b.Text = "Click Me!";//Text implemted as "clik me" on the button appearence
            b.Size = new Size(100, 50);//size mentained for button
            b.Location = new Point(250, 200);//point located on the button created
            this.Controls.Add(b);//contolling mechanism of button shoould go the center


            //show the message
            //  b.Click += new EventHandler(button1_Click1);

            //Delegate with Anonymous method
            b.Click += delegate (object sender1, EventArgs e1)///we are just passing paramters here
            {
                MessageBox.Show("This is printing again");
                //   MessageBox.Show("hii");


            };




            //Method creation
            //private void button1_Click1(object sender1,EventArgs e1)
            //{
            //    MessageBox.Show("This is printing again");
            //}

        }
    }
}
