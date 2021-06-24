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
    public partial class wordlearningshapes : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;
        public wordlearningshapes()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void back_pi3_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            #endregion
        }

        private void pervi_shape_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\shape");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void next_shape_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }

        private void wordlearningshapes_Load(object sender, EventArgs e)
        {
           pervi_shape.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 59);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
           shape_flpic.Image = Image.FromFile("image\\shapes\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\shape\\" + audio);
            player.Play();
        }
        public void clickBtn(int flashId)
        {
            if (flashId == 59)
            {
                pervi_shape.Enabled = false;
            }
            else
            {
                pervi_shape.Enabled = true;
            }

            if (flashId == 68)
            {
                next_shape.Enabled = false;
            }
            else
            {
               next_shape.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            shape_flpic.Image = Image.FromFile("image\\shapes\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\shape\\" + audio);
            player.Play();
        }

        private void shape_flpic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }

