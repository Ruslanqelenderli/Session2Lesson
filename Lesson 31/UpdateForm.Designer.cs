namespace Lesson_31
{
    partial class UpdateForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmb_courses = new ComboBox();
            cmb_gender = new ComboBox();
            dt_birthdate = new DateTimePicker();
            txb_surname = new TextBox();
            txb_name = new TextBox();
            btn_Update = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 313);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 22;
            label5.Text = "Kurs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 88);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 21;
            label4.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 172);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 20;
            label3.Text = "Doğum tarixi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 243);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 19;
            label2.Text = "Cinsiyyət";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 18;
            label1.Text = "Ad";
            // 
            // cmb_courses
            // 
            cmb_courses.FormattingEnabled = true;
            cmb_courses.Location = new Point(275, 336);
            cmb_courses.Name = "cmb_courses";
            cmb_courses.Size = new Size(250, 28);
            cmb_courses.TabIndex = 17;
            // 
            // cmb_gender
            // 
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Location = new Point(275, 266);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(250, 28);
            cmb_gender.TabIndex = 16;
            // 
            // dt_birthdate
            // 
            dt_birthdate.Location = new Point(275, 195);
            dt_birthdate.Name = "dt_birthdate";
            dt_birthdate.Size = new Size(250, 27);
            dt_birthdate.TabIndex = 15;
            // 
            // txb_surname
            // 
            txb_surname.Location = new Point(275, 120);
            txb_surname.Name = "txb_surname";
            txb_surname.Size = new Size(250, 27);
            txb_surname.TabIndex = 14;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(275, 47);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(250, 27);
            txb_name.TabIndex = 13;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(323, 382);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(138, 56);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Yadda Saxla";
            btn_Update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(btn_Update);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmb_courses;
        private ComboBox cmb_gender;
        private DateTimePicker dt_birthdate;
        private TextBox txb_surname;
        private TextBox txb_name;
        private Button button1;
        private Button btn_Update;
    }
}