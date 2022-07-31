using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStatWinform_Task
{
    public partial class UserControl1 : UserControl
    {
        public Image StudentImage
        {
            get
            {
                return studentImage.Image;
            }
            set
            {
                studentImage.Image = value;
            }
        }
        public string Fullname 
        {
            get { return studentFullname.Text; }
            set { studentFullname.Text = value; }
        }
        public string LastSeen 
        { 
            get { return MystatLastSeen.Text; } 
            set { MystatLastSeen.Text = value; } 
        }
        public UserControl1()
        {
            InitializeComponent();
            List<string> scores = new List<string>() { "1","2","3", "4", "5", "6", "7", "8", "9", "10", "11", "12" }; 

            score1CB.Items.AddRange(scores.ToArray());
            score2CB.Items.AddRange(scores.ToArray());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            var btn = sender as PictureBox;
            commentTB.Visible = true;
            saveCommentBtn.Visible = true;
            cancelCommentBtn.Visible = true;
            btn.Visible = false;
        }

        private void cancelCommentBtn_Click(object sender, EventArgs e)
        {
            commentTB.Visible = false;
            saveCommentBtn.Visible = false;
            cancelCommentBtn.Visible=false;
            guna2PictureBox1.Visible = true;

        }

        private void saveCommentBtn_Click(object sender, EventArgs e)
        {

            commentTB.Enabled = false;
            cancelCommentBtn.Dispose();
            guna2PictureBox1.Dispose();
            saveCommentBtn.Dispose();
        }
    }
}
