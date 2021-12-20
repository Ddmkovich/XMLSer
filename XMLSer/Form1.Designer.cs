namespace XMLSer
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
            this.ADsList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDnD = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBeg = new System.Windows.Forms.DateTimePicker();
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
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbGoodsType = new System.Windows.Forms.ComboBox();
            this.cmbADStatus = new System.Windows.Forms.ComboBox();
            this.tbVideoURL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbContactMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.btDeserialize = new System.Windows.Forms.Button();
            this.btSerialize = new System.Windows.Forms.Button();
            this.ofdImages = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panelDnD.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADsList
            // 
            this.ADsList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ADsList.AutoArrange = false;
            this.ADsList.HideSelection = false;
            this.ADsList.LabelWrap = false;
            this.ADsList.Location = new System.Drawing.Point(13, 12);
            this.ADsList.MultiSelect = false;
            this.ADsList.Name = "ADsList";
            this.ADsList.ShowGroups = false;
            this.ADsList.Size = new System.Drawing.Size(209, 565);
            this.ADsList.TabIndex = 0;
            this.ADsList.UseCompatibleStateImageBehavior = false;
            this.ADsList.SelectedIndexChanged += new System.EventHandler(this.ADsList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDnD);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpBeg);
            this.panel1.Controls.Add(this.cmbAdType);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cmbROM);
            this.panel1.Controls.Add(this.cmbRAM);
            this.panel1.Controls.Add(this.cmbColor);
            this.panel1.Controls.Add(this.cmbModel);
            this.panel1.Controls.Add(this.cmbVendor);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cmbGoodsType);
            this.panel1.Controls.Add(this.cmbADStatus);
            this.panel1.Controls.Add(this.tbVideoURL);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbAdress);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbContactMethod);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCondition);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(228, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 565);
            this.panel1.TabIndex = 1;
            // 
            // panelDnD
            // 
            this.panelDnD.AllowDrop = true;
            this.panelDnD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDnD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDnD.Controls.Add(this.label26);
            this.panelDnD.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDnD.Location = new System.Drawing.Point(106, 371);
            this.panelDnD.Name = "panelDnD";
            this.panelDnD.Size = new System.Drawing.Size(584, 113);
            this.panelDnD.TabIndex = 54;
            this.panelDnD.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDnD_DragDrop);
            this.panelDnD.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDnD_DragEnter);
            this.panelDnD.DragLeave += new System.EventHandler(this.panelDnD_DragLeave);
            this.panelDnD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDnD_MouseClick);
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(209, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(151, 24);
            this.label26.TabIndex = 11;
            this.label26.Text = "Перетащи сюда файлы\r\n";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(106, 153);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 53;
            // 
            // dtpBeg
            // 
            this.dtpBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeg.Location = new System.Drawing.Point(106, 126);
            this.dtpBeg.Name = "dtpBeg";
            this.dtpBeg.Size = new System.Drawing.Size(200, 20);
            this.dtpBeg.TabIndex = 52;
            // 
            // cmbAdType
            // 
            this.cmbAdType.AutoCompleteCustomSource.AddRange(new string[] {
            "12мб"});
            this.cmbAdType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAdType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAdType.FormattingEnabled = true;
            this.cmbAdType.Items.AddRange(new object[] {
            "Товар приобретен на продажу",
            "Товар от производителя"});
            this.cmbAdType.Location = new System.Drawing.Point(233, 43);
            this.cmbAdType.Name = "cmbAdType";
            this.cmbAdType.Size = new System.Drawing.Size(121, 21);
            this.cmbAdType.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(233, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Вид объявления";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(106, 17);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(121, 20);
            this.tbID.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "ID";
            // 
            // cmbROM
            // 
            this.cmbROM.AutoCompleteCustomSource.AddRange(new string[] {
            "12мб"});
            this.cmbROM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbROM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbROM.FormattingEnabled = true;
            this.cmbROM.Location = new System.Drawing.Point(456, 124);
            this.cmbROM.Name = "cmbROM";
            this.cmbROM.Size = new System.Drawing.Size(121, 21);
            this.cmbROM.TabIndex = 39;
            // 
            // cmbRAM
            // 
            this.cmbRAM.AutoCompleteCustomSource.AddRange(new string[] {
            "256мб"});
            this.cmbRAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(456, 98);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(121, 21);
            this.cmbRAM.TabIndex = 38;
            // 
            // cmbColor
            // 
            this.cmbColor.AutoCompleteCustomSource.AddRange(new string[] {
            "Коричневый"});
            this.cmbColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(456, 71);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 37;
            // 
            // cmbModel
            // 
            this.cmbModel.AutoCompleteCustomSource.AddRange(new string[] {
            "Кал"});
            this.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(456, 44);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 36;
            // 
            // cmbVendor
            // 
            this.cmbVendor.AutoCompleteCustomSource.AddRange(new string[] {
            "Аппле"});
            this.cmbVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(456, 17);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendor.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(369, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Встроенная";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(369, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(369, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Оперативная";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(369, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Цвет";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(369, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Модель";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Бренд";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Подкатегория";
            // 
            // cmbGoodsType
            // 
            this.cmbGoodsType.AutoCompleteCustomSource.AddRange(new string[] {
            "Мощный"});
            this.cmbGoodsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGoodsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGoodsType.FormattingEnabled = true;
            this.cmbGoodsType.Items.AddRange(new object[] {
            "--Подкатегории--"});
            this.cmbGoodsType.Location = new System.Drawing.Point(106, 70);
            this.cmbGoodsType.Name = "cmbGoodsType";
            this.cmbGoodsType.Size = new System.Drawing.Size(121, 21);
            this.cmbGoodsType.TabIndex = 3;
            this.cmbGoodsType.SelectedIndexChanged += new System.EventHandler(this.cmbGoodsType_SelectedIndexChanged);
            // 
            // cmbADStatus
            // 
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
            this.cmbADStatus.Location = new System.Drawing.Point(106, 176);
            this.cmbADStatus.Name = "cmbADStatus";
            this.cmbADStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbADStatus.TabIndex = 7;
            // 
            // tbVideoURL
            // 
            this.tbVideoURL.Location = new System.Drawing.Point(90, 512);
            this.tbVideoURL.Name = "tbVideoURL";
            this.tbVideoURL.Size = new System.Drawing.Size(470, 20);
            this.tbVideoURL.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Видео";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Картинки";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(106, 230);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(464, 20);
            this.tbAdress.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Адрес";
            // 
            // cmbContactMethod
            // 
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
            this.cmbContactMethod.Location = new System.Drawing.Point(106, 203);
            this.cmbContactMethod.Name = "cmbContactMethod";
            this.cmbContactMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbContactMethod.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Метод связи";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Статус рекламы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата конца";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата начала";
            // 
            // cmbCondition
            // 
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
            this.cmbCondition.Location = new System.Drawing.Point(106, 97);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(121, 21);
            this.cmbCondition.TabIndex = 4;
            // 
            // cmbCategory
            // 
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
            "Часы и украшения"});
            this.cmbCategory.Location = new System.Drawing.Point(106, 43);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(106, 345);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(106, 282);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(464, 57);
            this.tbDescription.TabIndex = 11;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(106, 256);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(464, 20);
            this.tbTitle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Состояние";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория";
            // 
            // btCreate
            // 
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCreate.Location = new System.Drawing.Point(634, 597);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(154, 55);
            this.btCreate.TabIndex = 15;
            this.btCreate.Text = "Сохранить";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btDeserialize
            // 
            this.btDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDeserialize.Location = new System.Drawing.Point(13, 583);
            this.btDeserialize.Name = "btDeserialize";
            this.btDeserialize.Size = new System.Drawing.Size(209, 27);
            this.btDeserialize.TabIndex = 17;
            this.btDeserialize.Text = "Загрузить список";
            this.btDeserialize.UseVisualStyleBackColor = true;
            this.btDeserialize.Click += new System.EventHandler(this.btDeserialize_Click);
            // 
            // btSerialize
            // 
            this.btSerialize.Location = new System.Drawing.Point(13, 616);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(209, 36);
            this.btSerialize.TabIndex = 16;
            this.btSerialize.Text = "Загрузить файл";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // ofdImages
            // 
            this.ofdImages.FileName = "openFileDialog1";
            this.ofdImages.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 664);
            this.Controls.Add(this.btSerialize);
            this.Controls.Add(this.btDeserialize);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ADsList);
            this.Name = "Form1";
            this.Text = "Категория";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDnD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ADsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbGoodsType;
        private System.Windows.Forms.ComboBox cmbADStatus;
        private System.Windows.Forms.TextBox tbVideoURL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbContactMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label label19;
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
    }
}

