using Lesson_31.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_31
{
    public partial class UpdateForm : Form
    {
        private readonly int UserId;
        public UpdateForm(int id)
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

            LocateData(id);
            UserId = id;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {


        }



        private void LocateData(int id)
        {
            var student = GetStudents(id).FirstOrDefault();


            txb_name.Text = student.Name;
            txb_surname.Text = student.Surname;
            dt_birthdate.Value = student.BirthDate;
            cmb_courses.SelectedValue = student.CourseId;
            cmb_gender.SelectedValue = student.Gender;
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
        private List<StudentGetByIdModel> GetStudents(int id)
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=WindowsFormDb;Trusted_Connection=True;"))
                {

                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "select * from students s where s.is_deleted = 0 and id = @ID";
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    var dataReader = cmd.ExecuteReader();
                    var students = new List<StudentGetByIdModel>();
                    while (dataReader.Read())
                    {
                        students.Add(new StudentGetByIdModel()
                        {
                            Id = (int)dataReader.GetValue("ID"),
                            Name = (string)dataReader.GetValue("NAME"),
                            Surname = (string)dataReader.GetValue("SURNAME"),
                            BirthDate = DateTime.Parse(dataReader.GetValue("BIRTH_DATE").ToString()),
                            CourseId = (int)dataReader.GetValue("COURSE_ID"),
                            Gender = (short)dataReader.GetValue("GENDER")
                        });
                    }
                    return students;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update();
            this.Close();
            var form1 = new Form1();
            form1.Show();

        }

        private void Update()
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=WindowsFormDb;Trusted_Connection=True;"))
                {
                    var student = new StudentUpdateModel()
                    {
                        Id = UserId,
                        Name = txb_name.Text,
                        Surname = txb_surname.Text,
                        BirthDate = dt_birthdate.Value,
                        CourseId = (int)cmb_courses.SelectedValue,
                        Gender = (short)cmb_gender.SelectedValue,
                    };


                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "update students set name = @NAME , surname = @SURNAME , birth_date = @BIRTH_DATE,course_id = @COURSE_ID , gender = @GENDER where  id = @ID";
                    cmd.Parameters.Add(new SqlParameter("@ID", student.Id));
                    cmd.Parameters.Add(new SqlParameter("@NAME", student.Name));
                    cmd.Parameters.Add(new SqlParameter("@SURNAME", student.Surname));
                    cmd.Parameters.Add(new SqlParameter("@BIRTH_DATE", student.BirthDate));
                    cmd.Parameters.Add(new SqlParameter("@COURSE_ID", student.CourseId));
                    cmd.Parameters.Add(new SqlParameter("@GENDER", student.Gender));
                    
                    var dataReader = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
