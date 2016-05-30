using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

#region Redundant

		private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //Step 1
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        //Step 2
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Step 3
        private void label7_Click(object sender, EventArgs e)
        {

        }
        //Step 4
        private void label8_Click(object sender, EventArgs e)
        {

        }
#endregion Redundant
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float rotatation = 0.0f;
            rotatation = (float)numericUpDown1.Value;

            //this sucks horribly but I cant be bothered
            //closest is 0
            if((rotatation < 45) || (rotatation >= 315) )
            {
                Step0.Text = "You dont need this step, good for you!";
                if(rotatation >= 315)
                {
                    rotatation = -(360 - rotatation);
                }
            }
                //closest is 90
            else if((rotatation >= 45) && (rotatation < 134))
            {
                Step0.Text = "Rotate 90 degrees normally.";
                rotatation = -(90 - rotatation);
                
            }
                //closest is 180
            else if ((rotatation >= 135) && (rotatation < 224))
            {
                Step0.Text = "Rotate 180 degrees normally.";
                rotatation = -(180 - rotatation);
            }
                // closest is 270
            else if ((rotatation >= 225) && (rotatation < 314))
            {
                Step0.Text = "Rotate 270 degrees normally.";
                rotatation = -(270 - rotatation);
            }
            Step0.Refresh();

            Step1.Text = rotatation.ToString(); Step1.Refresh();

            int stretch = (int)((1.0f / Math.Pow(Math.Cos(rotatation * (Math.PI / 180)), 2)) * 100);

            if( rotatation < 0)
            {
                stretch = (200 - stretch);
            }

            Step2.Text = stretch.ToString(); Step2.Refresh();

            Step3.Text = (-rotatation).ToString(); Step3.Refresh();
           
            stretch = (int)(93.2f + (1.82f * Math.Abs(rotatation)));
            
            Step4.Text = stretch.ToString(); Step4.Refresh();
        }
    }
}
