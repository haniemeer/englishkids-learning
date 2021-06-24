using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace englishkids_APP
{
    public partial class wordlearning : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;
        public wordlearning()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            #endregion
        }

        private void wordlearning_Load(object sender, EventArgs e)
        {
            bunifuImageButton1.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 1);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            pictureBox2.Image = Image.FromFile("image\\alphabet\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\alphabet\\" + audio);
            player.Play();

        }


        public void clickBtn(int flashId)
        {
            if(flashId == 1)
            {
                bunifuImageButton1.Enabled = false;
            }
            else
            {
                bunifuImageButton1.Enabled = true;
            }

            if (flashId == 26)
            {
                bunifuImageButton3.Enabled = false;
            }
            else
            {
                bunifuImageButton3.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            pictureBox2.Image = Image.FromFile("image\\alphabet\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\alphabet\\" + audio);
            player.Play();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\alphabet");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
