
namespace englishkids_APP
{
    partial class wordlearningmonths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordlearningmonths));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.months_flpic = new System.Windows.Forms.PictureBox();
            this.next_months = new Bunifu.Framework.UI.BunifuImageButton();
            this.pervi_months = new Bunifu.Framework.UI.BunifuImageButton();
            this.back_pi5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.months_flpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pervi_months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pi5)).BeginInit();
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
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // months_flpic
            // 
            this.months_flpic.Location = new System.Drawing.Point(155, 32);
            this.months_flpic.Name = "months_flpic";
            this.months_flpic.Size = new System.Drawing.Size(712, 494);
            this.months_flpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.months_flpic.TabIndex = 29;
            this.months_flpic.TabStop = false;
            this.months_flpic.Click += new System.EventHandler(this.animal_flpic_Click);
            // 
            // next_months
            // 
            this.next_months.Image = ((System.Drawing.Image)(resources.GetObject("next_months.Image")));
            this.next_months.ImageActive = null;
            this.next_months.Location = new System.Drawing.Point(902, 269);
            this.next_months.Name = "next_months";
            this.next_months.Size = new System.Drawing.Size(93, 84);
            this.next_months.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_months.TabIndex = 28;
            this.next_months.TabStop = false;
            this.next_months.Zoom = 10;
            this.next_months.Click += new System.EventHandler(this.next_animal_Click);
            // 
            // pervi_months
            // 
            this.pervi_months.Image = ((System.Drawing.Image)(resources.GetObject("pervi_months.Image")));
            this.pervi_months.ImageActive = null;
            this.pervi_months.Location = new System.Drawing.Point(12, 269);
            this.pervi_months.Name = "pervi_months";
            this.pervi_months.Size = new System.Drawing.Size(92, 84);
            this.pervi_months.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pervi_months.TabIndex = 27;
            this.pervi_months.TabStop = false;
            this.pervi_months.Zoom = 10;
            this.pervi_months.Click += new System.EventHandler(this.pervi_animal_Click);
            // 
            // back_pi5
            // 
            this.back_pi5.BackColor = System.Drawing.Color.Transparent;
            this.back_pi5.Image = ((System.Drawing.Image)(resources.GetObject("back_pi5.Image")));
            this.back_pi5.Location = new System.Drawing.Point(8, -4);
            this.back_pi5.Name = "back_pi5";
            this.back_pi5.Size = new System.Drawing.Size(91, 55);
            this.back_pi5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pi5.TabIndex = 26;
            this.back_pi5.TabStop = false;
            this.back_pi5.Click += new System.EventHandler(this.back_pi4_Click);
            // 
            // wordlearningmonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1003, 650);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.months_flpic);
            this.Controls.Add(this.next_months);
            this.Controls.Add(this.pervi_months);
            this.Controls.Add(this.back_pi5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wordlearningmonths";
            this.Text = "wordlearningmonths";
            this.Load += new System.EventHandler(this.wordlearningmonths_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.months_flpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pervi_months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pi5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox months_flpic;
        private Bunifu.Framework.UI.BunifuImageButton next_months;
        private Bunifu.Framework.UI.BunifuImageButton pervi_months;
        private System.Windows.Forms.PictureBox back_pi5;
    }
}