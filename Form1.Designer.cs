
namespace englishkids_APP
{
    partial class Form1
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.welcometxt = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btmlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbluser = new System.Windows.Forms.Label();
            this.plogin = new System.Windows.Forms.Panel();
            this.lblpass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.plogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mute)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this;
            // 
            // welcometxt
            // 
            this.welcometxt.AutoSize = true;
            this.welcometxt.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.welcometxt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.welcometxt.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(26)))));
            this.welcometxt.Location = new System.Drawing.Point(13, 75);
            this.welcometxt.Name = "welcometxt";
            this.welcometxt.Size = new System.Drawing.Size(509, 43);
            this.welcometxt.TabIndex = 1;
            this.welcometxt.Text = "Welcome to the English kids";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btmlogin
            // 
            this.btmlogin.Active = false;
            this.btmlogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btmlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btmlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmlogin.BorderRadius = 0;
            this.btmlogin.ButtonText = "login to App";
            this.btmlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btmlogin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btmlogin.DisabledColor = System.Drawing.Color.Gray;
            this.btmlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btmlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btmlogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btmlogin.Iconimage")));
            this.btmlogin.Iconimage_right = null;
            this.btmlogin.Iconimage_right_Selected = null;
            this.btmlogin.Iconimage_Selected = null;
            this.btmlogin.IconMarginLeft = 0;
            this.btmlogin.IconMarginRight = 0;
            this.btmlogin.IconRightVisible = true;
            this.btmlogin.IconRightZoom = 0D;
            this.btmlogin.IconVisible = true;
            this.btmlogin.IconZoom = 90D;
            this.btmlogin.IsTab = false;
            this.btmlogin.Location = new System.Drawing.Point(769, 230);
            this.btmlogin.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btmlogin.Name = "btmlogin";
            this.btmlogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btmlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btmlogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btmlogin.selected = false;
            this.btmlogin.Size = new System.Drawing.Size(212, 64);
            this.btmlogin.TabIndex = 3;
            this.btmlogin.Text = "login to App";
            this.btmlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmlogin.Textcolor = System.Drawing.Color.White;
            this.btmlogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmlogin.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.btmlogin;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(799, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click this Button";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 2000;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1157, 5);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(105, 94);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(164, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username:";
            // 
            // txtusername
            // 
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.SystemColors.Control;
            this.txtusername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtusername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtusername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.HintForeColor = System.Drawing.Color.Silver;
            this.txtusername.HintText = "enter username";
            this.txtusername.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtusername.isPassword = false;
            this.txtusername.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtusername.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtusername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtusername.LineThickness = 2;
            this.txtusername.Location = new System.Drawing.Point(168, 304);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(240, 33);
            this.txtusername.TabIndex = 5;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.OnValueChanged += new System.EventHandler(this.txtusername_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(163, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "PassWord:";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(245, 75);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(124, 124);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 8;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "let me in !";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(64, 502);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(175, 58);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "let me in !";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // txtpassword
            // 
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtpassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtpassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.Silver;
            this.txtpassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtpassword.HintText = "....";
            this.txtpassword.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtpassword.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtpassword.LineThickness = 2;
            this.txtpassword.Location = new System.Drawing.Point(168, 420);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(240, 33);
            this.txtpassword.TabIndex = 12;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "register !";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(309, 502);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(175, 58);
            this.bunifuFlatButton2.TabIndex = 13;
            this.bunifuFlatButton2.Text = "register !";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Red;
            this.lbluser.Location = new System.Drawing.Point(177, 341);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(175, 20);
            this.lbluser.TabIndex = 14;
            this.lbluser.Text = "Username is incorrect";
            // 
            // plogin
            // 
            this.plogin.BackgroundImage = global::englishkids_APP.Properties.Resources.back;
            this.plogin.Controls.Add(this.lblpass);
            this.plogin.Controls.Add(this.lbluser);
            this.plogin.Controls.Add(this.bunifuFlatButton2);
            this.plogin.Controls.Add(this.txtpassword);
            this.plogin.Controls.Add(this.bunifuFlatButton1);
            this.plogin.Controls.Add(this.bunifuPictureBox1);
            this.plogin.Controls.Add(this.label3);
            this.plogin.Controls.Add(this.txtusername);
            this.plogin.Controls.Add(this.label4);
            this.plogin.Controls.Add(this.pictureBox2);
            this.plogin.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.plogin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.plogin.Location = new System.Drawing.Point(-9, -1);
            this.plogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plogin.Name = "plogin";
            this.plogin.Size = new System.Drawing.Size(550, 697);
            this.plogin.TabIndex = 5;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblpass, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Red;
            this.lblpass.Location = new System.Drawing.Point(177, 458);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(170, 20);
            this.lblpass.TabIndex = 15;
            this.lblpass.Text = "password is incorrect";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 568);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_play, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageActive = null;
            this.btn_play.Location = new System.Drawing.Point(1222, 631);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 40);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 17;
            this.btn_play.TabStop = false;
            this.btn_play.Zoom = 10;
            this.btn_play.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btn_mute
            // 
            this.btn_mute.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_mute, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_mute.Image = ((System.Drawing.Image)(resources.GetObject("btn_mute.Image")));
            this.btn_mute.ImageActive = null;
            this.btn_mute.Location = new System.Drawing.Point(1223, 631);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(40, 40);
            this.btn_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mute.TabIndex = 18;
            this.btn_mute.TabStop = false;
            this.btn_mute.Zoom = 10;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.bunifuFlatButton1;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.bunifuFlatButton2;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::englishkids_APP.Properties.Resources.kaspersky_safe_kids1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 683);
            this.Controls.Add(this.btn_mute);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.plogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmlogin);
            this.Controls.Add(this.welcometxt);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.plogin.ResumeLayout(false);
            this.plogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label welcometxt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btmlogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel plogin;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpassword;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton btn_play;
        private Bunifu.Framework.UI.BunifuImageButton btn_mute;
    }
}

