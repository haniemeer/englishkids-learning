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
    public partial class wordlearningfruitcs : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;

        public wordlearningfruitcs()
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

        private void pervi_fruits_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\fruit");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void next_fruits_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }

        private void wordlearningfruitcs_Load(object sender, EventArgs e)
        {
            pervi_fruits.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 146);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            fruit_flpic.Image = Image.FromFile("image\\fruits\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\fruit\\" + audio);
            player.Play();
        }
        public void clickBtn(int flashId)
        {
            if (flashId == 146)
            {
                pervi_fruits.Enabled = false;
            }
            else
            {
                pervi_fruits.Enabled = true;
            }

            if (flashId == 153)
            {
                next_fruits.Enabled = false;
            }
            else
            {
                next_fruits.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            fruit_flpic.Image = Image.FromFile("image\\fruits\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\fruit\\" + audio);
            player.Play();
        }
    }
}

