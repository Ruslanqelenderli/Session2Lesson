using Lesson_31.Entities;
using Lesson_31.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Lesson_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var dictionaryGender = new Dictionary<short, string>();
            dictionaryGender.Add(1, "Kişi");
            dictionaryGender.Add(2, "Qadın");

            cmb_gender.DataSource = new BindingSource(dictionaryGender, null);
            cmb_gender.DisplayMember = "Value";
            cmb_gender.ValueMember = "Key";

            var dictionaryCourses = new Dictionary<int, string>();

            var courses = GetCourses();

            foreach (var c in courses)
            {
                dictionaryCourses.Add(c.Id, c.Name);
            }

            cmb_courses.DataSource = new BindingSource(dictionaryCourses, null);
            cmb_courses.DisplayMember = "Value";
            cmb_courses.ValueMember = "Key";

            GetStudents();
        }



        private List<Course> GetCourses()
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=WindowsFormDb;Trusted_Connection=True;"))
                {

                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "select * from courses";

                    var dataReader = cmd.ExecuteReader();
                    var courses = new List<Course>();
                    while (dataReader.Read())
                    {
                        courses.Add(new Course()
                        {
                            Id = (int)dataReader.GetValue("ID"),
                            Name = (string)dataReader.GetValue("NAME"),
                        });
                    }
                    return courses;
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent(new StudentAddModel()
            {
                Surname = txb_surname.Text,
                Name = txb_name.Text,
                BirthDate = dt_birthdate.Value,
                CourseId = (int)cmb_courses.SelectedValue,
                Gender = (short)cmb_gender.SelectedValue
            });

        }

        private List<StudentGetModel> GetStudents()
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=WindowsFormDb;Trusted_Connection=True;"))
                {

                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "select s.ID,S.BIRTH_DATE,S.GENDER,S.NAME,S.SURNAME,C.NAME COURSE_NAME  from students s\r\ninner join Courses c on c.id = s.COURSE_ID where s.is_deleted = 0";

                    var dataReader = cmd.ExecuteReader();
                    var students = new List<StudentGetModel>();
                    while (dataReader.Read())
                    {
                        students.Add(new StudentGetModel()
                        {
                            Id = (int)dataReader.GetValue("ID"),
                            Name = (string)dataReader.GetValue("NAME"),
                            Surname = (string)dataReader.GetValue("SURNAME"),
                            BirthDate = DateTime.Parse(dataReader.GetValue("BIRTH_DATE").ToString()),
                            CourseName = dataReader.GetValue("COURSE_NAME").ToString(),
                            Gender = (short)dataReader.GetValue("GENDER") == 1 ? "Kişi" : "Qadın"
                        });
                    }
                    dataGridView1.DataSource = students;
                    return students;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void AddStudent(StudentAddModel model)
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=WindowsFormDb;Trusted_Connection=True;"))
                {

                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into Students (Name,Surname,Birth_date,gender,Course_id) values(@NAME,@SURNAME,@BIRTH_DATE,@GENDER,@COURSE_ID)";

                    cmd.Parameters.Add(new SqlParameter("@NAME", model.Name));
                    cmd.Parameters.Add(new SqlParameter("@SURNAME", model.Surname));
                    cmd.Parameters.Add(new SqlParameter("@BIRTH_DATE", model.BirthDate));
                    cmd.Parameters.Add(new SqlParameter("@GENDER", model.Gender));
                    cmd.Parameters.Add(new SqlParameter("@COURSE_ID", model.CourseId));

                    cmd.ExecuteNonQuery();
                    GetStudents();
                    ClearAddInputs();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ClearAddInputs()
        {
            txb_name.Text = "";
            txb_surname.Text = "";
            dt_birthdate.Value = DateTime.Now;
            cmb_courses.SelectedIndex = 0;
            cmb_gender.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_HardDelete.Visible = true;
            btn_UpdateForm.Visible = true;
            btn_SoftDelete.Visible = true;
        }

        private void Delete(int id, DeleteType deleteType)
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=WindowsFormDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    if (deleteType == DeleteType.HardDelete)
                    {
                        command.CommandText = "delete from STUDENTS where id = @ID";

                    }
                    else
                    {
                        command.CommandText = "update Students set is_deleted = 1 where id = @ID";
                    }
                    command.Parameters.Add(new SqlParameter("@ID", id));

                    command.ExecuteNonQuery();
                    GetStudents();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_SoftDelete_Click(object sender, EventArgs e)
        {

            Delete((int)dataGridView1.SelectedCells[0].Value, DeleteType.SoftDelete);
        }

        private void btn_HardDelete_Click(object sender, EventArgs e)
        {
            Delete((int)dataGridView1.SelectedCells[0].Value, DeleteType.HardDelete);
        }

        private void btn_UpdateForm_Click(object sender, EventArgs e)
        {
            
            var updateForm = new UpdateForm((int)dataGridView1.SelectedCells[0].Value);
            updateForm.ShowDialog();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
