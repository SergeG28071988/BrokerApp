
namespace Broker
{
    partial class IssuersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sberbankDataSet = new Broker.SberbankDataSet();
            this.эмитентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.эмитентыTableAdapter = new Broker.SberbankDataSetTableAdapters.ЭмитентыTableAdapter();
            this.кодЭмитентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дивидендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.эмитентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЭмитентаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.дивидендыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.эмитентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // sberbankDataSet
            // 
            this.sberbankDataSet.DataSetName = "SberbankDataSet";
            this.sberbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // эмитентыBindingSource
            // 
            this.эмитентыBindingSource.DataMember = "Эмитенты";
            this.эмитентыBindingSource.DataSource = this.sberbankDataSet;
            // 
            // эмитентыTableAdapter
            // 
            this.эмитентыTableAdapter.ClearBeforeFill = true;
            // 
            // кодЭмитентаDataGridViewTextBoxColumn
            // 
            this.кодЭмитентаDataGridViewTextBoxColumn.DataPropertyName = "Код эмитента";
            this.кодЭмитентаDataGridViewTextBoxColumn.HeaderText = "Код эмитента";
            this.кодЭмитентаDataGridViewTextBoxColumn.Name = "кодЭмитентаDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // дивидендыDataGridViewTextBoxColumn
            // 
            this.дивидендыDataGridViewTextBoxColumn.DataPropertyName = "Дивиденды";
            this.дивидендыDataGridViewTextBoxColumn.HeaderText = "Дивиденды";
            this.дивидендыDataGridViewTextBoxColumn.Name = "дивидендыDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код эмитента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(462, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дивиденды";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(376, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Назад в меню";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IssuersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 349);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IssuersForm";
            this.Text = "Эмитенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IssuersForm_FormClosing);
            this.Load += new System.EventHandler(this.IssuersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.эмитентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SberbankDataSet sberbankDataSet;
        private System.Windows.Forms.BindingSource эмитентыBindingSource;
        private SberbankDataSetTableAdapters.ЭмитентыTableAdapter эмитентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЭмитентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дивидендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}