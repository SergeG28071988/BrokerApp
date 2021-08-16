
namespace Broker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DividendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssuersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(81, 467);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.StocksToolStripMenuItem,
            this.DividendsToolStripMenuItem,
            this.IssuersToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmployeeToolStripMenuItem.Text = "Сотрудники";
            this.EmployeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // StocksToolStripMenuItem
            // 
            this.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem";
            this.StocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StocksToolStripMenuItem.Text = "Акции";
            this.StocksToolStripMenuItem.Click += new System.EventHandler(this.StocksToolStripMenuItem_Click);
            // 
            // DividendsToolStripMenuItem
            // 
            this.DividendsToolStripMenuItem.Name = "DividendsToolStripMenuItem";
            this.DividendsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DividendsToolStripMenuItem.Text = "Дивиденды";
            this.DividendsToolStripMenuItem.Click += new System.EventHandler(this.DividendsToolStripMenuItem_Click);
            // 
            // IssuersToolStripMenuItem
            // 
            this.IssuersToolStripMenuItem.Name = "IssuersToolStripMenuItem";
            this.IssuersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IssuersToolStripMenuItem.Text = "Эмитенты";
            this.IssuersToolStripMenuItem.Click += new System.EventHandler(this.IssuersToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Broker.Properties.Resources.sberbankinvestbro_min;
            this.pictureBox1.Location = new System.Drawing.Point(84, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сбербанк инвестиции";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssuersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DividendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem StocksToolStripMenuItem;
    }
}

