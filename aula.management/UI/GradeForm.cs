using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aula.management.Models;
using System.Linq;

namespace aula.management.UI
{
    public partial class GradeForm : MetroFramework.Forms.MetroForm
    {
        public GradeForm()
        {
            InitializeComponent();
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {
            GetTeachers();
            GetGrades();
        }
        private void GetTeachers()
        {
           
                using (dbconection database = new dbconection())
                {
                    var list = from d in database.Teachers select new { d.Id, d.Name, d.LastName};
                    cmbteacher.DataSource = list.ToList();
                    cmbteacher.ValueMember = "Id";
                    cmbteacher.DisplayMember ="Name";
                }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (dbconection db = new dbconection())
            {
                Grade grade = new Grade();
                grade.Name = txtname.Text;
                grade.TeacherId = Convert.ToInt32(cmbteacher.SelectedValue);
                db.Grades.Add(grade);
                db.SaveChanges();

            }
        }

        private void GetGrades ()
        {
            using (dbconection database = new dbconection())
            {
                var list = from g in database.Grades 
                           join t in database.Teachers on g.TeacherId equals t.Id 
                           select new { g.Id, g.Name,  t.LastName,  };
                metroGrid1.DataSource = list.ToList();
               
            }
        }
    }
}
