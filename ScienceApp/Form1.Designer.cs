namespace ScienceApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.экспериментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЭкспериментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЭкспериментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспериментыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // экспериментыToolStripMenuItem
            // 
            this.экспериментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЭкспериментToolStripMenuItem,
            this.историяЭкспериментовToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.экспериментыToolStripMenuItem.Name = "экспериментыToolStripMenuItem";
            this.экспериментыToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.экспериментыToolStripMenuItem.Text = "Эксперименты";
            // 
            // новыйЭкспериментToolStripMenuItem
            // 
            this.новыйЭкспериментToolStripMenuItem.Name = "новыйЭкспериментToolStripMenuItem";
            this.новыйЭкспериментToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.новыйЭкспериментToolStripMenuItem.Text = "Новый эксперимент";
            this.новыйЭкспериментToolStripMenuItem.Click += new System.EventHandler(this.новыйЭкспериментToolStripMenuItem_Click);
            // 
            // историяЭкспериментовToolStripMenuItem
            // 
            this.историяЭкспериментовToolStripMenuItem.Name = "историяЭкспериментовToolStripMenuItem";
            this.историяЭкспериментовToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.историяЭкспериментовToolStripMenuItem.Text = "История экспериментов";
            this.историяЭкспериментовToolStripMenuItem.Click += new System.EventHandler(this.историяЭкспериментовToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.подключениеКБДToolStripMenuItem.Text = "Настройки подключения к БД";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 407);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Диссер 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem экспериментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЭкспериментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЭкспериментовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
    }
}

