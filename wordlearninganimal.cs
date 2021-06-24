﻿using System;
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
    public partial class wordlearninganimal : Form
    {
        Imycourserepository course;

        public int parentId = 0;
        public int flashcartId = 0;
        public wordlearninganimal()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void back_pi4_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Visible = true;
            #endregion
        }

        private void wordlearninganimal_Load(object sender, EventArgs e)
        {
           pervi_animal.Enabled = false;
            parentId = Form2.parent_id;
            var courses = course.course(parentId, 69);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
            animal_flpic.Image = Image.FromFile("image\\animal\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\animal\\" + audio);
            player.Play();
        }
        public void clickBtn(int flashId)
        {
            if (flashId == 69)
            {
               pervi_animal.Enabled = false;
            }
            else
            {
               pervi_animal.Enabled = true;
            }

            if (flashId == 104)
            {
                next_animal.Enabled = false;
            }
            else
            {
                next_animal.Enabled = true;
            }

            var courses = course.course(parentId, flashId);
            flashcartId = int.Parse(courses.Rows[0][0].ToString());
            var parent = courses.Rows[0][1].ToString();
            var title = courses.Rows[0][2].ToString();
            var audio = courses.Rows[0][3].ToString();
            var img1 = courses.Rows[0][4].ToString();
            var img2 = courses.Rows[0][5].ToString();
           animal_flpic.Image = Image.FromFile("image\\animal\\" + img2);
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer("audio\\animal\\" + audio);
            player.Play();
        }

        private void pervi_animal_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player;
            player = new System.Media.SoundPlayer(@"audio\animal");
            player.Stop();
            clickBtn(flashcartId - 1);
        }

        private void next_animal_Click(object sender, EventArgs e)
        {
            clickBtn(flashcartId + 1);
        }
    }
}
