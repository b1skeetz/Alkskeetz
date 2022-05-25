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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(71, 48);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(307, 45);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Добро Пожаловать";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 93);
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
            this.radioButton1.Location = new System.Drawing.Point(106, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 19);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.Text = "Клиент";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(238, 145);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьТаблицуToolStripMenuItem,
            this.удалитьТаблицуToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // создатьТаблицуToolStripMenuItem
            // 
            this.создатьТаблицуToolStripMenuItem.Name = "создатьТаблицуToolStripMenuItem";
            this.создатьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.создатьТаблицуToolStripMenuItem.Text = "Создать таблицу";
            this.создатьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.создатьТаблицуToolStripMenuItem_Click);
            // 
            // удалитьТаблицуToolStripMenuItem
            // 
            this.удалитьТаблицуToolStripMenuItem.Name = "удалитьТаблицуToolStripMenuItem";
            this.удалитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.удалитьТаблицуToolStripMenuItem.Text = "Удалить таблицу";
            this.удалитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.удалитьТаблицуToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem базаДанныхToolStripMenuItem;
        private ToolStripMenuItem создатьТаблицуToolStripMenuItem;
        private ToolStripMenuItem удалитьТаблицуToolStripMenuItem;
    }
}