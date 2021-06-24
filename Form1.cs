using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace englishkids_APP
{
    public partial class Form1 : Form
    {
        
        Imyloginrepository login;
        int Counter = 0;
        public Form1()
        {
            InitializeComponent();
            login = new loginrepository();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region login exit 
            //pors o joo az user babate khoorooj
            if (MessageBox.Show("Are you sure to Exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = "rainbow.wav";
            splayer.PlayLooping();
            btn_mute.Visible = false;
            btn_play.Visible = true;

            #region timer label statrter
            timer1.Start();
            timer1.Enabled = true;
            #endregion

            #region visible login
            //unvisible panel login
            plogin.Visible = false;

            #endregion




            #region visible labele
            //visible labele When loaded form1
            lbluser.Visible = false;
            lblpass.Visible = false;
            #endregion


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            #region Show sidebar

            plogin.Visible = false;
            bunifuTransition1.Show(plogin);
            btmlogin.Visible = false;
            label2.Visible = false;
            #endregion


        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            #region Hide the panel
            //Hide the side panel
            plogin.Visible = false;
            btmlogin.Visible = true;
            label2.Visible = true;
            #endregion


        }

        

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            # region Password counter
            //counter
            Counter++;
            #endregion

            #region Check the counting loop and control the user's password
            //Check the counting loop and control
            if (Counter != 3)
            {
                //Checking the username and password in the database
                DataTable dt = login.user(txtusername.Text, txtpassword.Text);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("successful welcome back", "welcome");

                    //Hide the first form and show the original form
                    this.Hide();
                    Form2 frmm = new Form2();
                    frmm.ShowDialog();

                }
                else
                {
                    //Show the label if the password and username are wrong
                    lbluser.Visible = true;
                    lblpass.Visible = true;

                }
            }
            else
            {
                //Exit the program due to entering too much password
                MessageBox.Show("You entered too much password!");
                Application.Exit();
            }
            #endregion



            #region Log in to the admin panel
            //admin panel
            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                #region Login to the admin panel
                //Show admin form
                adminform frmadmin = new adminform();
                frmadmin.ShowDialog();
                #endregion
            }

            #endregion




        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


            #region Display the register form
            //Show the registry page
            registerform reg = new registerform();
            reg.ShowDialog();
            #endregion



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            #region login exit 
            //pors o joo az user babate khoorooj
            if (MessageBox.Show("Are you sure to Exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region welcometxt effects
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
           welcometxt.ForeColor = Color.FromArgb(A, R, G, B);
            #endregion
        }

        

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = "rainbow.wav";
            splayer.Stop();
            btn_mute.Visible = true;
            btn_play.Visible = false;
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = "rainbow.wav";
            splayer.PlayLooping();
            btn_mute.Visible = false;
            btn_play.Visible = true;
        }

        private void txtusername_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
