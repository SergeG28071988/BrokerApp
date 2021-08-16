
namespace Broker
{
    partial class StocksForm
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
            this.components = new System.ComponentModel.Container();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.returnClientsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchClientBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sberbankDataSet = new Broker.SberbankDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.акцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.акцииTableAdapter = new Broker.SberbankDataSetTableAdapters.АкцииTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.кодАкцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.операцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(19, 33);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(198, 35);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(19, 83);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(198, 35);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(19, 137);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(198, 35);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Поиск по сделкам";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // returnClientsBtn
            // 
            this.returnClientsBtn.Location = new System.Drawing.Point(19, 257);
            this.returnClientsBtn.Name = "returnClientsBtn";
            this.returnClientsBtn.Size = new System.Drawing.Size(198, 35);
            this.returnClientsBtn.TabIndex = 5;
            this.returnClientsBtn.Text = "Назад к клиентам";
            this.returnClientsBtn.UseVisualStyleBackColor = true;
            this.returnClientsBtn.Click += new System.EventHandler(this.returnClientsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchClientBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.returnClientsBtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Location = new System.Drawing.Point(969, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 371);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // SearchClientBtn
            // 
            this.SearchClientBtn.Location = new System.Drawing.Point(19, 188);
            this.SearchClientBtn.Name = "SearchClientBtn";
            this.SearchClientBtn.Size = new System.Drawing.Size(198, 35);
            this.SearchClientBtn.TabIndex = 7;
            this.SearchClientBtn.Text = "Поиск по по клиентамм";
            this.SearchClientBtn.UseVisualStyleBackColor = true;
            this.SearchClientBtn.Click += new System.EventHandler(this.SearchClientBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад в меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sberbankDataSet
            // 
            this.sberbankDataSet.DataSetName = "SberbankDataSet";
            this.sberbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАкцииDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.операцииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.акцииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(946, 391);
            this.dataGridView1.TabIndex = 7;
            // 
            // акцииBindingSource
            // 
            this.акцииBindingSource.DataMember = "Акции";
            this.акцииBindingSource.DataSource = this.sberbankDataSet;
            // 
            // акцииTableAdapter
            // 
            this.акцииTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Код акции";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 472);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Наименование";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 471);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить наименование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(609, 468);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Описание";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Изменить описание";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Изменить цену";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(830, 468);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1028, 499);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Изменить количество";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1097, 468);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 20);
            this.textBox5.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1025, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Количество";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 575);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Изменить сумму";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(54, 544);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(189, 20);
            this.textBox6.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Сумма";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*"});
            this.comboBox1.Location = new System.Drawing.Point(265, 544);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(265, 575);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Пересчитать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(497, 571);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(236, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Изменить  вид операции";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Операции";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "покупка",
            "продажа"});
            this.comboBox2.Location = new System.Drawing.Point(558, 538);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(824, 540);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 20);
            this.textBox7.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(759, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Код акции";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(762, 572);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 23);
            this.button9.TabIndex = 33;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1028, 557);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(236, 50);
            this.button10.TabIndex = 34;
            this.button10.Text = "Очистить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Дата";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 499);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(309, 23);
            this.button11.TabIndex = 37;
            this.button11.Text = "Изменить дату";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 472);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // кодАкцииDataGridViewTextBoxColumn
            // 
            this.кодАкцииDataGridViewTextBoxColumn.DataPropertyName = "Код акции";
            this.кодАкцииDataGridViewTextBoxColumn.HeaderText = "Код акции";
            this.кодАкцииDataGridViewTextBoxColumn.Name = "кодАкцииDataGridViewTextBoxColumn";
            this.кодАкцииDataGridViewTextBoxColumn.Width = 80;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            this.кодКлиентаDataGridViewTextBoxColumn.Width = 80;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // операцииDataGridViewTextBoxColumn
            // 
            this.операцииDataGridViewTextBoxColumn.DataPropertyName = "Операции";
            this.операцииDataGridViewTextBoxColumn.HeaderText = "Операции";
            this.операцииDataGridViewTextBoxColumn.Name = "операцииDataGridViewTextBoxColumn";
            // 
            // StocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 642);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StocksForm";
            this.Text = "Портфель акций клиентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StocksForm_FormClosing);
            this.Load += new System.EventHandler(this.StocksForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SberbankDataSet sberbankDataSet;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button returnClientsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource акцииBindingSource;
        private SberbankDataSetTableAdapters.АкцииTableAdapter акцииTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button SearchClientBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАкцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn операцииDataGridViewTextBoxColumn;
    }
}