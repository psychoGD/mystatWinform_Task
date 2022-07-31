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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            List<UserControl1> users = new List<UserControl1>()
            {
                new UserControl1(){Fullname="Obuma Osakama Adah",LastSeen="17.02.2021",StudentImage=Properties.Resources.icons8_user_32},
            };
            foreach (var item in users)
            {
                panelStudents.Controls.Add(item);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void checkAllStudentRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkAllStudentRB_Click_1(object sender, EventArgs e)
        {
            if (checkAllStudentRB.Checked)
            {
                checkAllStudentRB.Checked = false;
            }
            else
            {
                checkAllStudentRB.Checked = true;
            }
        }

        private void guna2Panel4_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollProperties vsp = panelStudents.VerticalScroll;

            int scrollmax = vsp.Maximum - vsp.LargeChange + 1;

            if (e.NewValue == scrollmax) ;
        }
    }
}
