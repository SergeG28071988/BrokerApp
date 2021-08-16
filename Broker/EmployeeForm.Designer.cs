
namespace Broker
{
    partial class EmployeeForm
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
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sberbankDataSet = new Broker.SberbankDataSet();
            this.сотрудникиTableAdapter = new Broker.SberbankDataSetTableAdapters.СотрудникиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.EditSurnamBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditPhoneBtn = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditPosBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.BtnAddEmp = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 192);
            this.dataGridView1.TabIndex = 0;
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
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.sberbankDataSet;
            // 
            // sberbankDataSet
            // 
            this.sberbankDataSet.DataSetName = "SberbankDataSet";
            this.sberbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код сотрудника";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(21, 331);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(111, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // EditSurnamBtn
            // 
            this.EditSurnamBtn.Location = new System.Drawing.Point(141, 331);
            this.EditSurnamBtn.Name = "EditSurnamBtn";
            this.EditSurnamBtn.Size = new System.Drawing.Size(273, 23);
            this.EditSurnamBtn.TabIndex = 6;
            this.EditSurnamBtn.Text = "Изменить фамилию";
            this.EditSurnamBtn.UseVisualStyleBackColor = true;
            this.EditSurnamBtn.Click += new System.EventHandler(this.EditSurnamBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код сотрудника";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(263, 304);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(151, 20);
            this.tbSurname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // EditPhoneBtn
            // 
            this.EditPhoneBtn.Location = new System.Drawing.Point(21, 415);
            this.EditPhoneBtn.Name = "EditPhoneBtn";
            this.EditPhoneBtn.Size = new System.Drawing.Size(194, 23);
            this.EditPhoneBtn.TabIndex = 11;
            this.EditPhoneBtn.Text = "Изменить телефон";
            this.EditPhoneBtn.UseVisualStyleBackColor = true;
            this.EditPhoneBtn.Click += new System.EventHandler(this.EditPhoneBtn_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(21, 388);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(194, 20);
            this.tbPhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Телефон";
            // 
            // EditPosBtn
            // 
            this.EditPosBtn.Location = new System.Drawing.Point(244, 415);
            this.EditPosBtn.Name = "EditPosBtn";
            this.EditPosBtn.Size = new System.Drawing.Size(170, 23);
            this.EditPosBtn.TabIndex = 14;
            this.EditPosBtn.Text = "Изменить должность";
            this.EditPosBtn.UseVisualStyleBackColor = true;
            this.EditPosBtn.Click += new System.EventHandler(this.EditPosBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Должность";
            // 
            // cbPos
            // 
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Items.AddRange(new object[] {
            "Менеджер",
            "Аналитик",
            "Старший аналитик",
            "Трейдер"});
            this.cbPos.Location = new System.Drawing.Point(244, 389);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(170, 21);
            this.cbPos.TabIndex = 15;
            // 
            // BtnAddEmp
            // 
            this.BtnAddEmp.Location = new System.Drawing.Point(571, 76);
            this.BtnAddEmp.Name = "BtnAddEmp";
            this.BtnAddEmp.Size = new System.Drawing.Size(220, 55);
            this.BtnAddEmp.TabIndex = 16;
            this.BtnAddEmp.Text = "Добавить сотрудника";
            this.BtnAddEmp.UseVisualStyleBackColor = true;
            this.BtnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(571, 154);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(220, 45);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "Обновить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(571, 383);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(220, 44);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Назад в меню";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(571, 218);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(220, 45);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(571, 306);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(220, 45);
            this.clientBtn.TabIndex = 20;
            this.clientBtn.Text = "Клиенты ";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 455);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddEmp);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.EditPosBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditPhoneBtn);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditSurnamBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sberbankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SberbankDataSet sberbankDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private SberbankDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button EditSurnamBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditPhoneBtn;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditPosBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPos;
        private System.Windows.Forms.Button BtnAddEmp;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button clientBtn;
    }
}