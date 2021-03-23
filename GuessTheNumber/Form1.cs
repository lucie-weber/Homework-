using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int ainum;
        int i = 1;
        int j = 100;
        int mid =50;
        bool playerturn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManageAccess(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            ainum = rnd.Next(0, 101);
            txtplayernum.Text = "";
           //write with a variable mid

            // button2.Click +=

            //case mec e 
            //function to change the color 
            // case poqr e button 
            // tommorow do hackerrank finally no lol fak u 
            // 

        }

        public void TurnChange()
        {
            if (playerturn)
            {
                btnbigger.Enabled = false;
                btnsmaller.Enabled = false;
                btnrightnumber.Enabled = false;
                btncheck.Enabled = true;
                lblai.BackColor = Color.White;
                lblplayer.BackColor = Color.FromArgb(192, 255, 192);
                playerturn = false;
            }
            else
            {
                btnbigger.Enabled = true;
                btnsmaller.Enabled =true;
                btnrightnumber.Enabled = true;
                btncheck.Enabled = false;
                lblai.BackColor = Color.FromArgb(192, 255, 192);
                lblplayer.BackColor = Color.White;
                playerturn = true;

            }
            lblAiQuestion.Text = $"Is your number smaller or bigger than {mid}?";
        }

        public void ManageAccess(bool open)
        {
            btnbigger.Enabled = open;
            btnsmaller.Enabled = open;
            btnrightnumber.Enabled = open;
            

        }
        private void btncheck_Click(object sender, EventArgs e)
        {
            int num = default;
            
            try
            {
                 num = Convert.ToInt32(txtplayernum.Text);

            }
            catch 
            {
                lbAiSpeech.Text = "Hey, you have to write a number !";
                return;
            }
            ManageAccess(true);

            //better check logic 
            //check function
            if (num > ainum)
            {
                lbAiSpeech.Text = "My number is smaller!";
            }
            else if (num < ainum)
            {
                lbAiSpeech.Text = "My number is bigger!";

            }
            else
            {
                lbAiSpeech.Text = "Wow, right number, congrats :)";
                ManageAccess(false);

            }
            TurnChange();


            //user thinks of a number
        }
     

        private void btnbigger_Click(object sender, EventArgs e)
        {

            i = mid;
            mid = (i + j) / 2;         
            TurnChange();

        }

        private void btnsmaller_Click(object sender, EventArgs e)
        {
            j = mid;
            mid = (i + j) / 2;
            
            TurnChange();

        }

        private void btnrightnumber_Click(object sender, EventArgs e)
        {
            lblAiQuestion.Text = "Yay, I won ! Try again ))";
            ManageAccess(false);

        }
    }
}
