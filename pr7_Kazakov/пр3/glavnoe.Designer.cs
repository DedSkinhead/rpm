using System;

namespace пр3
{
    partial class glavnoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glavnoe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visil = new System.Windows.Forms.Button();
            this.nasvanie = new System.Windows.Forms.TextBox();
            this.kateg = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kolvo = new System.Windows.Forms.TextBox();
            this.ckidka = new System.Windows.Forms.CheckBox();
            this.ckidkaa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.osistka = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.vixod = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.TextBox();
            this.xovo = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.polz = new System.Windows.Forms.Label();
            this.imae = new System.Windows.Forms.Label();
            this.dowload = new System.Windows.Forms.Button();
            this.dowloadpuchere = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dowl = new System.Windows.Forms.Button();
            this.saved = new System.Windows.Forms.Button();
            this.wottb = new System.Windows.Forms.Button();
            this.delettb = new System.Windows.Forms.Button();
            this.cleartb = new System.Windows.Forms.Button();
            this.obnovtb = new System.Windows.Forms.Button();
            this.izmentb = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labscid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labinfo = new System.Windows.Forms.Label();
            this.labnaz = new System.Windows.Forms.Label();
            this.poisknaz = new System.Windows.Forms.ComboBox();
            this.textpoisk = new System.Windows.Forms.TextBox();
            this.labelpo = new System.Windows.Forms.Label();
            this.buttonpoisk = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.diagram = new System.Windows.Forms.Button();
            this.zagtab = new System.Windows.Forms.Button();
            this.savetab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ckidkaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1128, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1128, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата выпуска товара: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1128, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество товара: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // visil
            // 
            this.visil.Location = new System.Drawing.Point(1131, 238);
            this.visil.Name = "visil";
            this.visil.Size = new System.Drawing.Size(292, 23);
            this.visil.TabIndex = 4;
            this.visil.Text = "Вычислить предворительную стоимость";
            this.visil.UseVisualStyleBackColor = true;
            this.visil.Click += new System.EventHandler(this.visil_Click);
            // 
            // nasvanie
            // 
            this.nasvanie.Location = new System.Drawing.Point(1265, 8);
            this.nasvanie.Name = "nasvanie";
            this.nasvanie.Size = new System.Drawing.Size(158, 20);
            this.nasvanie.TabIndex = 5;
            // 
            // kateg
            // 
            this.kateg.FormattingEnabled = true;
            this.kateg.Items.AddRange(new object[] {
            "Продукты",
            "Промтовары"});
            this.kateg.Location = new System.Drawing.Point(1265, 34);
            this.kateg.Name = "kateg";
            this.kateg.Size = new System.Drawing.Size(161, 21);
            this.kateg.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1265, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // kolvo
            // 
            this.kolvo.Location = new System.Drawing.Point(1265, 114);
            this.kolvo.MaxLength = 6;
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(163, 20);
            this.kolvo.TabIndex = 8;
            this.kolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolvo_KeyPress);
            // 
            // ckidka
            // 
            this.ckidka.AutoSize = true;
            this.ckidka.Cursor = System.Windows.Forms.Cursors.No;
            this.ckidka.Location = new System.Drawing.Point(1265, 146);
            this.ckidka.Name = "ckidka";
            this.ckidka.Size = new System.Drawing.Size(15, 14);
            this.ckidka.TabIndex = 5;
            this.ckidka.UseVisualStyleBackColor = true;
            this.ckidka.CheckedChanged += new System.EventHandler(this.ckidka_CheckedChanged);
            // 
            // ckidkaa
            // 
            this.ckidkaa.Enabled = false;
            this.ckidkaa.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ckidkaa.Location = new System.Drawing.Point(1329, 140);
            this.ckidkaa.Name = "ckidkaa";
            this.ckidkaa.ReadOnly = true;
            this.ckidkaa.Size = new System.Drawing.Size(99, 20);
            this.ckidkaa.TabIndex = 10;
            this.ckidkaa.ValueChanged += new System.EventHandler(this.ckidkaa_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1128, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Еденицы измерения: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Литры",
            "Штуки",
            "Килограммы"});
            this.comboBox2.Location = new System.Drawing.Point(1290, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1135, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Изображение";
            // 
            // osistka
            // 
            this.osistka.Location = new System.Drawing.Point(1311, 356);
            this.osistka.Name = "osistka";
            this.osistka.Size = new System.Drawing.Size(117, 22);
            this.osistka.TabIndex = 14;
            this.osistka.Text = "Очистка";
            this.osistka.UseVisualStyleBackColor = true;
            this.osistka.Click += new System.EventHandler(this.osistka_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(1311, 413);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(117, 27);
            this.info.TabIndex = 15;
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // vixod
            // 
            this.vixod.Location = new System.Drawing.Point(1046, 517);
            this.vixod.Name = "vixod";
            this.vixod.Size = new System.Drawing.Size(117, 27);
            this.vixod.TabIndex = 16;
            this.vixod.Text = "Выход";
            this.vixod.UseVisualStyleBackColor = true;
            this.vixod.Click += new System.EventHandler(this.vixod_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1128, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Цена товара: ";
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(1265, 88);
            this.cena.MaxLength = 6;
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(163, 20);
            this.cena.TabIndex = 18;
            this.cena.TextChanged += new System.EventHandler(this.cena_TextChanged);
            this.cena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cena_KeyPress);
            // 
            // xovo
            // 
            this.xovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xovo.Location = new System.Drawing.Point(1169, 494);
            this.xovo.Name = "xovo";
            this.xovo.ReadOnly = true;
            this.xovo.Size = new System.Drawing.Size(254, 121);
            this.xovo.TabIndex = 19;
            this.xovo.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1141, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "руб.";
            // 
            // polz
            // 
            this.polz.AutoSize = true;
            this.polz.Location = new System.Drawing.Point(945, 478);
            this.polz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polz.Name = "polz";
            this.polz.Size = new System.Drawing.Size(80, 13);
            this.polz.TabIndex = 21;
            this.polz.Text = "Пользователь";
            // 
            // imae
            // 
            this.imae.AutoSize = true;
            this.imae.Location = new System.Drawing.Point(1029, 478);
            this.imae.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imae.Name = "imae";
            this.imae.Size = new System.Drawing.Size(0, 13);
            this.imae.TabIndex = 22;
            // 
            // dowload
            // 
            this.dowload.Enabled = false;
            this.dowload.Location = new System.Drawing.Point(1311, 384);
            this.dowload.Name = "dowload";
            this.dowload.Size = new System.Drawing.Size(117, 23);
            this.dowload.TabIndex = 23;
            this.dowload.Text = "Отчет";
            this.dowload.UseVisualStyleBackColor = true;
            this.dowload.Click += new System.EventHandler(this.dowload_Click);
            // 
            // dowloadpuchere
            // 
            this.dowloadpuchere.Enabled = false;
            this.dowloadpuchere.Location = new System.Drawing.Point(1144, 452);
            this.dowloadpuchere.Name = "dowloadpuchere";
            this.dowloadpuchere.Size = new System.Drawing.Size(146, 23);
            this.dowloadpuchere.TabIndex = 24;
            this.dowloadpuchere.Text = "Загрузить Изображение";
            this.dowloadpuchere.UseVisualStyleBackColor = true;
            this.dowloadpuchere.Click += new System.EventHandler(this.dowloadpuchere_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Все рисунки(*.jpg; *.jpeg; *.bmp; *.ico; *.emf; *.wmf)|*.jpg; *.jpeg; *.bmp; *.ic" +
    "o; *.emf; *.wmf|Файлы JPG(*.jpg)|*.jpg|Файлы JPEG(*.jpeg)|*.jpeg|Bitmaps(*.bmp)|" +
    "*.bmp";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Все файлы(*.*)|*.*|Сведения о товаре(*.tov)|*.tov|Текстовые файлы(*.txt)|*.txt";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1131, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 148);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dowl
            // 
            this.dowl.Location = new System.Drawing.Point(1311, 298);
            this.dowl.Name = "dowl";
            this.dowl.Size = new System.Drawing.Size(117, 23);
            this.dowl.TabIndex = 26;
            this.dowl.Text = "Загрузить";
            this.dowl.UseVisualStyleBackColor = true;
            this.dowl.Click += new System.EventHandler(this.dowl_Click);
            // 
            // saved
            // 
            this.saved.Enabled = false;
            this.saved.Location = new System.Drawing.Point(1311, 327);
            this.saved.Name = "saved";
            this.saved.Size = new System.Drawing.Size(117, 23);
            this.saved.TabIndex = 27;
            this.saved.Text = "Сохранить";
            this.saved.UseVisualStyleBackColor = true;
            this.saved.Click += new System.EventHandler(this.saved_Click);
            // 
            // wottb
            // 
            this.wottb.Location = new System.Drawing.Point(945, 7);
            this.wottb.Name = "wottb";
            this.wottb.Size = new System.Drawing.Size(117, 43);
            this.wottb.TabIndex = 28;
            this.wottb.Text = "Внести данные в таблицу";
            this.wottb.UseVisualStyleBackColor = true;
            this.wottb.Click += new System.EventHandler(this.wottb_Click);
            // 
            // delettb
            // 
            this.delettb.Location = new System.Drawing.Point(945, 58);
            this.delettb.Name = "delettb";
            this.delettb.Size = new System.Drawing.Size(117, 23);
            this.delettb.TabIndex = 29;
            this.delettb.Text = "Удалить строку";
            this.delettb.UseVisualStyleBackColor = true;
            this.delettb.Click += new System.EventHandler(this.delettb_Click);
            // 
            // cleartb
            // 
            this.cleartb.Location = new System.Drawing.Point(945, 154);
            this.cleartb.Name = "cleartb";
            this.cleartb.Size = new System.Drawing.Size(117, 23);
            this.cleartb.TabIndex = 30;
            this.cleartb.Text = "Очистить таблицу";
            this.cleartb.UseVisualStyleBackColor = true;
            this.cleartb.Click += new System.EventHandler(this.cleartb_Click);
            // 
            // obnovtb
            // 
            this.obnovtb.Location = new System.Drawing.Point(945, 121);
            this.obnovtb.Name = "obnovtb";
            this.obnovtb.Size = new System.Drawing.Size(117, 27);
            this.obnovtb.TabIndex = 31;
            this.obnovtb.Text = "Обновить данные";
            this.obnovtb.UseVisualStyleBackColor = true;
            this.obnovtb.Click += new System.EventHandler(this.obnovtb_Click);
            // 
            // izmentb
            // 
            this.izmentb.Appearance = System.Windows.Forms.Appearance.Button;
            this.izmentb.AutoSize = true;
            this.izmentb.Location = new System.Drawing.Point(945, 90);
            this.izmentb.Name = "izmentb";
            this.izmentb.Size = new System.Drawing.Size(105, 23);
            this.izmentb.TabIndex = 32;
            this.izmentb.Text = "Изменить строку";
            this.izmentb.UseVisualStyleBackColor = true;
            this.izmentb.CheckedChanged += new System.EventHandler(this.izmentb_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(936, 624);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.row_click);
            // 
            // Название
            // 
            this.Название.Frozen = true;
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Категория";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата выпуска";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Скидка";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "%";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Единицы измерения";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Итог";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // labscid
            // 
            this.labscid.AutoSize = true;
            this.labscid.Location = new System.Drawing.Point(1128, 147);
            this.labscid.Name = "labscid";
            this.labscid.Size = new System.Drawing.Size(50, 13);
            this.labscid.TabIndex = 34;
            this.labscid.Text = "Скидка: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1300, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Управлением формой:";
            // 
            // labinfo
            // 
            this.labinfo.AutoSize = true;
            this.labinfo.Location = new System.Drawing.Point(1242, 478);
            this.labinfo.Name = "labinfo";
            this.labinfo.Size = new System.Drawing.Size(122, 13);
            this.labinfo.TabIndex = 36;
            this.labinfo.Text = "Итоговая информация";
            // 
            // labnaz
            // 
            this.labnaz.AutoSize = true;
            this.labnaz.Location = new System.Drawing.Point(945, 238);
            this.labnaz.Name = "labnaz";
            this.labnaz.Size = new System.Drawing.Size(95, 13);
            this.labnaz.TabIndex = 37;
            this.labnaz.Text = "Название столба";
            // 
            // poisknaz
            // 
            this.poisknaz.FormattingEnabled = true;
            this.poisknaz.Items.AddRange(new object[] {
            "Название",
            "Категория",
            "Дата выпуска                     ",
            "Цена                  ",
            "Количество                       ",
            "Скидка",
            "%",
            "Единицы измерения"});
            this.poisknaz.Location = new System.Drawing.Point(945, 265);
            this.poisknaz.Name = "poisknaz";
            this.poisknaz.Size = new System.Drawing.Size(95, 21);
            this.poisknaz.TabIndex = 38;
            // 
            // textpoisk
            // 
            this.textpoisk.Location = new System.Drawing.Point(945, 311);
            this.textpoisk.Name = "textpoisk";
            this.textpoisk.Size = new System.Drawing.Size(95, 20);
            this.textpoisk.TabIndex = 39;
            // 
            // labelpo
            // 
            this.labelpo.AutoSize = true;
            this.labelpo.Location = new System.Drawing.Point(945, 295);
            this.labelpo.Name = "labelpo";
            this.labelpo.Size = new System.Drawing.Size(35, 13);
            this.labelpo.TabIndex = 40;
            this.labelpo.Text = "текст";
            // 
            // buttonpoisk
            // 
            this.buttonpoisk.Location = new System.Drawing.Point(945, 337);
            this.buttonpoisk.Name = "buttonpoisk";
            this.buttonpoisk.Size = new System.Drawing.Size(75, 23);
            this.buttonpoisk.TabIndex = 41;
            this.buttonpoisk.Text = "найти";
            this.buttonpoisk.UseVisualStyleBackColor = true;
            this.buttonpoisk.Click += new System.EventHandler(this.buttonpoisk_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(945, 366);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 42;
            this.buttonclear.Text = "сброс";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // diagram
            // 
            this.diagram.Location = new System.Drawing.Point(945, 395);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(84, 45);
            this.diagram.TabIndex = 43;
            this.diagram.Text = "Открыть диаграмму";
            this.diagram.UseVisualStyleBackColor = true;
            this.diagram.Click += new System.EventHandler(this.diagram_Click);
            // 
            // zagtab
            // 
            this.zagtab.Location = new System.Drawing.Point(1032, 337);
            this.zagtab.Name = "zagtab";
            this.zagtab.Size = new System.Drawing.Size(93, 42);
            this.zagtab.TabIndex = 44;
            this.zagtab.Text = "Загрузить Таблицу";
            this.zagtab.UseVisualStyleBackColor = true;
            this.zagtab.Click += new System.EventHandler(this.zagtab_Click);
            // 
            // savetab
            // 
            this.savetab.Location = new System.Drawing.Point(1038, 398);
            this.savetab.Name = "savetab";
            this.savetab.Size = new System.Drawing.Size(86, 41);
            this.savetab.TabIndex = 45;
            this.savetab.Text = "Сохранить Таблицу";
            this.savetab.UseVisualStyleBackColor = true;
            this.savetab.Click += new System.EventHandler(this.savetab_Click);
            // 
            // glavnoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1440, 643);
            this.Controls.Add(this.savetab);
            this.Controls.Add(this.zagtab);
            this.Controls.Add(this.diagram);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonpoisk);
            this.Controls.Add(this.labelpo);
            this.Controls.Add(this.textpoisk);
            this.Controls.Add(this.poisknaz);
            this.Controls.Add(this.labnaz);
            this.Controls.Add(this.labinfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labscid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.izmentb);
            this.Controls.Add(this.obnovtb);
            this.Controls.Add(this.cleartb);
            this.Controls.Add(this.delettb);
            this.Controls.Add(this.wottb);
            this.Controls.Add(this.saved);
            this.Controls.Add(this.dowl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dowloadpuchere);
            this.Controls.Add(this.dowload);
            this.Controls.Add(this.imae);
            this.Controls.Add(this.polz);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.xovo);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vixod);
            this.Controls.Add(this.info);
            this.Controls.Add(this.osistka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckidkaa);
            this.Controls.Add(this.ckidka);
            this.Controls.Add(this.kolvo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.kateg);
            this.Controls.Add(this.nasvanie);
            this.Controls.Add(this.visil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "glavnoe";
            this.Text = "gh 4";
            ((System.ComponentModel.ISupportInitialize)(this.ckidkaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button visil;
        private System.Windows.Forms.TextBox nasvanie;
        private System.Windows.Forms.ComboBox kateg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox kolvo;
        private System.Windows.Forms.CheckBox ckidka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button osistka;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button vixod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.RichTextBox xovo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label polz;
        public System.Windows.Forms.Label imae;
        public System.Windows.Forms.NumericUpDown ckidkaa;
        private System.Windows.Forms.Button dowload;
        private System.Windows.Forms.Button dowloadpuchere;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dowl;
        private System.Windows.Forms.Button saved;
        private System.Windows.Forms.Button wottb;
        private System.Windows.Forms.Button delettb;
        private System.Windows.Forms.Button cleartb;
        private System.Windows.Forms.Button obnovtb;
        private System.Windows.Forms.CheckBox izmentb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label labscid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labinfo;
        private System.Windows.Forms.Label labnaz;
        private System.Windows.Forms.ComboBox poisknaz;
        private System.Windows.Forms.TextBox textpoisk;
        private System.Windows.Forms.Label labelpo;
        private System.Windows.Forms.Button buttonpoisk;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button diagram;
        private System.Windows.Forms.Button zagtab;
        private System.Windows.Forms.Button savetab;
    }
}

