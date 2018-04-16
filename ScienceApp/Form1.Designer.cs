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
            this.экспериментСИндексамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хранимыеПроцедурыБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспериментыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(641, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // экспериментыToolStripMenuItem
            // 
            this.экспериментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЭкспериментToolStripMenuItem,
            this.историяЭкспериментовToolStripMenuItem,
            this.экспериментСИндексамиToolStripMenuItem});
            this.экспериментыToolStripMenuItem.Name = "экспериментыToolStripMenuItem";
            this.экспериментыToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.экспериментыToolStripMenuItem.Text = "Эксперименты";
            // 
            // новыйЭкспериментToolStripMenuItem
            // 
            this.новыйЭкспериментToolStripMenuItem.Name = "новыйЭкспериментToolStripMenuItem";
            this.новыйЭкспериментToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.новыйЭкспериментToolStripMenuItem.Text = "Эксперимент с запросами";
            this.новыйЭкспериментToolStripMenuItem.Click += new System.EventHandler(this.новыйЭкспериментToolStripMenuItem_Click);
            // 
            // историяЭкспериментовToolStripMenuItem
            // 
            this.историяЭкспериментовToolStripMenuItem.Name = "историяЭкспериментовToolStripMenuItem";
            this.историяЭкспериментовToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.историяЭкспериментовToolStripMenuItem.Text = "Эксперимент с хранимками";
            this.историяЭкспериментовToolStripMenuItem.Click += new System.EventHandler(this.историяЭкспериментовToolStripMenuItem_Click);
            // 
            // экспериментСИндексамиToolStripMenuItem
            // 
            this.экспериментСИндексамиToolStripMenuItem.Name = "экспериментСИндексамиToolStripMenuItem";
            this.экспериментСИндексамиToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.экспериментСИндексамиToolStripMenuItem.Text = "Эксперимент с индексами";
            this.экспериментСИндексамиToolStripMenuItem.Click += new System.EventHandler(this.экспериментСИндексамиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem,
            this.справочникиБДToolStripMenuItem,
            this.хранимыеПроцедурыБДToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.подключениеКБДToolStripMenuItem.Text = "Настройки подключения к БД";
            this.подключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБДToolStripMenuItem_Click);
            // 
            // справочникиБДToolStripMenuItem
            // 
            this.справочникиБДToolStripMenuItem.Name = "справочникиБДToolStripMenuItem";
            this.справочникиБДToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.справочникиБДToolStripMenuItem.Text = "Справочники БД";
            this.справочникиБДToolStripMenuItem.Click += new System.EventHandler(this.справочникиБДToolStripMenuItem_Click);
            // 
            // хранимыеПроцедурыБДToolStripMenuItem
            // 
            this.хранимыеПроцедурыБДToolStripMenuItem.Name = "хранимыеПроцедурыБДToolStripMenuItem";
            this.хранимыеПроцедурыБДToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.хранимыеПроцедурыБДToolStripMenuItem.Text = "Хранимые процедуры БД";
            this.хранимыеПроцедурыБДToolStripMenuItem.Click += new System.EventHandler(this.хранимыеПроцедурыБДToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспериментСИндексамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хранимыеПроцедурыБДToolStripMenuItem;
    }
}

