using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{ 
    //Delegate 

    public partial class Form2 : Form
    {
        TextBox result;
        List<TextBox> textBoxList = new List<TextBox>();
        public Form2()
        {
            InitializeComponent();
        }
        void btnSum(object s, EventArgs e) {
            Button b = s as Button;
            int sum = 0;
            foreach(var t in textBoxList){
                if (t.Text == "")
                    t.Text = "0";
                sum += Convert.ToInt32(t.Text);
            }
           
            result.Text = Convert.ToString(sum);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Sum inputs ";
            Button button1 = new Button();
            b.Location = new Point(250, 124);
            b.Size = new Size(130, 55);
            b.Click += new System.EventHandler(this.btnSum);
            this.Controls.Add(b);
            //textbox to show the result
            result = new TextBox();
            result.Location = new Point(250, 250);
            result.Size = new Size(100, 200);
            this.Controls.Add(result);
            
            //int x = 24, y = 38;
            for (int i = 1; i < 9; i++)
            {
                TextBox t = new TextBox();
                t.Name = t.Name + i.ToString();
                t.Size = new Size(50, 50);
                t.Margin = new Padding(5);
                // flow layout panel object
                //because you don't have to measure the position
                flowLayoutPanel1.Controls.Add(t);
                textBoxList.Add(t);

            }// end of for
            }
    }//class
    }//name space

