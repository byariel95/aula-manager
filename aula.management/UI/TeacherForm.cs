using aula.management.Models;
using System;
using System.Linq;


namespace aula.management.UI
{
    public partial class TeacherForm : MetroFramework.Forms.MetroForm
    {
        
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            GetTeachers();
            btnedit.Enabled = false;
            btndelete.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (dbconection db = new dbconection())
            {
                Teacher teacher = new Teacher();
                teacher.Name = txtname.Text;
                teacher.LastName = txtlastname.Text;
                teacher.Gender = cmbgender.Text;
                db.Teachers.Add(teacher);
                db.SaveChanges();
                CleanTxt();

            }
            GetTeachers();
        }
        private void GetTeachers()
        {
            try
            {
                using (dbconection database = new dbconection())
                {
                    var list = from d in database.Teachers select new { d.Id, d.Name, d.LastName, d.Gender };
                    metroGrid1.DataSource = list.ToList();
                }
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Error al cargar los datos");
            }



        }

        private void CleanTxt()
        {
            txtlastname.Text = "";
            txtname.Text = "";
            cmbgender.Text = "";

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            using (dbconection database = new dbconection())
            {
                Teacher teacher = null;
                teacher = database.Teachers.Find(id);
                teacher.Name = txtname.Text;
                teacher.LastName = txtlastname.Text;
                teacher.Gender = cmbgender.Text;
                database.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                database.SaveChanges();

            }
            GetTeachers();
        }

        private int? GetId()
        {
            try
            {
               return int.Parse(metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
           
        }

        private void metroGrid1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnsave.Enabled = false;
            txtname.Text = metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[1].Value.ToString();
            txtlastname.Text = metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[2].Value.ToString();
            cmbgender.Text = metroGrid1.Rows[metroGrid1.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            using (dbconection database = new dbconection())
            {
                Teacher teacher = database.Teachers.Find(id);
                database.Teachers.Remove(teacher);
                database.SaveChanges();

            }
            CleanTxt();
            GetTeachers();
        }
    }
}
