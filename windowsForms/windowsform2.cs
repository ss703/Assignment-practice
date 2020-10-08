using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppssignment2
{
    public partial class windows2 : Form
    {
        public windows2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();//Reference to the byutton
            b.Text = "Click Me!";//Text implemted as "clik me" on the button appearence
            b.Size = new Size(100, 50);//size mentained for button
            b.Location = new Point(250, 200);//point located on the button created
            this.Controls.Add(b);//contolling mechanism of button shoould go the center


            // show the message
            // b.Click += new EventHandler(button1_Click1);

           // Delegate with Anonymous method
            b.Click += delegate (object sender1, EventArgs e1)///we are just passing paramters here
            {
                MessageBox.Show("Programming is fun");

                };
                //b.Click += delegate (object sender2, EventArgs e2)
                //{
                //    MessageBox.Show("programming is fun");
                //};

            }
    }
    }

