using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shootgame_harmanjit
{
    public partial class Form1 : Form
    {

        setting Setting_obj = null;

        
        public Form1()
        {
            InitializeComponent();
            Setting_obj=new setting();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            pictureBox1.Image = shootgame_harmanjit.Properties.Resources.loadgun;
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading the Bullet in the GUn");
            button2.Enabled = false;

            button3.Enabled =true;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = shootgame_harmanjit.Properties.Resources.spingun4;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = shootgame_harmanjit.Properties.Resources.shoot1;

            if (Setting_obj.fire() == 0) {
                MessageBox.Show("Bullets are finished Now");
                button4.Enabled = false;

            }


        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Setting_obj.shootaway()==0) {
                MessageBox.Show("2nd chance is also over");
                button6.Enabled = true;
                button5.Enabled = false;

            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button1.Enabled = true;
            Setting_obj = new setting();
        }
        
    }
}
