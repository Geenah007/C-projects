namespace Practical_2._1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.std_name = new System.Windows.Forms.Label();
            this.std_age = new System.Windows.Forms.Label();
            this.std_stand = new System.Windows.Forms.Label();
            this.std_school = new System.Windows.Forms.Label();
            this.name_btn = new System.Windows.Forms.Button();
            this.name_age_btn = new System.Windows.Forms.Button();
            this.name_standard_btn = new System.Windows.Forms.Button();
            this.name_school_btn = new System.Windows.Forms.Button();
            this.name_age_standard_btn = new System.Windows.Forms.Button();
            this.name_age_standard_school_btn = new System.Windows.Forms.Button();
            this.infotxt1 = new System.Windows.Forms.TextBox();
            this.infotxt2 = new System.Windows.Forms.TextBox();
            this.infotxt3 = new System.Windows.Forms.TextBox();
            this.infotxt4 = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.infotxt4);
            this.groupBox1.Controls.Add(this.infotxt3);
            this.groupBox1.Controls.Add(this.infotxt2);
            this.groupBox1.Controls.Add(this.infotxt1);
            this.groupBox1.Controls.Add(this.std_school);
            this.groupBox1.Controls.Add(this.std_stand);
            this.groupBox1.Controls.Add(this.std_age);
            this.groupBox1.Controls.Add(this.std_name);
            this.groupBox1.Location = new System.Drawing.Point(34, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // std_name
            // 
            this.std_name.AutoSize = true;
            this.std_name.Location = new System.Drawing.Point(20, 34);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(144, 13);
            this.std_name.TabIndex = 0;
            this.std_name.Text = "Student Name and Surname:";
            // 
            // std_age
            // 
            this.std_age.AutoSize = true;
            this.std_age.Location = new System.Drawing.Point(23, 79);
            this.std_age.Name = "std_age";
            this.std_age.Size = new System.Drawing.Size(29, 13);
            this.std_age.TabIndex = 1;
            this.std_age.Text = "Age:";
            // 
            // std_stand
            // 
            this.std_stand.AutoSize = true;
            this.std_stand.Location = new System.Drawing.Point(418, 34);
            this.std_stand.Name = "std_stand";
            this.std_stand.Size = new System.Drawing.Size(53, 13);
            this.std_stand.TabIndex = 2;
            this.std_stand.Text = "Standard:";
            // 
            // std_school
            // 
            this.std_school.AutoSize = true;
            this.std_school.Location = new System.Drawing.Point(418, 73);
            this.std_school.Name = "std_school";
            this.std_school.Size = new System.Drawing.Size(43, 13);
            this.std_school.TabIndex = 3;
            this.std_school.Text = "School:";
            // 
            // name_btn
            // 
            this.name_btn.Location = new System.Drawing.Point(57, 192);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(98, 23);
            this.name_btn.TabIndex = 1;
            this.name_btn.Text = "Name";
            this.name_btn.UseVisualStyleBackColor = true;
            this.name_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_age_btn
            // 
            this.name_age_btn.Location = new System.Drawing.Point(57, 261);
            this.name_age_btn.Name = "name_age_btn";
            this.name_age_btn.Size = new System.Drawing.Size(98, 23);
            this.name_age_btn.TabIndex = 2;
            this.name_age_btn.Text = "Name and Age";
            this.name_age_btn.UseVisualStyleBackColor = true;
            this.name_age_btn.Click += new System.EventHandler(this.name_age_btn_Click);
            // 
            // name_standard_btn
            // 
            this.name_standard_btn.Location = new System.Drawing.Point(303, 192);
            this.name_standard_btn.Name = "name_standard_btn";
            this.name_standard_btn.Size = new System.Drawing.Size(115, 23);
            this.name_standard_btn.TabIndex = 3;
            this.name_standard_btn.Text = "Name and Standard";
            this.name_standard_btn.UseVisualStyleBackColor = true;
            this.name_standard_btn.Click += new System.EventHandler(this.name_standard_btn_Click);
            // 
            // name_school_btn
            // 
            this.name_school_btn.Location = new System.Drawing.Point(303, 261);
            this.name_school_btn.Name = "name_school_btn";
            this.name_school_btn.Size = new System.Drawing.Size(115, 23);
            this.name_school_btn.TabIndex = 4;
            this.name_school_btn.Text = "Name and School";
            this.name_school_btn.UseVisualStyleBackColor = true;
            this.name_school_btn.Click += new System.EventHandler(this.name_school_btn_Click);
            // 
            // name_age_standard_btn
            // 
            this.name_age_standard_btn.Location = new System.Drawing.Point(564, 192);
            this.name_age_standard_btn.Name = "name_age_standard_btn";
            this.name_age_standard_btn.Size = new System.Drawing.Size(181, 23);
            this.name_age_standard_btn.TabIndex = 5;
            this.name_age_standard_btn.Text = "Name, Age and Standard";
            this.name_age_standard_btn.UseVisualStyleBackColor = true;
            this.name_age_standard_btn.Click += new System.EventHandler(this.name_age_standard_btn_Click);
            // 
            // name_age_standard_school_btn
            // 
            this.name_age_standard_school_btn.Location = new System.Drawing.Point(564, 261);
            this.name_age_standard_school_btn.Name = "name_age_standard_school_btn";
            this.name_age_standard_school_btn.Size = new System.Drawing.Size(181, 23);
            this.name_age_standard_school_btn.TabIndex = 6;
            this.name_age_standard_school_btn.Text = "Name, Age, Standard and School";
            this.name_age_standard_school_btn.UseVisualStyleBackColor = true;
            this.name_age_standard_school_btn.Click += new System.EventHandler(this.name_age_standard_school_btn_Click);
            // 
            // infotxt1
            // 
            this.infotxt1.AcceptsTab = true;
            this.infotxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infotxt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.infotxt1.Location = new System.Drawing.Point(170, 32);
            this.infotxt1.Name = "infotxt1";
            this.infotxt1.Size = new System.Drawing.Size(226, 20);
            this.infotxt1.TabIndex = 4;
            this.infotxt1.TextChanged += new System.EventHandler(this.infotxt1_TextChanged);
            // 
            // infotxt2
            // 
            this.infotxt2.Location = new System.Drawing.Point(170, 70);
            this.infotxt2.Name = "infotxt2";
            this.infotxt2.Size = new System.Drawing.Size(100, 20);
            this.infotxt2.TabIndex = 5;
            // 
            // infotxt3
            // 
            this.infotxt3.Location = new System.Drawing.Point(477, 27);
            this.infotxt3.Name = "infotxt3";
            this.infotxt3.Size = new System.Drawing.Size(196, 20);
            this.infotxt3.TabIndex = 6;
            // 
            // infotxt4
            // 
            this.infotxt4.Location = new System.Drawing.Point(477, 66);
            this.infotxt4.Name = "infotxt4";
            this.infotxt4.Size = new System.Drawing.Size(196, 20);
            this.infotxt4.TabIndex = 7;
            // 
            // outputbox
            // 
            this.outputbox.Location = new System.Drawing.Point(57, 320);
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(688, 96);
            this.outputbox.TabIndex = 7;
            this.outputbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.name_age_standard_school_btn);
            this.Controls.Add(this.name_age_standard_btn);
            this.Controls.Add(this.name_school_btn);
            this.Controls.Add(this.name_standard_btn);
            this.Controls.Add(this.name_age_btn);
            this.Controls.Add(this.name_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Students\' Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox infotxt4;
        private System.Windows.Forms.TextBox infotxt3;
        private System.Windows.Forms.TextBox infotxt2;
        private System.Windows.Forms.TextBox infotxt1;
        private System.Windows.Forms.Label std_school;
        private System.Windows.Forms.Label std_stand;
        private System.Windows.Forms.Label std_age;
        private System.Windows.Forms.Label std_name;
        private System.Windows.Forms.Button name_btn;
        private System.Windows.Forms.Button name_age_btn;
        private System.Windows.Forms.Button name_standard_btn;
        private System.Windows.Forms.Button name_school_btn;
        private System.Windows.Forms.Button name_age_standard_btn;
        private System.Windows.Forms.Button name_age_standard_school_btn;
        private System.Windows.Forms.RichTextBox outputbox;
    }
}

