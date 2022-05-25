namespace WinFormsApp1
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
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(80, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(307, 45);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Добро Пожаловать";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Войдите или зарегистрируйтесь";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(253, 210);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(131, 51);
            this.button_login.TabIndex = 16;
            this.button_login.Text = "Зарегистрироваться";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(106, 124);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 19);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.Text = "Клиент";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(238, 124);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 19);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Риелтор";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private Label label1;
        private Button button_login;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}