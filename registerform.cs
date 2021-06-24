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
    public partial class registerform : Form
    {
        Imyloginrepository register;
        public registerform()
        {
            InitializeComponent();
            register = new loginrepository();
        }

        private void label4_Click(object sender, EventArgs e)
        {


            #region Open the register form
            registerform frmregister = new registerform();
            frmregister.ShowDialog();
            #endregion



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }


        #region  Method of checking the empty text boxes
        //Method of checking 
        public bool isvalid()
        {
            bool issco = true;
            if (txtfirst.Text == "")
            {
                lblfirst.Visible = true;
                issco = false;
            }
            if (txtlast.Text == "")
            {
                lbllast.Visible = true;
                issco = false;
            }
            if (txtpass.Text == "")
            {
                lblpass.Visible = true;
                issco = false;

            }
            if (txtcofirm.Text == "")
            {
                lblconfrime.Visible = true;
                issco = false;
            }
            return issco;
        }
        #endregion


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {



            #region Add to database
            //Add in database and compare condition
            if (isvalid())
            {
                string user = txtfirst.Text + txtlast.Text;
                bool analogy = register.insert(user, txtpass.Text);
                if (analogy == true)
                {
                    MessageBox.Show("You have successfully joined");
                    Form1 form1 = new Form1();
                    form1.Hide();
                    this.Hide();
                    Form2 frm = new Form2();
                    frm.ShowDialog();
                    
                  
                    
                    
                }
                else
                {
                    MessageBox.Show("We have not confirmed your membership");
                }

            }

            #endregion




        }

        private void registerform_Load(object sender, EventArgs e)
        {



            #region Hide labels when the form is loading
            //Hide labels
            lblfirst.Visible = false;
            lbllast.Visible = false;
            lblpass.Visible = false;
            lblconfrime.Visible = false;
            #endregion




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            #region close the registerform
            this.Close();
            #endregion
        }
    }

}
