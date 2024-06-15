namespace Lesson_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_FirstSelect.Items.Add("string");
            cmb_FirstSelect.Items.Add("string2");
            cmb_FirstSelect.Items.Add("string3");
            ////cmb_FirstSelect.SelectedItem = "string";
            //MessageBox.Show(cmb_FirstSelect.SelectedIndex.ToString());



            progressBar1.Value = 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
