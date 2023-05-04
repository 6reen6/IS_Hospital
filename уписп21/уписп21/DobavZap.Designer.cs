
namespace уписп21
{
    partial class DobavZap
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
            System.Windows.Forms.Label iD_med_kartaLabel;
            System.Windows.Forms.Label iD_pacientLabel;
            System.Windows.Forms.Label iD_vrahLabel;
            System.Windows.Forms.Label date_cozdaniaLabel;
            System.Windows.Forms.Label anamnesLabel;
            System.Windows.Forms.Label diagnozLabel;
            System.Windows.Forms.Label plan_leheniaLabel;
            System.Windows.Forms.Label iD_lekarctvaLabel;
            System.Windows.Forms.Label zametkiLabel;
            System.Windows.Forms.Label iD_zapicLabel;
            this.уП_ИСП21DataSet = new уписп21.УП_ИСП21DataSet();
            this.med_kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_kartaTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.med_kartaTableAdapter();
            this.tableAdapterManager = new уписп21.УП_ИСП21DataSetTableAdapters.TableAdapterManager();
            this.lekarctvaTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.lekarctvaTableAdapter();
            this.pacientTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.PacientTableAdapter();
            this.iD_med_kartaTextBox = new System.Windows.Forms.TextBox();
            this.iD_pacientListBox = new System.Windows.Forms.ListBox();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_vrahListBox = new System.Windows.Forms.ListBox();
            this.vrachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_cozdaniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anamnesTextBox = new System.Windows.Forms.TextBox();
            this.diagnozTextBox = new System.Windows.Forms.TextBox();
            this.plan_leheniaTextBox = new System.Windows.Forms.TextBox();
            this.iD_lekarctvaListBox = new System.Windows.Forms.ListBox();
            this.lekarctvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zametkiTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vrachTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.VrachTableAdapter();
            this.iD_zapicListBox = new System.Windows.Forms.ListBox();
            this.zapicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapicTableAdapter = new уписп21.УП_ИСП21DataSetTableAdapters.zapicTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iD_med_kartaLabel = new System.Windows.Forms.Label();
            iD_pacientLabel = new System.Windows.Forms.Label();
            iD_vrahLabel = new System.Windows.Forms.Label();
            date_cozdaniaLabel = new System.Windows.Forms.Label();
            anamnesLabel = new System.Windows.Forms.Label();
            diagnozLabel = new System.Windows.Forms.Label();
            plan_leheniaLabel = new System.Windows.Forms.Label();
            iD_lekarctvaLabel = new System.Windows.Forms.Label();
            zametkiLabel = new System.Windows.Forms.Label();
            iD_zapicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ИСП21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarctvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_med_kartaLabel
            // 
            iD_med_kartaLabel.AutoSize = true;
            iD_med_kartaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_med_kartaLabel.Location = new System.Drawing.Point(525, 239);
            iD_med_kartaLabel.Name = "iD_med_kartaLabel";
            iD_med_kartaLabel.Size = new System.Drawing.Size(74, 47);
            iD_med_kartaLabel.TabIndex = 1;
            iD_med_kartaLabel.Text = "ID :";
            iD_med_kartaLabel.Click += new System.EventHandler(this.iD_med_kartaLabel_Click);
            // 
            // iD_pacientLabel
            // 
            iD_pacientLabel.AutoSize = true;
            iD_pacientLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_pacientLabel.Location = new System.Drawing.Point(226, 311);
            iD_pacientLabel.Name = "iD_pacientLabel";
            iD_pacientLabel.Size = new System.Drawing.Size(373, 47);
            iD_pacientLabel.TabIndex = 3;
            iD_pacientLabel.Text = "Фамилия пациента :";
            // 
            // iD_vrahLabel
            // 
            iD_vrahLabel.AutoSize = true;
            iD_vrahLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_vrahLabel.Location = new System.Drawing.Point(287, 378);
            iD_vrahLabel.Name = "iD_vrahLabel";
            iD_vrahLabel.Size = new System.Drawing.Size(312, 47);
            iD_vrahLabel.TabIndex = 5;
            iD_vrahLabel.Text = "Фамилия врача :";
            // 
            // date_cozdaniaLabel
            // 
            date_cozdaniaLabel.AutoSize = true;
            date_cozdaniaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_cozdaniaLabel.Location = new System.Drawing.Point(167, 449);
            date_cozdaniaLabel.Name = "date_cozdaniaLabel";
            date_cozdaniaLabel.Size = new System.Drawing.Size(432, 47);
            date_cozdaniaLabel.TabIndex = 7;
            date_cozdaniaLabel.Text = "Дата создания записи :";
            // 
            // anamnesLabel
            // 
            anamnesLabel.AutoSize = true;
            anamnesLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anamnesLabel.Location = new System.Drawing.Point(407, 521);
            anamnesLabel.Name = "anamnesLabel";
            anamnesLabel.Size = new System.Drawing.Size(192, 47);
            anamnesLabel.TabIndex = 9;
            anamnesLabel.Text = "Анамнес :";
            anamnesLabel.Click += new System.EventHandler(this.anamnesLabel_Click);
            // 
            // diagnozLabel
            // 
            diagnozLabel.AutoSize = true;
            diagnozLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnozLabel.Location = new System.Drawing.Point(415, 591);
            diagnozLabel.Name = "diagnozLabel";
            diagnozLabel.Size = new System.Drawing.Size(184, 47);
            diagnozLabel.TabIndex = 11;
            diagnozLabel.Text = "Диагноз :";
            // 
            // plan_leheniaLabel
            // 
            plan_leheniaLabel.AutoSize = true;
            plan_leheniaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            plan_leheniaLabel.Location = new System.Drawing.Point(316, 661);
            plan_leheniaLabel.Name = "plan_leheniaLabel";
            plan_leheniaLabel.Size = new System.Drawing.Size(283, 47);
            plan_leheniaLabel.TabIndex = 13;
            plan_leheniaLabel.Text = "План лечения :";
            // 
            // iD_lekarctvaLabel
            // 
            iD_lekarctvaLabel.AutoSize = true;
            iD_lekarctvaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_lekarctvaLabel.Location = new System.Drawing.Point(200, 729);
            iD_lekarctvaLabel.Name = "iD_lekarctvaLabel";
            iD_lekarctvaLabel.Size = new System.Drawing.Size(399, 47);
            iD_lekarctvaLabel.TabIndex = 15;
            iD_lekarctvaLabel.Text = "Название лекартсва :";
            // 
            // zametkiLabel
            // 
            zametkiLabel.AutoSize = true;
            zametkiLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zametkiLabel.Location = new System.Drawing.Point(413, 798);
            zametkiLabel.Name = "zametkiLabel";
            zametkiLabel.Size = new System.Drawing.Size(186, 47);
            zametkiLabel.TabIndex = 17;
            zametkiLabel.Text = "Заметки :";
            // 
            // iD_zapicLabel
            // 
            iD_zapicLabel.AutoSize = true;
            iD_zapicLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_zapicLabel.Location = new System.Drawing.Point(399, 866);
            iD_zapicLabel.Name = "iD_zapicLabel";
            iD_zapicLabel.Size = new System.Drawing.Size(210, 47);
            iD_zapicLabel.TabIndex = 19;
            iD_zapicLabel.Text = "№ Записи :";
            // 
            // уП_ИСП21DataSet
            // 
            this.уП_ИСП21DataSet.DataSetName = "УП_ИСП21DataSet";
            this.уП_ИСП21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // med_kartaBindingSource
            // 
            this.med_kartaBindingSource.DataMember = "med_karta";
            this.med_kartaBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // med_kartaTableAdapter
            // 
            this.med_kartaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lekarctvaTableAdapter = this.lekarctvaTableAdapter;
            this.tableAdapterManager.med_kartaTableAdapter = this.med_kartaTableAdapter;
            this.tableAdapterManager.PacientTableAdapter = this.pacientTableAdapter;
            this.tableAdapterManager.UpdateOrder = уписп21.УП_ИСП21DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VrachTableAdapter = null;
            this.tableAdapterManager.zapicTableAdapter = null;
            // 
            // lekarctvaTableAdapter
            // 
            this.lekarctvaTableAdapter.ClearBeforeFill = true;
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // iD_med_kartaTextBox
            // 
            this.iD_med_kartaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iD_med_kartaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.med_kartaBindingSource, "ID_med_karta", true));
            this.iD_med_kartaTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_med_kartaTextBox.Location = new System.Drawing.Point(643, 231);
            this.iD_med_kartaTextBox.Name = "iD_med_kartaTextBox";
            this.iD_med_kartaTextBox.Size = new System.Drawing.Size(123, 55);
            this.iD_med_kartaTextBox.TabIndex = 2;
            // 
            // iD_pacientListBox
            // 
            this.iD_pacientListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iD_pacientListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.med_kartaBindingSource, "ID_pacient", true));
            this.iD_pacientListBox.DataSource = this.pacientBindingSource;
            this.iD_pacientListBox.DisplayMember = "fam_pacient";
            this.iD_pacientListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_pacientListBox.FormattingEnabled = true;
            this.iD_pacientListBox.ItemHeight = 47;
            this.iD_pacientListBox.Location = new System.Drawing.Point(643, 307);
            this.iD_pacientListBox.Name = "iD_pacientListBox";
            this.iD_pacientListBox.Size = new System.Drawing.Size(288, 51);
            this.iD_pacientListBox.TabIndex = 4;
            this.iD_pacientListBox.ValueMember = "ID_pacient";
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // iD_vrahListBox
            // 
            this.iD_vrahListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iD_vrahListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.med_kartaBindingSource, "ID_vrah", true));
            this.iD_vrahListBox.DataSource = this.vrachBindingSource;
            this.iD_vrahListBox.DisplayMember = "fam_vrach";
            this.iD_vrahListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_vrahListBox.FormattingEnabled = true;
            this.iD_vrahListBox.ItemHeight = 47;
            this.iD_vrahListBox.Location = new System.Drawing.Point(643, 374);
            this.iD_vrahListBox.Name = "iD_vrahListBox";
            this.iD_vrahListBox.Size = new System.Drawing.Size(288, 51);
            this.iD_vrahListBox.TabIndex = 6;
            this.iD_vrahListBox.ValueMember = "ID_vrach";
            // 
            // vrachBindingSource
            // 
            this.vrachBindingSource.DataMember = "Vrach";
            this.vrachBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // date_cozdaniaDateTimePicker
            // 
            this.date_cozdaniaDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date_cozdaniaDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date_cozdaniaDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date_cozdaniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.med_kartaBindingSource, "date_cozdania", true));
            this.date_cozdaniaDateTimePicker.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cozdaniaDateTimePicker.Location = new System.Drawing.Point(643, 441);
            this.date_cozdaniaDateTimePicker.Name = "date_cozdaniaDateTimePicker";
            this.date_cozdaniaDateTimePicker.Size = new System.Drawing.Size(323, 55);
            this.date_cozdaniaDateTimePicker.TabIndex = 8;
            // 
            // anamnesTextBox
            // 
            this.anamnesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anamnesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.med_kartaBindingSource, "anamnes", true));
            this.anamnesTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anamnesTextBox.Location = new System.Drawing.Point(643, 513);
            this.anamnesTextBox.Name = "anamnesTextBox";
            this.anamnesTextBox.Size = new System.Drawing.Size(1053, 55);
            this.anamnesTextBox.TabIndex = 10;
            // 
            // diagnozTextBox
            // 
            this.diagnozTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diagnozTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.med_kartaBindingSource, "diagnoz", true));
            this.diagnozTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnozTextBox.Location = new System.Drawing.Point(643, 583);
            this.diagnozTextBox.Name = "diagnozTextBox";
            this.diagnozTextBox.Size = new System.Drawing.Size(537, 55);
            this.diagnozTextBox.TabIndex = 12;
            // 
            // plan_leheniaTextBox
            // 
            this.plan_leheniaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plan_leheniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.med_kartaBindingSource, "plan_lehenia", true));
            this.plan_leheniaTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plan_leheniaTextBox.Location = new System.Drawing.Point(643, 653);
            this.plan_leheniaTextBox.Name = "plan_leheniaTextBox";
            this.plan_leheniaTextBox.Size = new System.Drawing.Size(1053, 55);
            this.plan_leheniaTextBox.TabIndex = 14;
            this.plan_leheniaTextBox.TextChanged += new System.EventHandler(this.plan_leheniaTextBox_TextChanged);
            // 
            // iD_lekarctvaListBox
            // 
            this.iD_lekarctvaListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iD_lekarctvaListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.med_kartaBindingSource, "ID_lekarctva", true));
            this.iD_lekarctvaListBox.DataSource = this.lekarctvaBindingSource;
            this.iD_lekarctvaListBox.DisplayMember = "name_lekarctva";
            this.iD_lekarctvaListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_lekarctvaListBox.FormattingEnabled = true;
            this.iD_lekarctvaListBox.ItemHeight = 47;
            this.iD_lekarctvaListBox.Location = new System.Drawing.Point(643, 725);
            this.iD_lekarctvaListBox.Name = "iD_lekarctvaListBox";
            this.iD_lekarctvaListBox.Size = new System.Drawing.Size(288, 51);
            this.iD_lekarctvaListBox.TabIndex = 16;
            this.iD_lekarctvaListBox.ValueMember = "ID_lekarctva";
            // 
            // lekarctvaBindingSource
            // 
            this.lekarctvaBindingSource.DataMember = "lekarctva";
            this.lekarctvaBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // zametkiTextBox
            // 
            this.zametkiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zametkiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.med_kartaBindingSource, "zametki", true));
            this.zametkiTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zametkiTextBox.Location = new System.Drawing.Point(643, 790);
            this.zametkiTextBox.Name = "zametkiTextBox";
            this.zametkiTextBox.Size = new System.Drawing.Size(1053, 55);
            this.zametkiTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1459, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 64);
            this.button1.TabIndex = 21;
            this.button1.Text = "Сохранить";
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
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1124, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 64);
            this.button2.TabIndex = 22;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vrachTableAdapter
            // 
            this.vrachTableAdapter.ClearBeforeFill = true;
            // 
            // iD_zapicListBox
            // 
            this.iD_zapicListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iD_zapicListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.med_kartaBindingSource, "ID_zapic", true));
            this.iD_zapicListBox.DataSource = this.zapicBindingSource;
            this.iD_zapicListBox.DisplayMember = "ID_zapic";
            this.iD_zapicListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_zapicListBox.FormattingEnabled = true;
            this.iD_zapicListBox.ItemHeight = 47;
            this.iD_zapicListBox.Location = new System.Drawing.Point(643, 862);
            this.iD_zapicListBox.Name = "iD_zapicListBox";
            this.iD_zapicListBox.Size = new System.Drawing.Size(123, 51);
            this.iD_zapicListBox.TabIndex = 20;
            this.iD_zapicListBox.ValueMember = "ID_zapic";
            // 
            // zapicBindingSource
            // 
            this.zapicBindingSource.DataMember = "zapic";
            this.zapicBindingSource.DataSource = this.уП_ИСП21DataSet;
            // 
            // zapicTableAdapter
            // 
            this.zapicTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 47);
            this.label1.TabIndex = 23;
            this.label1.Text = "Добавление записи в медицинскую карту";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1293, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 64);
            this.button3.TabIndex = 24;
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
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1293, 886);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(403, 64);
            this.button4.TabIndex = 25;
            this.button4.Text = "Вернутся назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DobavZap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_zapicLabel);
            this.Controls.Add(this.iD_zapicListBox);
            this.Controls.Add(zametkiLabel);
            this.Controls.Add(this.zametkiTextBox);
            this.Controls.Add(iD_lekarctvaLabel);
            this.Controls.Add(this.iD_lekarctvaListBox);
            this.Controls.Add(plan_leheniaLabel);
            this.Controls.Add(this.plan_leheniaTextBox);
            this.Controls.Add(diagnozLabel);
            this.Controls.Add(this.diagnozTextBox);
            this.Controls.Add(anamnesLabel);
            this.Controls.Add(this.anamnesTextBox);
            this.Controls.Add(date_cozdaniaLabel);
            this.Controls.Add(this.date_cozdaniaDateTimePicker);
            this.Controls.Add(iD_vrahLabel);
            this.Controls.Add(this.iD_vrahListBox);
            this.Controls.Add(iD_pacientLabel);
            this.Controls.Add(this.iD_pacientListBox);
            this.Controls.Add(iD_med_kartaLabel);
            this.Controls.Add(this.iD_med_kartaTextBox);
            this.Name = "DobavZap";
            this.Text = "Добавиление записи в медицинскую карту";
            this.Load += new System.EventHandler(this.DobavZap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.уП_ИСП21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarctvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private УП_ИСП21DataSet уП_ИСП21DataSet;
        private System.Windows.Forms.BindingSource med_kartaBindingSource;
        private УП_ИСП21DataSetTableAdapters.med_kartaTableAdapter med_kartaTableAdapter;
        private УП_ИСП21DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_med_kartaTextBox;
        private System.Windows.Forms.ListBox iD_pacientListBox;
        private System.Windows.Forms.ListBox iD_vrahListBox;
        private System.Windows.Forms.DateTimePicker date_cozdaniaDateTimePicker;
        private System.Windows.Forms.TextBox anamnesTextBox;
        private System.Windows.Forms.TextBox diagnozTextBox;
        private System.Windows.Forms.TextBox plan_leheniaTextBox;
        private System.Windows.Forms.ListBox iD_lekarctvaListBox;
        private System.Windows.Forms.TextBox zametkiTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private УП_ИСП21DataSetTableAdapters.PacientTableAdapter pacientTableAdapter;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private УП_ИСП21DataSetTableAdapters.lekarctvaTableAdapter lekarctvaTableAdapter;
        private System.Windows.Forms.BindingSource lekarctvaBindingSource;
        private System.Windows.Forms.BindingSource vrachBindingSource;
        private УП_ИСП21DataSetTableAdapters.VrachTableAdapter vrachTableAdapter;
        private System.Windows.Forms.ListBox iD_zapicListBox;
        private System.Windows.Forms.BindingSource zapicBindingSource;
        private УП_ИСП21DataSetTableAdapters.zapicTableAdapter zapicTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}