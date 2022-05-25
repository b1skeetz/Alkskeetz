namespace WinFormsApp1
{
    partial class FormEditingProfile
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
            this.label_title = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(1, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(373, 41);
            this.label_title.TabIndex = 36;
            this.label_title.Text = "Редактирование профиль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Фамилия:";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(104, 196);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(226, 23);
            this.textBox_Number.TabIndex = 30;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(104, 163);
            this.textBox_Phone.MaxLength = 12;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(226, 23);
            this.textBox_Phone.TabIndex = 29;
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Location = new System.Drawing.Point(103, 130);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(226, 23);
            this.textBox_Lastname.TabIndex = 28;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(103, 98);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(226, 23);
            this.textBox_Name.TabIndex = 27;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(103, 69);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(226, 23);
            this.textBox_Surname.TabIndex = 26;
            // 
            // buttonEditing
            // 
            this.buttonEditing.Location = new System.Drawing.Point(104, 299);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(187, 74);
            this.buttonEditing.TabIndex = 37;
            this.buttonEditing.Text = "Изменить";
            this.buttonEditing.UseVisualStyleBackColor = true;
            this.buttonEditing.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // FormEditingProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.buttonEditing);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Surname);
            this.Name = "FormEditingProfile";
            this.Text = "FormEditingProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_Number;
        private TextBox textBox_Phone;
        private TextBox textBox_Lastname;
        private TextBox textBox_Name;
        private TextBox textBox_Surname;
        private Button buttonEditing;
    }
}