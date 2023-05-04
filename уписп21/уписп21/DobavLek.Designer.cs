
namespace уписп21
{
    partial class DobavLek
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
            System.Windows.Forms.Label iD_lekarctvaLabel;
            System.Windows.Forms.Label name_lekarctvaLabel;
            System.Windows.Forms.Label inctrukciaLabel;
            System.Windows.Forms.Label date_new_priemLabel;
            System.Windows.Forms.Label date_old_priemLabel;
            this.уП_ИСП21DataSet = new уписп21.УП_ИСП21DataSet();
            this.lekarctvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekarctvaTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.lekarctvaTableAdapter();
            this.tableAdapterManager = new уписп21.УП_ИСП21DataSetTableAdapters.TableAdapterManager();
            this.iD_lekarctvaTextBox = new System.Windows.Forms.TextBox();
            this.name_lekarctvaTextBox = new System.Windows.Forms.TextBox();
            this.inctrukciaTextBox = new System.Windows.Forms.TextBox();
            this.date_new_priemDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_old_priemDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            iD_lekarctvaLabel = new System.Windows.Forms.Label();
            name_lekarctvaLabel = new System.Windows.Forms.Label();
            inctrukciaLabel = new System.Windows.Forms.Label();
            date_new_priemLabel = new System.Windows.Forms.Label();
            date_old_priemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ИСП21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarctvaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_lekarctvaLabel
            // 
            iD_lekarctvaLabel.AutoSize = true;
            iD_lekarctvaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_lekarctvaLabel.Location = new System.Drawing.Point(457, 304);
            iD_lekarctvaLabel.Name = "iD_lekarctvaLabel";
            iD_lekarctvaLabel.Size = new System.Drawing.Size(72, 45);
            iD_lekarctvaLabel.TabIndex = 1;
            iD_lekarctvaLabel.Text = "ID :";
            // 
            // name_lekarctvaLabel
            // 
            name_lekarctvaLabel.AutoSize = true;
            name_lekarctvaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_lekarctvaLabel.Location = new System.Drawing.Point(320, 375);
            name_lekarctvaLabel.Name = "name_lekarctvaLabel";
            name_lekarctvaLabel.Size = new System.Drawing.Size(209, 45);
            name_lekarctvaLabel.TabIndex = 3;
            name_lekarctvaLabel.Text = "Название :";
            // 
            // inctrukciaLabel
            // 
            inctrukciaLabel.AutoSize = true;
            inctrukciaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inctrukciaLabel.Location = new System.Drawing.Point(286, 448);
            inctrukciaLabel.Name = "inctrukciaLabel";
            inctrukciaLabel.Size = new System.Drawing.Size(243, 45);
            inctrukciaLabel.TabIndex = 5;
            inctrukciaLabel.Text = "Инструкция :";
            // 
            // date_new_priemLabel
            // 
            date_new_priemLabel.AutoSize = true;
            date_new_priemLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_new_priemLabel.Location = new System.Drawing.Point(219, 518);
            date_new_priemLabel.Name = "date_new_priemLabel";
            date_new_priemLabel.Size = new System.Drawing.Size(310, 45);
            date_new_priemLabel.TabIndex = 7;
            date_new_priemLabel.Text = "Начало приема :";
            // 
            // date_old_priemLabel
            // 
            date_old_priemLabel.AutoSize = true;
            date_old_priemLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_old_priemLabel.Location = new System.Drawing.Point(241, 586);
            date_old_priemLabel.Name = "date_old_priemLabel";
            date_old_priemLabel.Size = new System.Drawing.Size(288, 45);
            date_old_priemLabel.TabIndex = 9;
            date_old_priemLabel.Text = "Конец приема :";
            // 
            // уП_ИСП21DataSet
            // 
            this.уП_ИСП21DataSet.DataSetName = "УП_ИСП21DataSet";
            this.уП_ИСП21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lekarctvaBindingSource
            // 
            this.lekarctvaBindingSource.DataMember = "lekarctva";
            this.lekarctvaBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // lekarctvaTableAdapter
            // 
            this.lekarctvaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lekarctvaTableAdapter = this.lekarctvaTableAdapter;
            this.tableAdapterManager.med_kartaTableAdapter = null;
            this.tableAdapterManager.PacientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = уписп21.УП_ИСП21DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VrachTableAdapter = null;
            this.tableAdapterManager.zapicTableAdapter = null;
            // 
            // iD_lekarctvaTextBox
            // 
            this.iD_lekarctvaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iD_lekarctvaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekarctvaBindingSource, "ID_lekarctva", true));
            this.iD_lekarctvaTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_lekarctvaTextBox.Location = new System.Drawing.Point(573, 297);
            this.iD_lekarctvaTextBox.Name = "iD_lekarctvaTextBox";
            this.iD_lekarctvaTextBox.Size = new System.Drawing.Size(100, 52);
            this.iD_lekarctvaTextBox.TabIndex = 2;
            // 
            // name_lekarctvaTextBox
            // 
            this.name_lekarctvaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_lekarctvaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekarctvaBindingSource, "name_lekarctva", true));
            this.name_lekarctvaTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lekarctvaTextBox.Location = new System.Drawing.Point(573, 368);
            this.name_lekarctvaTextBox.Name = "name_lekarctvaTextBox";
            this.name_lekarctvaTextBox.Size = new System.Drawing.Size(355, 52);
            this.name_lekarctvaTextBox.TabIndex = 4;
            // 
            // inctrukciaTextBox
            // 
            this.inctrukciaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inctrukciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekarctvaBindingSource, "inctrukcia", true));
            this.inctrukciaTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inctrukciaTextBox.Location = new System.Drawing.Point(573, 441);
            this.inctrukciaTextBox.Name = "inctrukciaTextBox";
            this.inctrukciaTextBox.Size = new System.Drawing.Size(1041, 52);
            this.inctrukciaTextBox.TabIndex = 6;
            // 
            // date_new_priemDateTimePicker
            // 
            this.date_new_priemDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lekarctvaBindingSource, "date_new_priem", true));
            this.date_new_priemDateTimePicker.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_new_priemDateTimePicker.Location = new System.Drawing.Point(573, 511);
            this.date_new_priemDateTimePicker.Name = "date_new_priemDateTimePicker";
            this.date_new_priemDateTimePicker.Size = new System.Drawing.Size(355, 52);
            this.date_new_priemDateTimePicker.TabIndex = 8;
            // 
            // date_old_priemDateTimePicker
            // 
            this.date_old_priemDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lekarctvaBindingSource, "date_old_priem", true));
            this.date_old_priemDateTimePicker.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_old_priemDateTimePicker.Location = new System.Drawing.Point(573, 579);
            this.date_old_priemDateTimePicker.Name = "date_old_priemDateTimePicker";
            this.date_old_priemDateTimePicker.Size = new System.Drawing.Size(355, 52);
            this.date_old_priemDateTimePicker.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(810, 702);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 59);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1190, 702);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 59);
            this.button3.TabIndex = 13;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(726, 845);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(399, 59);
            this.button4.TabIndex = 14;
            this.button4.Text = "Вернутся назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(888, 62);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавление лекраственных средств";
            // 
            // DobavLek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(date_old_priemLabel);
            this.Controls.Add(this.date_old_priemDateTimePicker);
            this.Controls.Add(date_new_priemLabel);
            this.Controls.Add(this.date_new_priemDateTimePicker);
            this.Controls.Add(inctrukciaLabel);
            this.Controls.Add(this.inctrukciaTextBox);
            this.Controls.Add(name_lekarctvaLabel);
            this.Controls.Add(this.name_lekarctvaTextBox);
            this.Controls.Add(iD_lekarctvaLabel);
            this.Controls.Add(this.iD_lekarctvaTextBox);
            this.Name = "DobavLek";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DobavLek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.уП_ИСП21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarctvaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private УП_ИСП21DataSet уП_ИСП21DataSet;
        private System.Windows.Forms.BindingSource lekarctvaBindingSource;
        private УП_ИСП21DataSetTableAdapters.lekarctvaTableAdapter lekarctvaTableAdapter;
        private УП_ИСП21DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_lekarctvaTextBox;
        private System.Windows.Forms.TextBox name_lekarctvaTextBox;
        private System.Windows.Forms.TextBox inctrukciaTextBox;
        private System.Windows.Forms.DateTimePicker date_new_priemDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_old_priemDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}