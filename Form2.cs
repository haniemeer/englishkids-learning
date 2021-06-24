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
    
    public partial class Form2 : Form
    {
        public static int parent_id = 0;

        Imycourserepository course;
        public Form2()
        {
            InitializeComponent();
            course = new Courserepository();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            #region back to main form
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Visible = true;
            #endregion
        }

        private void alphabet_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("alphabet");
            this.Hide();
            wordlearning learnfrm = new wordlearning();
            learnfrm.ShowDialog();
        }

        private void number_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("numbers");
            this.Hide();
            wordlearningnumber learnnum = new wordlearningnumber();
            learnnum.ShowDialog();
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("colors");
            this.Hide();
            wordlearningcolor learncolor = new wordlearningcolor();
            learncolor.ShowDialog();
        }

        private void shape_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("shapes");
            this.Hide();
            wordlearningshapes learnshape = new wordlearningshapes();
            learnshape.ShowDialog();
        }

        private void animal_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("animal");
            this.Hide();
            wordlearninganimal learnanimal = new wordlearninganimal();
            learnanimal.ShowDialog();
        }

        private void month_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("months");
            this.Hide();
            wordlearningmonths learnmonth = new wordlearningmonths();
           learnmonth.ShowDialog();
        }

        private void weekday_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("days");
            this.Hide();
            wordlearningweekday learnweekday = new wordlearningweekday();
            learnweekday.ShowDialog();
        }

        private void food_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("foods");
            this.Hide();
            wordlearningfoods learnfood = new wordlearningfoods();
          learnfood.ShowDialog();
        }

        private void fruit_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("fruits");
            this.Hide();
            wordlearningfruitcs learnfruit = new wordlearningfruitcs();
            learnfruit.ShowDialog();
        }

        private void sport_btn_Click(object sender, EventArgs e)
        {
            parent_id = course.selectParentId("sporst");
            this.Hide();
            wordlearningsport learnsport = new wordlearningsport();
            learnsport.ShowDialog();
        }
    }
}
