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
    public partial class wordlearningfoods : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;
        public wordlearningfoods()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void back_pi7_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            #endregion
        }

        private void pervi_foods_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\food");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void next_foods_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }

        private void wordlearningfoods_Load(object sender, EventArgs e)
        {
            pervi_foods.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 131);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            food_flpic.Image = Image.FromFile("image\\food\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\food\\" + audio);
            player.Play();
        }
        public void clickBtn(int flashId)
        {
            if (flashId == 131)
            {
                pervi_foods.Enabled = false;
            }
            else
            {
               pervi_foods.Enabled = true;
            }

            if (flashId == 145)
            {
                next_foods.Enabled = false;
            }
            else
            {
                next_foods.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            food_flpic.Image = Image.FromFile("image\\food\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\food\\" + audio);
            player.Play();
        }

        private void food_flpic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
