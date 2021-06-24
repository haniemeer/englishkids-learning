
namespace englishkids_APP
{
    partial class wordlearningshapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordlearningshapes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shape_flpic = new System.Windows.Forms.PictureBox();
            this.next_shape = new Bunifu.Framework.UI.BunifuImageButton();
            this.pervi_shape = new Bunifu.Framework.UI.BunifuImageButton();
            this.back_pi3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape_flpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_shape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pervi_shape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pi3)).BeginInit();
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
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // shape_flpic
            // 
            this.shape_flpic.Location = new System.Drawing.Point(155, 32);
            this.shape_flpic.Name = "shape_flpic";
            this.shape_flpic.Size = new System.Drawing.Size(712, 494);
            this.shape_flpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shape_flpic.TabIndex = 19;
            this.shape_flpic.TabStop = false;
            this.shape_flpic.Click += new System.EventHandler(this.shape_flpic_Click);
            // 
            // next_shape
            // 
            this.next_shape.Image = ((System.Drawing.Image)(resources.GetObject("next_shape.Image")));
            this.next_shape.ImageActive = null;
            this.next_shape.Location = new System.Drawing.Point(902, 269);
            this.next_shape.Name = "next_shape";
            this.next_shape.Size = new System.Drawing.Size(93, 84);
            this.next_shape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_shape.TabIndex = 18;
            this.next_shape.TabStop = false;
            this.next_shape.Zoom = 10;
            this.next_shape.Click += new System.EventHandler(this.next_shape_Click);
            // 
            // pervi_shape
            // 
            this.pervi_shape.Image = ((System.Drawing.Image)(resources.GetObject("pervi_shape.Image")));
            this.pervi_shape.ImageActive = null;
            this.pervi_shape.Location = new System.Drawing.Point(12, 269);
            this.pervi_shape.Name = "pervi_shape";
            this.pervi_shape.Size = new System.Drawing.Size(92, 84);
            this.pervi_shape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pervi_shape.TabIndex = 17;
            this.pervi_shape.TabStop = false;
            this.pervi_shape.Zoom = 10;
            this.pervi_shape.Click += new System.EventHandler(this.pervi_shape_Click);
            // 
            // back_pi3
            // 
            this.back_pi3.BackColor = System.Drawing.Color.Transparent;
            this.back_pi3.Image = ((System.Drawing.Image)(resources.GetObject("back_pi3.Image")));
            this.back_pi3.Location = new System.Drawing.Point(8, -4);
            this.back_pi3.Name = "back_pi3";
            this.back_pi3.Size = new System.Drawing.Size(91, 55);
            this.back_pi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pi3.TabIndex = 16;
            this.back_pi3.TabStop = false;
            this.back_pi3.Click += new System.EventHandler(this.back_pi3_Click);
            // 
            // wordlearningshapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1003, 650);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.shape_flpic);
            this.Controls.Add(this.next_shape);
            this.Controls.Add(this.pervi_shape);
            this.Controls.Add(this.back_pi3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wordlearningshapes";
            this.Text = "wordlearningshapes";
            this.Load += new System.EventHandler(this.wordlearningshapes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape_flpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_shape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pervi_shape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pi3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox shape_flpic;
        private Bunifu.Framework.UI.BunifuImageButton next_shape;
        private Bunifu.Framework.UI.BunifuImageButton pervi_shape;
        private System.Windows.Forms.PictureBox back_pi3;
    }
}