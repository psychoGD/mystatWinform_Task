namespace MyStatWinform_Task
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentFullname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MystatLastSeen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.inLessonRB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lateRB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.DoesNotAttendRB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.score1CB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.score2CB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.commentTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveCommentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelCommentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.studentImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // studentFullname
            // 
            this.studentFullname.BackColor = System.Drawing.Color.Transparent;
            this.studentFullname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentFullname.Location = new System.Drawing.Point(86, 41);
            this.studentFullname.Name = "studentFullname";
            this.studentFullname.Size = new System.Drawing.Size(77, 21);
            this.studentFullname.TabIndex = 1;
            this.studentFullname.Text = "Fullname";
            // 
            // MystatLastSeen
            // 
            this.MystatLastSeen.BackColor = System.Drawing.Color.Transparent;
            this.MystatLastSeen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MystatLastSeen.Location = new System.Drawing.Point(263, 41);
            this.MystatLastSeen.Name = "MystatLastSeen";
            this.MystatLastSeen.Size = new System.Drawing.Size(65, 21);
            this.MystatLastSeen.TabIndex = 2;
            this.MystatLastSeen.Text = "lasttime";
            // 
            // inLessonRB
            // 
            this.inLessonRB.AutoSize = true;
            this.inLessonRB.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.inLessonRB.CheckedState.BorderThickness = 0;
            this.inLessonRB.CheckedState.FillColor = System.Drawing.Color.Green;
            this.inLessonRB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.inLessonRB.CheckedState.InnerOffset = -4;
            this.inLessonRB.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.inLessonRB.Location = new System.Drawing.Point(384, 50);
            this.inLessonRB.Name = "inLessonRB";
            this.inLessonRB.Size = new System.Drawing.Size(17, 16);
            this.inLessonRB.TabIndex = 3;
            this.inLessonRB.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.inLessonRB.UncheckedState.BorderThickness = 2;
            this.inLessonRB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.inLessonRB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lateRB
            // 
            this.lateRB.AutoSize = true;
            this.lateRB.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.lateRB.CheckedState.BorderThickness = 0;
            this.lateRB.CheckedState.FillColor = System.Drawing.Color.Yellow;
            this.lateRB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.lateRB.CheckedState.InnerOffset = -4;
            this.lateRB.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.lateRB.Location = new System.Drawing.Point(431, 50);
            this.lateRB.Name = "lateRB";
            this.lateRB.Size = new System.Drawing.Size(17, 16);
            this.lateRB.TabIndex = 4;
            this.lateRB.UncheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.lateRB.UncheckedState.BorderThickness = 2;
            this.lateRB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.lateRB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // DoesNotAttendRB
            // 
            this.DoesNotAttendRB.AutoSize = true;
            this.DoesNotAttendRB.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.DoesNotAttendRB.CheckedState.BorderThickness = 0;
            this.DoesNotAttendRB.CheckedState.FillColor = System.Drawing.Color.Red;
            this.DoesNotAttendRB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DoesNotAttendRB.CheckedState.InnerOffset = -4;
            this.DoesNotAttendRB.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.DoesNotAttendRB.Location = new System.Drawing.Point(475, 50);
            this.DoesNotAttendRB.Name = "DoesNotAttendRB";
            this.DoesNotAttendRB.Size = new System.Drawing.Size(17, 16);
            this.DoesNotAttendRB.TabIndex = 5;
            this.DoesNotAttendRB.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.DoesNotAttendRB.UncheckedState.BorderThickness = 2;
            this.DoesNotAttendRB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DoesNotAttendRB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // score1CB
            // 
            this.score1CB.BackColor = System.Drawing.Color.Transparent;
            this.score1CB.BorderColor = System.Drawing.Color.Purple;
            this.score1CB.BorderRadius = 5;
            this.score1CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.score1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.score1CB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score1CB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score1CB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.score1CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.score1CB.ItemHeight = 30;
            this.score1CB.Location = new System.Drawing.Point(593, 41);
            this.score1CB.Name = "score1CB";
            this.score1CB.Size = new System.Drawing.Size(133, 36);
            this.score1CB.TabIndex = 6;
            // 
            // score2CB
            // 
            this.score2CB.BackColor = System.Drawing.Color.Transparent;
            this.score2CB.BorderColor = System.Drawing.Color.Lime;
            this.score2CB.BorderRadius = 5;
            this.score2CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.score2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.score2CB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score2CB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score2CB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.score2CB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.score2CB.ItemHeight = 30;
            this.score2CB.Location = new System.Drawing.Point(732, 41);
            this.score2CB.Name = "score2CB";
            this.score2CB.Size = new System.Drawing.Size(140, 36);
            this.score2CB.TabIndex = 7;
            // 
            // commentTB
            // 
            this.commentTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commentTB.DefaultText = "";
            this.commentTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.commentTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.commentTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commentTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commentTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commentTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.commentTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commentTB.Location = new System.Drawing.Point(903, 18);
            this.commentTB.Name = "commentTB";
            this.commentTB.PasswordChar = '\0';
            this.commentTB.PlaceholderText = "";
            this.commentTB.SelectedText = "";
            this.commentTB.Size = new System.Drawing.Size(148, 36);
            this.commentTB.TabIndex = 9;
            this.commentTB.Visible = false;
            // 
            // saveCommentBtn
            // 
            this.saveCommentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveCommentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveCommentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveCommentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveCommentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveCommentBtn.ForeColor = System.Drawing.Color.White;
            this.saveCommentBtn.Location = new System.Drawing.Point(904, 61);
            this.saveCommentBtn.Name = "saveCommentBtn";
            this.saveCommentBtn.Size = new System.Drawing.Size(63, 45);
            this.saveCommentBtn.TabIndex = 10;
            this.saveCommentBtn.Text = "Save";
            this.saveCommentBtn.Visible = false;
            this.saveCommentBtn.Click += new System.EventHandler(this.saveCommentBtn_Click);
            // 
            // cancelCommentBtn
            // 
            this.cancelCommentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelCommentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelCommentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelCommentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelCommentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelCommentBtn.ForeColor = System.Drawing.Color.White;
            this.cancelCommentBtn.Location = new System.Drawing.Point(973, 61);
            this.cancelCommentBtn.Name = "cancelCommentBtn";
            this.cancelCommentBtn.Size = new System.Drawing.Size(78, 45);
            this.cancelCommentBtn.TabIndex = 11;
            this.cancelCommentBtn.Text = "Cancel";
            this.cancelCommentBtn.Visible = false;
            this.cancelCommentBtn.Click += new System.EventHandler(this.cancelCommentBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::MyStatWinform_Task.Properties.Resources.icons8_comments_48;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(945, 41);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(44, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // studentImage
            // 
            this.studentImage.ImageRotate = 0F;
            this.studentImage.Location = new System.Drawing.Point(16, 18);
            this.studentImage.Name = "studentImage";
            this.studentImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.studentImage.Size = new System.Drawing.Size(64, 68);
            this.studentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentImage.TabIndex = 0;
            this.studentImage.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelCommentBtn);
            this.Controls.Add(this.saveCommentBtn);
            this.Controls.Add(this.commentTB);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.score2CB);
            this.Controls.Add(this.score1CB);
            this.Controls.Add(this.DoesNotAttendRB);
            this.Controls.Add(this.lateRB);
            this.Controls.Add(this.inLessonRB);
            this.Controls.Add(this.MystatLastSeen);
            this.Controls.Add(this.studentFullname);
            this.Controls.Add(this.studentImage);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1055, 113);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox studentImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel studentFullname;
        private Guna.UI2.WinForms.Guna2HtmlLabel MystatLastSeen;
        private Guna.UI2.WinForms.Guna2RadioButton inLessonRB;
        private Guna.UI2.WinForms.Guna2RadioButton lateRB;
        private Guna.UI2.WinForms.Guna2RadioButton DoesNotAttendRB;
        private Guna.UI2.WinForms.Guna2ComboBox score1CB;
        private Guna.UI2.WinForms.Guna2ComboBox score2CB;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox commentTB;
        private Guna.UI2.WinForms.Guna2Button saveCommentBtn;
        private Guna.UI2.WinForms.Guna2Button cancelCommentBtn;
    }
}
