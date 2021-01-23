using aula.management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula.management
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Teacherbtn_Click(object sender, EventArgs e)
        {
            TeacherForm teachers = new TeacherForm();
            this.Hide();
            teachers.ShowDialog();
            this.Show();
        }

        private void Gradebtn_Click(object sender, EventArgs e)
        {
            GradeForm grade = new GradeForm();
            this.Hide();
            grade.ShowDialog();
            this.Show();
        }
    }
}
