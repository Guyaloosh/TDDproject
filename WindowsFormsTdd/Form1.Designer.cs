
namespace WindowsFormsTdd
{
    partial class FirstNameTxtBox
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
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.GradesLabels = new System.Windows.Forms.Label();
            this.MathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnglishTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HebrewTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhysicsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftwereTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(56, 579);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(168, 44);
            this.AddStudentBtn.TabIndex = 0;
            this.AddStudentBtn.Text = "הוספת סטודנט";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(1095, 109);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(51, 13);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "שם פרטי";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(911, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(911, 146);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(160, 20);
            this.LastNameTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1095, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "שם משפחה";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(911, 186);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(160, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(1091, 189);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(67, 13);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "תעודת זהות";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(911, 226);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(160, 20);
            this.EmailTextBox.TabIndex = 7;
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.AutoSize = true;
            this.EmailTextLabel.Location = new System.Drawing.Point(1095, 229);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(67, 13);
            this.EmailTextLabel.TabIndex = 8;
            this.EmailTextLabel.Text = "כתובת מייל";
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(911, 266);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(160, 20);
            this.PhoneNumTextBox.TabIndex = 9;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(1091, 269);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(76, 13);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "מספר פלאפון";
            // 
            // GradesLabels
            // 
            this.GradesLabels.AutoSize = true;
            this.GradesLabels.Location = new System.Drawing.Point(1092, 319);
            this.GradesLabels.Name = "GradesLabels";
            this.GradesLabels.Size = new System.Drawing.Size(82, 13);
            this.GradesLabels.TabIndex = 11;
            this.GradesLabels.Text = "ציוני הסטודנט";
            this.GradesLabels.Click += new System.EventHandler(this.GradesLabels_Click);
            // 
            // MathTextBox
            // 
            this.MathTextBox.Location = new System.Drawing.Point(956, 349);
            this.MathTextBox.Name = "MathTextBox";
            this.MathTextBox.Size = new System.Drawing.Size(50, 20);
            this.MathTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1029, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "מתמטיקה";
            // 
            // EnglishTextBox
            // 
            this.EnglishTextBox.Location = new System.Drawing.Point(956, 389);
            this.EnglishTextBox.Name = "EnglishTextBox";
            this.EnglishTextBox.Size = new System.Drawing.Size(50, 20);
            this.EnglishTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1029, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "אנגלית";
            // 
            // HebrewTextBox
            // 
            this.HebrewTextBox.Location = new System.Drawing.Point(956, 429);
            this.HebrewTextBox.Name = "HebrewTextBox";
            this.HebrewTextBox.Size = new System.Drawing.Size(50, 20);
            this.HebrewTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1032, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "לשון";
            // 
            // PhysicsTextBox
            // 
            this.PhysicsTextBox.Location = new System.Drawing.Point(956, 469);
            this.PhysicsTextBox.Name = "PhysicsTextBox";
            this.PhysicsTextBox.Size = new System.Drawing.Size(50, 20);
            this.PhysicsTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1029, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "פיזיקה";
            // 
            // SoftwereTextBox
            // 
            this.SoftwereTextBox.Location = new System.Drawing.Point(956, 509);
            this.SoftwereTextBox.Name = "SoftwereTextBox";
            this.SoftwereTextBox.Size = new System.Drawing.Size(50, 20);
            this.SoftwereTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "תכנות";
            // 
            // StudentView1
            // 
            this.StudentView1.HideSelection = false;
            this.StudentView1.Location = new System.Drawing.Point(56, 48);
            this.StudentView1.Name = "StudentView1";
            this.StudentView1.Size = new System.Drawing.Size(573, 500);
            this.StudentView1.TabIndex = 22;
            this.StudentView1.UseCompatibleStateImageBehavior = false;
            this.StudentView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FirstNameTxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 660);
            this.Controls.Add(this.StudentView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SoftwereTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhysicsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HebrewTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnglishTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MathTextBox);
            this.Controls.Add(this.GradesLabels);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneNumTextBox);
            this.Controls.Add(this.EmailTextLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.AddStudentBtn);
            this.Name = "FirstNameTxtBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.TextBox PhoneNumTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label GradesLabels;
        private System.Windows.Forms.TextBox MathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnglishTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HebrewTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhysicsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoftwereTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView StudentView1;
    }
}

