﻿
using System;

namespace WindowsFormsTdd
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StudentName = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
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
            this.ממוצע = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.תכנות = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.פיזיקה = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.לשון = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.אנגלית = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.מתמטיקה = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.טלפון = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.אימייל = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.תעודתזהות = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.שםמלא = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorlable = new System.Windows.Forms.Label();
            this.cleanbtn = new System.Windows.Forms.Button();
            this.NameErrorLable = new System.Windows.Forms.Label();
            this.LastNameErrorLable = new System.Windows.Forms.Label();
            this.IDErrorLable = new System.Windows.Forms.Label();
            this.EmailErrorLable = new System.Windows.Forms.Label();
            this.PhoneErrorLable = new System.Windows.Forms.Label();
            this.GradesErrorLabel = new System.Windows.Forms.Label();
            this.AddStudentBtn1 = new System.Windows.Forms.PictureBox();
            this.addRandomBtn1 = new System.Windows.Forms.PictureBox();
            this.SortBtn1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRandomBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortBtn1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.BackColor = System.Drawing.Color.Transparent;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudentName.ForeColor = System.Drawing.Color.White;
            this.StudentName.Location = new System.Drawing.Point(1409, 199);
            this.StudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(74, 24);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "שם פרטי";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(1245, 204);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(1245, 244);
            this.LastNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(160, 20);
            this.LastNameTxtBox.TabIndex = 3;
            this.LastNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1414, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "שם משפחה";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(1245, 284);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(160, 20);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.BackColor = System.Drawing.Color.Transparent;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IdLabel.ForeColor = System.Drawing.Color.White;
            this.IdLabel.Location = new System.Drawing.Point(1414, 280);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(102, 24);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "תעודת זהות";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(1245, 329);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(160, 20);
            this.EmailTextBox.TabIndex = 7;
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.AutoSize = true;
            this.EmailTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmailTextLabel.ForeColor = System.Drawing.Color.White;
            this.EmailTextLabel.Location = new System.Drawing.Point(1415, 325);
            this.EmailTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(94, 24);
            this.EmailTextLabel.TabIndex = 8;
            this.EmailTextLabel.Text = "כתובת מייל";
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(1245, 369);
            this.PhoneNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(160, 20);
            this.PhoneNumTextBox.TabIndex = 9;
            this.PhoneNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(1415, 364);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(109, 24);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "מספר פלאפון";
            // 
            // GradesLabels
            // 
            this.GradesLabels.AutoSize = true;
            this.GradesLabels.BackColor = System.Drawing.Color.Transparent;
            this.GradesLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GradesLabels.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GradesLabels.Location = new System.Drawing.Point(1008, 149);
            this.GradesLabels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GradesLabels.Name = "GradesLabels";
            this.GradesLabels.Size = new System.Drawing.Size(172, 37);
            this.GradesLabels.TabIndex = 11;
            this.GradesLabels.Text = "ציוני הסטודנט";
            this.GradesLabels.Click += new System.EventHandler(this.GradesLabels_Click);
            // 
            // MathTextBox
            // 
            this.MathTextBox.Location = new System.Drawing.Point(1033, 204);
            this.MathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MathTextBox.Name = "MathTextBox";
            this.MathTextBox.Size = new System.Drawing.Size(50, 20);
            this.MathTextBox.TabIndex = 12;
            this.MathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1109, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "מתמטיקה";
            // 
            // EnglishTextBox
            // 
            this.EnglishTextBox.Location = new System.Drawing.Point(1033, 244);
            this.EnglishTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnglishTextBox.Name = "EnglishTextBox";
            this.EnglishTextBox.Size = new System.Drawing.Size(50, 20);
            this.EnglishTextBox.TabIndex = 14;
            this.EnglishTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1109, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "אנגלית";
            // 
            // HebrewTextBox
            // 
            this.HebrewTextBox.Location = new System.Drawing.Point(1033, 286);
            this.HebrewTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HebrewTextBox.Name = "HebrewTextBox";
            this.HebrewTextBox.Size = new System.Drawing.Size(50, 20);
            this.HebrewTextBox.TabIndex = 16;
            this.HebrewTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1109, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "לשון";
            // 
            // PhysicsTextBox
            // 
            this.PhysicsTextBox.Location = new System.Drawing.Point(1033, 328);
            this.PhysicsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhysicsTextBox.Name = "PhysicsTextBox";
            this.PhysicsTextBox.Size = new System.Drawing.Size(50, 20);
            this.PhysicsTextBox.TabIndex = 18;
            this.PhysicsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1109, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "פיזיקה";
            // 
            // SoftwereTextBox
            // 
            this.SoftwereTextBox.Location = new System.Drawing.Point(1033, 369);
            this.SoftwereTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SoftwereTextBox.Name = "SoftwereTextBox";
            this.SoftwereTextBox.Size = new System.Drawing.Size(50, 20);
            this.SoftwereTextBox.TabIndex = 20;
            this.SoftwereTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1109, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "תכנות";
            // 
            // StudentView1
            // 
            this.StudentView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ממוצע,
            this.תכנות,
            this.פיזיקה,
            this.לשון,
            this.אנגלית,
            this.מתמטיקה,
            this.טלפון,
            this.אימייל,
            this.תעודתזהות,
            this.שםמלא});
            this.StudentView1.HideSelection = false;
            this.StudentView1.Location = new System.Drawing.Point(65, 144);
            this.StudentView1.Margin = new System.Windows.Forms.Padding(2);
            this.StudentView1.Name = "StudentView1";
            this.StudentView1.Size = new System.Drawing.Size(915, 399);
            this.StudentView1.TabIndex = 22;
            this.StudentView1.UseCompatibleStateImageBehavior = false;
            this.StudentView1.View = System.Windows.Forms.View.Details;
            this.StudentView1.SelectedIndexChanged += new System.EventHandler(this.StudentView1_SelectedIndexChanged);
            // 
            // ממוצע
            // 
            this.ממוצע.Text = "ממוצע";
            // 
            // תכנות
            // 
            this.תכנות.Text = "תכנות";
            this.תכנות.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // פיזיקה
            // 
            this.פיזיקה.Text = "פיזיקה";
            this.פיזיקה.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // לשון
            // 
            this.לשון.Text = "לשון";
            this.לשון.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // אנגלית
            // 
            this.אנגלית.Text = "אנגלית";
            this.אנגלית.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // מתמטיקה
            // 
            this.מתמטיקה.Text = "מתמטיקה";
            this.מתמטיקה.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // טלפון
            // 
            this.טלפון.Text = "טלפון";
            this.טלפון.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.טלפון.Width = 150;
            // 
            // אימייל
            // 
            this.אימייל.Text = "אימייל";
            this.אימייל.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.אימייל.Width = 150;
            // 
            // תעודתזהות
            // 
            this.תעודתזהות.Text = "תעודת זהות";
            this.תעודתזהות.Width = 150;
            // 
            // שםמלא
            // 
            this.שםמלא.Text = "שם מלא";
            this.שםמלא.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.שםמלא.Width = 100;
            // 
            // errorlable
            // 
            this.errorlable.AutoSize = true;
            this.errorlable.BackColor = System.Drawing.Color.Transparent;
            this.errorlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.errorlable.ForeColor = System.Drawing.Color.Red;
            this.errorlable.Location = new System.Drawing.Point(718, 737);
            this.errorlable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlable.Name = "errorlable";
            this.errorlable.Size = new System.Drawing.Size(186, 20);
            this.errorlable.TabIndex = 24;
            this.errorlable.Text = "אנא הכנס נתונים תקינים";
            this.errorlable.Visible = false;
            this.errorlable.Click += new System.EventHandler(this.label7_Click);
            // 
            // cleanbtn
            // 
            this.cleanbtn.BackColor = System.Drawing.Color.White;
            this.cleanbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cleanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cleanbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cleanbtn.Location = new System.Drawing.Point(1033, 482);
            this.cleanbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cleanbtn.Name = "cleanbtn";
            this.cleanbtn.Size = new System.Drawing.Size(120, 61);
            this.cleanbtn.TabIndex = 25;
            this.cleanbtn.Text = "נקה דף";
            this.cleanbtn.UseVisualStyleBackColor = false;
            this.cleanbtn.Click += new System.EventHandler(this.cleanbtn_Click);
            // 
            // NameErrorLable
            // 
            this.NameErrorLable.AutoSize = true;
            this.NameErrorLable.BackColor = System.Drawing.Color.Transparent;
            this.NameErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NameErrorLable.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLable.Location = new System.Drawing.Point(1264, 226);
            this.NameErrorLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameErrorLable.Name = "NameErrorLable";
            this.NameErrorLable.Size = new System.Drawing.Size(125, 16);
            this.NameErrorLable.TabIndex = 26;
            this.NameErrorLable.Text = "אנא הכנס שם תקין";
            this.NameErrorLable.Visible = false;
            // 
            // LastNameErrorLable
            // 
            this.LastNameErrorLable.AutoSize = true;
            this.LastNameErrorLable.BackColor = System.Drawing.Color.Transparent;
            this.LastNameErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LastNameErrorLable.ForeColor = System.Drawing.Color.Red;
            this.LastNameErrorLable.Location = new System.Drawing.Point(1253, 266);
            this.LastNameErrorLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameErrorLable.Name = "LastNameErrorLable";
            this.LastNameErrorLable.Size = new System.Drawing.Size(174, 16);
            this.LastNameErrorLable.TabIndex = 27;
            this.LastNameErrorLable.Text = "אנא הכנס שם משפחה תקין";
            this.LastNameErrorLable.Visible = false;
            // 
            // IDErrorLable
            // 
            this.IDErrorLable.AutoSize = true;
            this.IDErrorLable.BackColor = System.Drawing.Color.Transparent;
            this.IDErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IDErrorLable.ForeColor = System.Drawing.Color.Red;
            this.IDErrorLable.Location = new System.Drawing.Point(1249, 308);
            this.IDErrorLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDErrorLable.Name = "IDErrorLable";
            this.IDErrorLable.Size = new System.Drawing.Size(164, 16);
            this.IDErrorLable.TabIndex = 28;
            this.IDErrorLable.Text = "תעודת זהות אינה תקינה";
            this.IDErrorLable.Visible = false;
            // 
            // EmailErrorLable
            // 
            this.EmailErrorLable.AutoSize = true;
            this.EmailErrorLable.BackColor = System.Drawing.Color.Transparent;
            this.EmailErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EmailErrorLable.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLable.Location = new System.Drawing.Point(1242, 351);
            this.EmailErrorLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailErrorLable.Name = "EmailErrorLable";
            this.EmailErrorLable.Size = new System.Drawing.Size(162, 16);
            this.EmailErrorLable.TabIndex = 29;
            this.EmailErrorLable.Text = "כתובת מייל אינה תקינה";
            this.EmailErrorLable.Visible = false;
            // 
            // PhoneErrorLable
            // 
            this.PhoneErrorLable.AutoSize = true;
            this.PhoneErrorLable.BackColor = System.Drawing.Color.Transparent;
            this.PhoneErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneErrorLable.ForeColor = System.Drawing.Color.Red;
            this.PhoneErrorLable.Location = new System.Drawing.Point(1264, 391);
            this.PhoneErrorLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneErrorLable.Name = "PhoneErrorLable";
            this.PhoneErrorLable.Size = new System.Drawing.Size(138, 16);
            this.PhoneErrorLable.TabIndex = 30;
            this.PhoneErrorLable.Text = "מספר נייד אינו תקין";
            this.PhoneErrorLable.Visible = false;
            // 
            // GradesErrorLabel
            // 
            this.GradesErrorLabel.AutoSize = true;
            this.GradesErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.GradesErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GradesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.GradesErrorLabel.Location = new System.Drawing.Point(1039, 402);
            this.GradesErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GradesErrorLabel.Name = "GradesErrorLabel";
            this.GradesErrorLabel.Size = new System.Drawing.Size(132, 16);
            this.GradesErrorLabel.TabIndex = 32;
            this.GradesErrorLabel.Text = "ציונים אינם תקינים";
            this.GradesErrorLabel.Visible = false;
            // 
            // AddStudentBtn1
            // 
            this.AddStudentBtn1.BackColor = System.Drawing.Color.Transparent;
            this.AddStudentBtn1.Image = ((System.Drawing.Image)(resources.GetObject("AddStudentBtn1.Image")));
            this.AddStudentBtn1.Location = new System.Drawing.Point(666, 572);
            this.AddStudentBtn1.Name = "AddStudentBtn1";
            this.AddStudentBtn1.Size = new System.Drawing.Size(287, 147);
            this.AddStudentBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddStudentBtn1.TabIndex = 33;
            this.AddStudentBtn1.TabStop = false;
            this.AddStudentBtn1.Click += new System.EventHandler(this.AddStudentBtn1_Click);
            // 
            // addRandomBtn1
            // 
            this.addRandomBtn1.BackColor = System.Drawing.Color.Transparent;
            this.addRandomBtn1.Image = ((System.Drawing.Image)(resources.GetObject("addRandomBtn1.Image")));
            this.addRandomBtn1.Location = new System.Drawing.Point(370, 560);
            this.addRandomBtn1.Name = "addRandomBtn1";
            this.addRandomBtn1.Size = new System.Drawing.Size(263, 174);
            this.addRandomBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addRandomBtn1.TabIndex = 34;
            this.addRandomBtn1.TabStop = false;
            this.addRandomBtn1.Click += new System.EventHandler(this.addRandomBtn1_Click);
            // 
            // SortBtn1
            // 
            this.SortBtn1.BackColor = System.Drawing.Color.Transparent;
            this.SortBtn1.Image = ((System.Drawing.Image)(resources.GetObject("SortBtn1.Image")));
            this.SortBtn1.Location = new System.Drawing.Point(87, 560);
            this.SortBtn1.Name = "SortBtn1";
            this.SortBtn1.Size = new System.Drawing.Size(255, 174);
            this.SortBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SortBtn1.TabIndex = 35;
            this.SortBtn1.TabStop = false;
            this.SortBtn1.Visible = false;
            this.SortBtn1.Click += new System.EventHandler(this.SortBtn1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(418, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(690, 49);
            this.label7.TabIndex = 36;
            this.label7.Text = "TDD Project  - Student Generator : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(1249, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 37);
            this.label8.TabIndex = 37;
            this.label8.Text = "פרטי הסטודנט";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1249, 597);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 41);
            this.label9.TabIndex = 38;
            this.label9.Text = "Created by :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1393, 654);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 31);
            this.label10.TabIndex = 39;
            this.label10.Text = "Orel Hen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1393, 700);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 31);
            this.label11.TabIndex = 40;
            this.label11.Text = "Guy Aloosh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1393, 745);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 31);
            this.label12.TabIndex = 41;
            this.label12.Text = "Guy Haliva";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1562, 827);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SortBtn1);
            this.Controls.Add(this.addRandomBtn1);
            this.Controls.Add(this.AddStudentBtn1);
            this.Controls.Add(this.GradesErrorLabel);
            this.Controls.Add(this.PhoneErrorLable);
            this.Controls.Add(this.EmailErrorLable);
            this.Controls.Add(this.IDErrorLable);
            this.Controls.Add(this.LastNameErrorLable);
            this.Controls.Add(this.NameErrorLable);
            this.Controls.Add(this.cleanbtn);
            this.Controls.Add(this.errorlable);
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
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.StudentName);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "MainForm";
            this.Text = "TDD Project ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRandomBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortBtn1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void StudentView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label GradesLabels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView StudentView1;
        private System.Windows.Forms.ColumnHeader ממוצע;
        private System.Windows.Forms.ColumnHeader תכנות;
        private System.Windows.Forms.ColumnHeader פיזיקה;
        private System.Windows.Forms.ColumnHeader לשון;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTxtBox;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox PhoneNumTextBox;
        public System.Windows.Forms.TextBox MathTextBox;
        public System.Windows.Forms.TextBox EnglishTextBox;
        public System.Windows.Forms.TextBox HebrewTextBox;
        public System.Windows.Forms.TextBox PhysicsTextBox;
        public System.Windows.Forms.TextBox SoftwereTextBox;
        private System.Windows.Forms.Label errorlable;
        private System.Windows.Forms.Button cleanbtn;
        private System.Windows.Forms.Label NameErrorLable;
        private System.Windows.Forms.Label LastNameErrorLable;
        private System.Windows.Forms.Label IDErrorLable;
        private System.Windows.Forms.Label EmailErrorLable;
        private System.Windows.Forms.Label PhoneErrorLable;
        private System.Windows.Forms.ColumnHeader אנגלית;
        private System.Windows.Forms.ColumnHeader מתמטיקה;
        private System.Windows.Forms.ColumnHeader טלפון;
        private System.Windows.Forms.ColumnHeader אימייל;
        private System.Windows.Forms.ColumnHeader תעודתזהות;
        private System.Windows.Forms.ColumnHeader שםמלא;
        private System.Windows.Forms.Label GradesErrorLabel;
        private System.Windows.Forms.PictureBox AddStudentBtn1;
        private System.Windows.Forms.PictureBox addRandomBtn1;
        private System.Windows.Forms.PictureBox SortBtn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

