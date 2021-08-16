
namespace Broker
{
    partial class ClientForm
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
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sberbankDataSet = new Broker.SberbankDataSet();
            this.клиентыTableAdapter = new Broker.SberbankDataSetTableAdapters.КлиентыTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editSurnameBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editPhoneBtn = new System.Windows.Forms.Button();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.returnEmployeeBtn = new System.Windows.Forms.Button();
            this.returnMenuBtn = new System.Windows.Forms.Button();
            this.StocksBtn = new System.Windows.Forms.Button();
            this.DividendsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.sberbankDataSet;
            // 
            // sberbankDataSet
            // 
            this.sberbankDataSet.DataSetName = "SberbankDataSet";
            this.sberbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код клиента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(27, 343);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editSurnameBtn
            // 
            this.editSurnameBtn.Location = new System.Drawing.Point(142, 343);
            this.editSurnameBtn.Name = "editSurnameBtn";
            this.editSurnameBtn.Size = new System.Drawing.Size(209, 23);
            this.editSurnameBtn.TabIndex = 6;
            this.editSurnameBtn.Text = "Изменить фамилию";
            this.editSurnameBtn.UseVisualStyleBackColor = true;
            this.editSurnameBtn.Click += new System.EventHandler(this.editSurnameBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код клиента";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(215, 316);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(136, 20);
            this.tbSurname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(355, 316);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(136, 20);
            this.tbPhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Телефон";
            // 
            // editPhoneBtn
            // 
            this.editPhoneBtn.Location = new System.Drawing.Point(355, 343);
            this.editPhoneBtn.Name = "editPhoneBtn";
            this.editPhoneBtn.Size = new System.Drawing.Size(136, 23);
            this.editPhoneBtn.TabIndex = 11;
            this.editPhoneBtn.Text = "Изменить телефон";
            this.editPhoneBtn.UseVisualStyleBackColor = true;
            this.editPhoneBtn.Click += new System.EventHandler(this.editPhoneBtn_Click);
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(601, 82);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(198, 33);
            this.addClientBtn.TabIndex = 12;
            this.addClientBtn.Text = "Добавить клиента";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(601, 131);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(198, 33);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(601, 179);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(198, 33);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // returnEmployeeBtn
            // 
            this.returnEmployeeBtn.Location = new System.Drawing.Point(601, 338);
            this.returnEmployeeBtn.Name = "returnEmployeeBtn";
            this.returnEmployeeBtn.Size = new System.Drawing.Size(198, 33);
            this.returnEmployeeBtn.TabIndex = 15;
            this.returnEmployeeBtn.Text = "Вернуться к сотрудникам";
            this.returnEmployeeBtn.UseVisualStyleBackColor = true;
            this.returnEmployeeBtn.Click += new System.EventHandler(this.returnEmployeeBtn_Click);
            // 
            // returnMenuBtn
            // 
            this.returnMenuBtn.Location = new System.Drawing.Point(601, 388);
            this.returnMenuBtn.Name = "returnMenuBtn";
            this.returnMenuBtn.Size = new System.Drawing.Size(198, 33);
            this.returnMenuBtn.TabIndex = 16;
            this.returnMenuBtn.Text = "Вернуться в главное меню";
            this.returnMenuBtn.UseVisualStyleBackColor = true;
            this.returnMenuBtn.Click += new System.EventHandler(this.returnMenuBtn_Click);
            // 
            // StocksBtn
            // 
            this.StocksBtn.Location = new System.Drawing.Point(601, 236);
            this.StocksBtn.Name = "StocksBtn";
            this.StocksBtn.Size = new System.Drawing.Size(198, 33);
            this.StocksBtn.TabIndex = 17;
            this.StocksBtn.Text = "Портфель акций";
            this.StocksBtn.UseVisualStyleBackColor = true;
            this.StocksBtn.Click += new System.EventHandler(this.StocksBtn_Click);
            // 
            // DividendsBtn
            // 
            this.DividendsBtn.Location = new System.Drawing.Point(601, 280);
            this.DividendsBtn.Name = "DividendsBtn";
            this.DividendsBtn.Size = new System.Drawing.Size(198, 33);
            this.DividendsBtn.TabIndex = 18;
            this.DividendsBtn.Text = "Дивиденды";
            this.DividendsBtn.UseVisualStyleBackColor = true;
            this.DividendsBtn.Click += new System.EventHandler(this.DividendsBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 443);
            this.Controls.Add(this.DividendsBtn);
            this.Controls.Add(this.StocksBtn);
            this.Controls.Add(this.returnMenuBtn);
            this.Controls.Add(this.returnEmployeeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.editPhoneBtn);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editSurnameBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SberbankDataSet sberbankDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private SberbankDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editSurnameBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editPhoneBtn;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button returnEmployeeBtn;
        private System.Windows.Forms.Button returnMenuBtn;
        private System.Windows.Forms.Button StocksBtn;
        private System.Windows.Forms.Button DividendsBtn;
    }
}