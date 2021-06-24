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
    public partial class wordlearningsport : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;
        public wordlearningsport()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void wordlearningsport_Load(object sender, EventArgs e)
        {
            pervi_sport.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 160);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            sport_flpic.Image = Image.FromFile("image\\sport\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\sport\\" + audio);
            player.Play();
        }
        public void clickBtn(int flashId)
        {
            if (flashId == 160)
            {
               pervi_sport.Enabled = false;
            }
            else
            {
                pervi_sport.Enabled = true;
            }

            if (flashId == 172)
            {
                next_sport.Enabled = false;
            }
            else
            {
               next_sport.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            sport_flpic.Image = Image.FromFile("image\\sport\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\sport\\" + audio);
            player.Play();
        }

        private void back_pi10_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            #endregion
        }

        private void pervi_sport_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\sport");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void next_sport_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }
    }
}
