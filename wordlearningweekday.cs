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
    public partial class wordlearningweekday : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;
        public wordlearningweekday()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void back_pi6_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            #endregion
        }

        private void next_weekday_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }

        private void pervi_weekday_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\day");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void wordlearningweekday_Load(object sender, EventArgs e)
        {
            pervi_weekday.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 117);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            weekday_flpic.Image = Image.FromFile("image\\days\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\day\\" + audio);
            player.Play();
        }
        public void clickBtn(int flashId)
        {
            if (flashId == 117)
            {
                pervi_weekday.Enabled = false;
            }
            else
            {
                pervi_weekday.Enabled = true;
            }

            if (flashId == 123)
            {
               next_weekday.Enabled = false;
            }
            else
            {
               pervi_weekday.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            weekday_flpic.Image = Image.FromFile("image\\days\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\day\\" + audio);
            player.Play();
        }

        private void weekday_flpic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }

