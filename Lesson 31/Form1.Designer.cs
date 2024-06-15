namespace Lesson_31
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txb_name = new TextBox();
            txb_surname = new TextBox();
            dt_birthdate = new DateTimePicker();
            cmb_gender = new ComboBox();
            cmb_courses = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_HardDelete = new Button();
            btn_SoftDelete = new Button();
            btn_UpdateForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(972, 504);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(78, 406);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Əlavə et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(12, 50);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(250, 27);
            txb_name.TabIndex = 2;
            // 
            // txb_surname
            // 
            txb_surname.Location = new Point(12, 123);
            txb_surname.Name = "txb_surname";
            txb_surname.Size = new Size(250, 27);
            txb_surname.TabIndex = 3;
            // 
            // dt_birthdate
            // 
            dt_birthdate.Location = new Point(12, 198);
            dt_birthdate.Name = "dt_birthdate";
            dt_birthdate.Size = new Size(250, 27);
            dt_birthdate.TabIndex = 4;
            // 
            // cmb_gender
            // 
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Location = new Point(12, 269);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(250, 28);
            cmb_gender.TabIndex = 5;
            // 
            // cmb_courses
            // 
            cmb_courses.FormattingEnabled = true;
            cmb_courses.Location = new Point(12, 339);
            cmb_courses.Name = "cmb_courses";
            cmb_courses.Size = new Size(250, 28);
            cmb_courses.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 7;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 246);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Cinsiyyət";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 9;
            label3.Text = "Doğum tarixi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 316);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 11;
            label5.Text = "Kurs";
            // 
            // btn_HardDelete
            // 
            btn_HardDelete.BackColor = Color.Maroon;
            btn_HardDelete.ForeColor = Color.White;
            btn_HardDelete.Location = new Point(1218, 545);
            btn_HardDelete.Name = "btn_HardDelete";
            btn_HardDelete.Size = new Size(134, 61);
            btn_HardDelete.TabIndex = 12;
            btn_HardDelete.Text = "Hard Delete";
            btn_HardDelete.UseVisualStyleBackColor = false;
            btn_HardDelete.Visible = false;
            btn_HardDelete.Click += btn_HardDelete_Click;
            // 
            // btn_SoftDelete
            // 
            btn_SoftDelete.BackColor = Color.FromArgb(192, 0, 0);
            btn_SoftDelete.ForeColor = Color.WhiteSmoke;
            btn_SoftDelete.Location = new Point(1078, 545);
            btn_SoftDelete.Name = "btn_SoftDelete";
            btn_SoftDelete.Size = new Size(134, 61);
            btn_SoftDelete.TabIndex = 13;
            btn_SoftDelete.Text = "Soft Delete";
            btn_SoftDelete.UseVisualStyleBackColor = false;
            btn_SoftDelete.Visible = false;
            btn_SoftDelete.Click += btn_SoftDelete_Click;
            // 
            // btn_UpdateForm
            // 
            btn_UpdateForm.BackColor = Color.Olive;
            btn_UpdateForm.ForeColor = Color.White;
            btn_UpdateForm.Location = new Point(380, 545);
            btn_UpdateForm.Name = "btn_UpdateForm";
            btn_UpdateForm.Size = new Size(140, 61);
            btn_UpdateForm.TabIndex = 14;
            btn_UpdateForm.Text = "Update";
            btn_UpdateForm.UseVisualStyleBackColor = false;
            btn_UpdateForm.Visible = false;
            btn_UpdateForm.Click += btn_UpdateForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 710);
            Controls.Add(btn_UpdateForm);
            Controls.Add(btn_SoftDelete);
            Controls.Add(btn_HardDelete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_courses);
            Controls.Add(cmb_gender);
            Controls.Add(dt_birthdate);
            Controls.Add(txb_surname);
            Controls.Add(txb_name);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Update";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txb_name;
        private TextBox txb_surname;
        private DateTimePicker dt_birthdate;
        private ComboBox cmb_gender;
        private ComboBox cmb_courses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_HardDelete;
        private Button btn_SoftDelete;
        private Button btn_UpdateForm;
    }
}
