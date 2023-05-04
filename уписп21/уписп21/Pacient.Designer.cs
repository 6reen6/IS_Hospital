
namespace уписп21
{
    partial class Pacient
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
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП_ИСП21DataSet = new уписп21.УП_ИСП21DataSet();
            this.Poisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.med_kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medCartForPacientDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medCartForPacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medCartForPacientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lekarctvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pacientTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.PacientTableAdapter();
            this.tableAdapterManager = new уписп21.УП_ИСП21DataSetTableAdapters.TableAdapterManager();
            this.med_kartaTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.med_kartaTableAdapter();
            this.lekarctvaTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.lekarctvaTableAdapter();
            this.medCartForPacientTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.MedCartForPacientTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ИСП21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_kartaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medCartForPacientDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCartForPacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCartForPacientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarctvaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // уП_ИСП21DataSet
            // 
            this.уП_ИСП21DataSet.DataSetName = "УП_ИСП21DataSet";
            this.уП_ИСП21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Poisk
            // 
            this.Poisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Poisk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Poisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Poisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Poisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Poisk.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poisk.Location = new System.Drawing.Point(403, 107);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(129, 42);
            this.Poisk.TabIndex = 1;
            this.Poisk.Text = "Поиск";
            this.Poisk.UseVisualStyleBackColor = false;
            this.Poisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(199, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // med_kartaBindingSource
            // 
            this.med_kartaBindingSource.DataMember = "FK_med_karta_Pacient";
            this.med_kartaBindingSource.DataSource = this.pacientBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.medCartForPacientDataGridView1);
            this.groupBox1.Controls.Add(this.medCartForPacientDataGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1880, 794);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Медецинская карта";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // medCartForPacientDataGridView1
            // 
            this.medCartForPacientDataGridView1.AllowUserToAddRows = false;
            this.medCartForPacientDataGridView1.AllowUserToDeleteRows = false;
            this.medCartForPacientDataGridView1.AutoGenerateColumns = false;
            this.medCartForPacientDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.medCartForPacientDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medCartForPacientDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.medCartForPacientDataGridView1.DataSource = this.medCartForPacientBindingSource;
            this.medCartForPacientDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.medCartForPacientDataGridView1.Location = new System.Drawing.Point(1149, 33);
            this.medCartForPacientDataGridView1.Name = "medCartForPacientDataGridView1";
            this.medCartForPacientDataGridView1.ReadOnly = true;
            this.medCartForPacientDataGridView1.Size = new System.Drawing.Size(725, 755);
            this.medCartForPacientDataGridView1.TabIndex = 4;
            this.medCartForPacientDataGridView1.Visible = false;
            this.medCartForPacientDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medCartForPacientDataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "fam_vrach";
            this.dataGridViewTextBoxColumn27.HeaderText = "Фамилия врача";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "name_lekarctva";
            this.dataGridViewTextBoxColumn35.HeaderText = "Название";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 150;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "inctrukcia";
            this.dataGridViewTextBoxColumn36.HeaderText = "Инструкция";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Width = 230;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "date_new_priem";
            this.dataGridViewTextBoxColumn37.HeaderText = "Начало приема";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "date_old_priem";
            this.dataGridViewTextBoxColumn38.HeaderText = "Конец приема";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // medCartForPacientBindingSource
            // 
            this.medCartForPacientBindingSource.DataMember = "MedCartForPacient";
            this.medCartForPacientBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // medCartForPacientDataGridView
            // 
            this.medCartForPacientDataGridView.AllowUserToAddRows = false;
            this.medCartForPacientDataGridView.AllowUserToDeleteRows = false;
            this.medCartForPacientDataGridView.AutoGenerateColumns = false;
            this.medCartForPacientDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.medCartForPacientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medCartForPacientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.medCartForPacientDataGridView.DataSource = this.medCartForPacientBindingSource;
            this.medCartForPacientDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.medCartForPacientDataGridView.Location = new System.Drawing.Point(6, 33);
            this.medCartForPacientDataGridView.Name = "medCartForPacientDataGridView";
            this.medCartForPacientDataGridView.ReadOnly = true;
            this.medCartForPacientDataGridView.Size = new System.Drawing.Size(1137, 755);
            this.medCartForPacientDataGridView.TabIndex = 4;
            this.medCartForPacientDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fam_vrach";
            this.dataGridViewTextBoxColumn8.HeaderText = "Фамилия врача";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date_cozdania";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата создания";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "anamnes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Анамнес";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 220;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "diagnoz";
            this.dataGridViewTextBoxColumn13.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "plan_lehenia";
            this.dataGridViewTextBoxColumn14.HeaderText = "План лечения";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 310;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "zametki";
            this.dataGridViewTextBoxColumn15.HeaderText = "Заметки";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1144, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лекартсвенные средства";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lekarctvaBindingSource
            // 
            this.lekarctvaBindingSource.DataMember = "lekarctva";
            this.lekarctvaBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1396, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перейти в главное меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lekarctvaTableAdapter = null;
            this.tableAdapterManager.med_kartaTableAdapter = this.med_kartaTableAdapter;
            this.tableAdapterManager.PacientTableAdapter = this.pacientTableAdapter;
            this.tableAdapterManager.UpdateOrder = уписп21.УП_ИСП21DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VrachTableAdapter = null;
            this.tableAdapterManager.zapicTableAdapter = null;
            // 
            // med_kartaTableAdapter
            // 
            this.med_kartaTableAdapter.ClearBeforeFill = true;
            // 
            // lekarctvaTableAdapter
            // 
            this.lekarctvaTableAdapter.ClearBeforeFill = true;
            // 
            // medCartForPacientTableAdapter
            // 
            this.medCartForPacientTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(722, 62);
            this.label2.TabIndex = 8;
            this.label2.Text = "Медицинская карта пациента";
            // 
            // Pacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pacient";
            this.Text = "пациенты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ИСП21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_kartaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medCartForPacientDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCartForPacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medCartForPacientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarctvaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private УП_ИСП21DataSet уП_ИСП21DataSet;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private УП_ИСП21DataSetTableAdapters.PacientTableAdapter pacientTableAdapter;
        private УП_ИСП21DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private УП_ИСП21DataSetTableAdapters.med_kartaTableAdapter med_kartaTableAdapter;
        private System.Windows.Forms.BindingSource med_kartaBindingSource;
        private System.Windows.Forms.Button Poisk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource lekarctvaBindingSource;
        private УП_ИСП21DataSetTableAdapters.lekarctvaTableAdapter lekarctvaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource medCartForPacientBindingSource;
        private УП_ИСП21DataSetTableAdapters.MedCartForPacientTableAdapter medCartForPacientTableAdapter;
        private System.Windows.Forms.DataGridView medCartForPacientDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridView medCartForPacientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label label2;
    }
}