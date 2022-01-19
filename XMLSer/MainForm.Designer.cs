namespace XMLSer
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
            this.ADsList = new System.Windows.Forms.ListView();
            this.tbAdress = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbVideoURL = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.panelDnD = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbManager = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btSerialize = new System.Windows.Forms.Button();
            this.btDeserialize = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbTemplateFrom = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.dtpBeg = new System.Windows.Forms.DateTimePicker();
            this.btAddTemplate = new System.Windows.Forms.Button();
            this.cmbAdType = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbROM = new System.Windows.Forms.ComboBox();
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbGoodsType = new System.Windows.Forms.ComboBox();
            this.cmbADStatus = new System.Windows.Forms.ComboBox();
            this.cmbContactMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdImages = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbIImgURL = new System.Windows.Forms.TextBox();
            this.youlaList = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelDnD.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADsList
            // 
            this.ADsList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ADsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ADsList.HideSelection = false;
            this.ADsList.LabelWrap = false;
            this.ADsList.Location = new System.Drawing.Point(12, 21);
            this.ADsList.MultiSelect = false;
            this.ADsList.Name = "ADsList";
            this.ADsList.ShowGroups = false;
            this.ADsList.Size = new System.Drawing.Size(165, 556);
            this.ADsList.TabIndex = 0;
            this.ADsList.UseCompatibleStateImageBehavior = false;
            this.ADsList.SelectedIndexChanged += new System.EventHandler(this.ADsList_SelectedIndexChanged);
            // 
            // tbAdress
            // 
            this.tbAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAdress.AutoCompleteCustomSource.AddRange(new string[] {
            "PC"});
            this.tbAdress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbAdress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbAdress.FormattingEnabled = true;
            this.tbAdress.Items.AddRange(new object[] {
            "г. Абакан",
            "г. Красноярск"});
            this.tbAdress.Location = new System.Drawing.Point(449, 282);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(462, 21);
            this.tbAdress.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заголовок";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTitle.Location = new System.Drawing.Point(449, 309);
            this.tbTitle.MaxLength = 54;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(464, 20);
            this.tbTitle.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(449, 335);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(710, 213);
            this.tbDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Картинки";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 682);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Видео";
            // 
            // tbVideoURL
            // 
            this.tbVideoURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbVideoURL.Location = new System.Drawing.Point(452, 679);
            this.tbVideoURL.Name = "tbVideoURL";
            this.tbVideoURL.Size = new System.Drawing.Size(470, 20);
            this.tbVideoURL.TabIndex = 14;
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrice.Location = new System.Drawing.Point(449, 553);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // btCreate
            // 
            this.btCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCreate.Location = new System.Drawing.Point(928, 626);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(294, 73);
            this.btCreate.TabIndex = 15;
            this.btCreate.Text = "Сохранить";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // panelDnD
            // 
            this.panelDnD.AllowDrop = true;
            this.panelDnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDnD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDnD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDnD.Controls.Add(this.label26);
            this.panelDnD.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDnD.Location = new System.Drawing.Point(449, 580);
            this.panelDnD.Name = "panelDnD";
            this.panelDnD.Size = new System.Drawing.Size(215, 93);
            this.panelDnD.TabIndex = 54;
            this.panelDnD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDnD_MouseClick);
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Enabled = false;
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(211, 89);
            this.label26.TabIndex = 11;
            this.label26.Text = "Нажми";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPhone.Location = new System.Drawing.Point(801, 554);
            this.tbPhone.Mask = "+7(999) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(117, 20);
            this.tbPhone.TabIndex = 59;
            // 
            // tbManager
            // 
            this.tbManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbManager.Location = new System.Drawing.Point(647, 554);
            this.tbManager.Name = "tbManager";
            this.tbManager.Size = new System.Drawing.Size(90, 20);
            this.tbManager.TabIndex = 55;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(743, 557);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "Телефон";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(581, 557);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "Менеджер";
            // 
            // btSerialize
            // 
            this.btSerialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSerialize.Location = new System.Drawing.Point(12, 626);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(336, 36);
            this.btSerialize.TabIndex = 16;
            this.btSerialize.Text = "Загрузить файл";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // btDeserialize
            // 
            this.btDeserialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDeserialize.Location = new System.Drawing.Point(12, 593);
            this.btDeserialize.Name = "btDeserialize";
            this.btDeserialize.Size = new System.Drawing.Size(336, 27);
            this.btDeserialize.TabIndex = 17;
            this.btDeserialize.Text = "Загрузить список";
            this.btDeserialize.UseVisualStyleBackColor = true;
            this.btDeserialize.Click += new System.EventHandler(this.btDeserialize_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(449, 2);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 62;
            this.label28.Text = "Шаблон для";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(576, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 13);
            this.label27.TabIndex = 61;
            this.label27.Text = "нет";
            // 
            // cmbTemplateFrom
            // 
            this.cmbTemplateFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplateFrom.FormattingEnabled = true;
            this.cmbTemplateFrom.Items.AddRange(new object[] {
            "jewelry",
            "pc",
            "phone",
            "lap",
            "tool"});
            this.cmbTemplateFrom.Location = new System.Drawing.Point(449, 16);
            this.cmbTemplateFrom.Name = "cmbTemplateFrom";
            this.cmbTemplateFrom.Size = new System.Drawing.Size(121, 21);
            this.cmbTemplateFrom.TabIndex = 60;
            this.cmbTemplateFrom.SelectedIndexChanged += new System.EventHandler(this.cmbTemplateFrom_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(755, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Выберите шаблон";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(449, 205);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 53;
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(758, 18);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(121, 21);
            this.cmbTemplates.TabIndex = 19;
            this.cmbTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbTemplates_SelectedIndexChanged);
            // 
            // dtpBeg
            // 
            this.dtpBeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeg.Location = new System.Drawing.Point(449, 178);
            this.dtpBeg.Name = "dtpBeg";
            this.dtpBeg.Size = new System.Drawing.Size(200, 20);
            this.dtpBeg.TabIndex = 52;
            // 
            // btAddTemplate
            // 
            this.btAddTemplate.Location = new System.Drawing.Point(882, 16);
            this.btAddTemplate.Name = "btAddTemplate";
            this.btAddTemplate.Size = new System.Drawing.Size(110, 23);
            this.btAddTemplate.TabIndex = 18;
            this.btAddTemplate.Text = "Добавить шаблон";
            this.btAddTemplate.UseVisualStyleBackColor = true;
            this.btAddTemplate.Click += new System.EventHandler(this.btAddTemplate_Click);
            // 
            // cmbAdType
            // 
            this.cmbAdType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbAdType.AutoCompleteCustomSource.AddRange(new string[] {
            "12мб"});
            this.cmbAdType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAdType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAdType.FormattingEnabled = true;
            this.cmbAdType.Items.AddRange(new object[] {
            "Товар приобретен на продажу",
            "Товар от производителя"});
            this.cmbAdType.Location = new System.Drawing.Point(576, 92);
            this.cmbAdType.Name = "cmbAdType";
            this.cmbAdType.Size = new System.Drawing.Size(121, 21);
            this.cmbAdType.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(576, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Вид объявления";
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(449, 69);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(121, 20);
            this.tbID.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(348, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "ID";
            // 
            // cmbROM
            // 
            this.cmbROM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbROM.AutoCompleteCustomSource.AddRange(new string[] {
            "12мб"});
            this.cmbROM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbROM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbROM.FormattingEnabled = true;
            this.cmbROM.Location = new System.Drawing.Point(842, 168);
            this.cmbROM.Name = "cmbROM";
            this.cmbROM.Size = new System.Drawing.Size(121, 21);
            this.cmbROM.TabIndex = 39;
            // 
            // cmbRAM
            // 
            this.cmbRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbRAM.AutoCompleteCustomSource.AddRange(new string[] {
            "256мб"});
            this.cmbRAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(842, 142);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(121, 21);
            this.cmbRAM.TabIndex = 38;
            // 
            // cmbColor
            // 
            this.cmbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbColor.AutoCompleteCustomSource.AddRange(new string[] {
            "Коричневый"});
            this.cmbColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(842, 115);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 37;
            // 
            // cmbModel
            // 
            this.cmbModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbModel.AutoCompleteCustomSource.AddRange(new string[] {
            "Кал"});
            this.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(842, 88);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 36;
            // 
            // cmbVendor
            // 
            this.cmbVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbVendor.AutoCompleteCustomSource.AddRange(new string[] {
            "Аппле"});
            this.cmbVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(842, 61);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendor.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(755, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Встроенная";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(755, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Оперативная";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(755, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Цвет";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(755, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Модель";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(755, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Бренд";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(347, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Подкатегория";
            // 
            // cmbGoodsType
            // 
            this.cmbGoodsType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbGoodsType.AutoCompleteCustomSource.AddRange(new string[] {
            "Мощный"});
            this.cmbGoodsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGoodsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGoodsType.FormattingEnabled = true;
            this.cmbGoodsType.Items.AddRange(new object[] {
            "--Подкатегории--"});
            this.cmbGoodsType.Location = new System.Drawing.Point(449, 122);
            this.cmbGoodsType.Name = "cmbGoodsType";
            this.cmbGoodsType.Size = new System.Drawing.Size(121, 21);
            this.cmbGoodsType.TabIndex = 3;
            // 
            // cmbADStatus
            // 
            this.cmbADStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbADStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Реклама"});
            this.cmbADStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbADStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbADStatus.FormattingEnabled = true;
            this.cmbADStatus.Items.AddRange(new object[] {
            "--Реклама--",
            "Free",
            "PushUp",
            "VIP",
            "QuickSale",
            "Premium",
            "TurboSale"});
            this.cmbADStatus.Location = new System.Drawing.Point(449, 228);
            this.cmbADStatus.Name = "cmbADStatus";
            this.cmbADStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbADStatus.TabIndex = 7;
            // 
            // cmbContactMethod
            // 
            this.cmbContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbContactMethod.AutoCompleteCustomSource.AddRange(new string[] {
            "Везде"});
            this.cmbContactMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbContactMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbContactMethod.FormattingEnabled = true;
            this.cmbContactMethod.Items.AddRange(new object[] {
            "--Метод связи--",
            "По телефону и в сообщениях",
            "По телефону",
            "В сообщениях"});
            this.cmbContactMethod.Location = new System.Drawing.Point(449, 255);
            this.cmbContactMethod.Name = "cmbContactMethod";
            this.cmbContactMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbContactMethod.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Метод связи";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Статус рекламы";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата конца";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата начала";
            // 
            // cmbCondition
            // 
            this.cmbCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCondition.AutoCompleteCustomSource.AddRange(new string[] {
            "Новый",
            "Старый"});
            this.cmbCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCondition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "--Состояния--",
            "Новое",
            "Б/у"});
            this.cmbCondition.Location = new System.Drawing.Point(449, 149);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(121, 21);
            this.cmbCondition.TabIndex = 4;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "PC"});
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "--Категории--",
            "Телефоны",
            "Аудио и видео",
            "Товары для компьютера",
            "Фототехника",
            "Игры, приставки и программы",
            "Оргтехника и расходники",
            "Планшеты и электронные книги",
            "Ноутбуки",
            "Настольные компьютеры",
            "Одежда, обувь, аксессуары",
            "Часы и украшения",
            "Ремонт и строительство"});
            this.cmbCategory.Location = new System.Drawing.Point(449, 95);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Состояние";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория";
            // 
            // ofdImages
            // 
            this.ofdImages.FileName = "openFileDialog1";
            this.ofdImages.Multiselect = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 711);
            this.panel2.TabIndex = 21;
            // 
            // tbIImgURL
            // 
            this.tbIImgURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbIImgURL.Location = new System.Drawing.Point(670, 580);
            this.tbIImgURL.Multiline = true;
            this.tbIImgURL.Name = "tbIImgURL";
            this.tbIImgURL.Size = new System.Drawing.Size(252, 75);
            this.tbIImgURL.TabIndex = 71;
            // 
            // youlaList
            // 
            this.youlaList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.youlaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.youlaList.AutoArrange = false;
            this.youlaList.HideSelection = false;
            this.youlaList.LabelWrap = false;
            this.youlaList.Location = new System.Drawing.Point(179, 21);
            this.youlaList.MultiSelect = false;
            this.youlaList.Name = "youlaList";
            this.youlaList.ShowGroups = false;
            this.youlaList.Size = new System.Drawing.Size(165, 556);
            this.youlaList.TabIndex = 72;
            this.youlaList.UseCompatibleStateImageBehavior = false;
            this.youlaList.SelectedIndexChanged += new System.EventHandler(this.youlaList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Авито";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(241, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Юла";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.youlaList);
            this.Controls.Add(this.tbIImgURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVideoURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.ADsList);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.panelDnD);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tbManager);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmbTemplateFrom);
            this.Controls.Add(this.btSerialize);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btDeserialize);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.dtpBeg);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.btAddTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAdType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbROM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRAM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbContactMethod);
            this.Controls.Add(this.cmbADStatus);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbGoodsType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "MainForm";
            this.Text = "Заполнение объявлений";
            this.panelDnD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ADsList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbGoodsType;
        private System.Windows.Forms.ComboBox cmbADStatus;
        private System.Windows.Forms.TextBox tbVideoURL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbContactMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.ComboBox cmbROM;
        private System.Windows.Forms.ComboBox cmbRAM;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btDeserialize;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btSerialize;
        private System.Windows.Forms.OpenFileDialog ofdImages;
        private System.Windows.Forms.ComboBox cmbAdType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBeg;
        private System.Windows.Forms.Panel panelDnD;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btAddTemplate;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbManager;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbTemplateFrom;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox tbAdress;
        private System.Windows.Forms.TextBox tbIImgURL;
        private System.Windows.Forms.ListView youlaList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
    }
}

