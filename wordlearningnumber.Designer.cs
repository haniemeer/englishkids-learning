
namespace englishkids_APP
{
    partial class wordlearningnumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordlearningnumber));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.num_flpic = new System.Windows.Forms.PictureBox();
            this.next_num = new Bunifu.Framework.UI.BunifuImageButton();
            this.pervi_num = new Bunifu.Framework.UI.BunifuImageButton();
            this.back_pi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_flpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pervi_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pi)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(296, 532);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(424, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // num_flpic
            // 
            this.num_flpic.Location = new System.Drawing.Point(155, 32);
            this.num_flpic.Name = "num_flpic";
            this.num_flpic.Size = new System.Drawing.Size(712, 494);
            this.num_flpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.num_flpic.TabIndex = 9;
            this.num_flpic.TabStop = false;
            // 
            // next_num
            // 
            this.next_num.Image = ((System.Drawing.Image)(resources.GetObject("next_num.Image")));
            this.next_num.ImageActive = null;
            this.next_num.Location = new System.Drawing.Point(902, 269);
            this.next_num.Name = "next_num";
            this.next_num.Size = new System.Drawing.Size(93, 84);
            this.next_num.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_num.TabIndex = 8;
            this.next_num.TabStop = false;
            this.next_num.Zoom = 10;
            this.next_num.Click += new System.EventHandler(this.next_num_Click);
            // 
            // pervi_num
            // 
            this.pervi_num.Image = ((System.Drawing.Image)(resources.GetObject("pervi_num.Image")));
            this.pervi_num.ImageActive = null;
            this.pervi_num.Location = new System.Drawing.Point(33, 269);
            this.pervi_num.Name = "pervi_num";
            this.pervi_num.Size = new System.Drawing.Size(92, 84);
            this.pervi_num.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pervi_num.TabIndex = 7;
            this.pervi_num.TabStop = false;
            this.pervi_num.Zoom = 10;
            this.pervi_num.Click += new System.EventHandler(this.pervi_num_Click);
            // 
            // back_pi
            // 
            this.back_pi.BackColor = System.Drawing.Color.Transparent;
            this.back_pi.Image = ((System.Drawing.Image)(resources.GetObject("back_pi.Image")));
            this.back_pi.Location = new System.Drawing.Point(8, -4);
            this.back_pi.Name = "back_pi";
            this.back_pi.Size = new System.Drawing.Size(91, 55);
            this.back_pi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pi.TabIndex = 6;
            this.back_pi.TabStop = false;
            this.back_pi.Click += new System.EventHandler(this.back_pi_Click);
            // 
            // wordlearningnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1003, 650);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.num_flpic);
            this.Controls.Add(this.next_num);
            this.Controls.Add(this.pervi_num);
            this.Controls.Add(this.back_pi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wordlearningnumber";
            this.Text = "wordlearningnumber";
            this.Load += new System.EventHandler(this.wordlearningnumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_flpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pervi_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox num_flpic;
        private Bunifu.Framework.UI.BunifuImageButton next_num;
        private Bunifu.Framework.UI.BunifuImageButton pervi_num;
        private System.Windows.Forms.PictureBox back_pi;
    }
}