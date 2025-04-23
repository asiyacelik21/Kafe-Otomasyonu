namespace CafeOtomasyonu
{
    partial class frmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yöneticiÇağırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.masadegistirmeistegigonder = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HareketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._MasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Masaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İstekTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarihh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapla = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbBosMasalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtn165 = new System.Windows.Forms.RadioButton();
            this.rdbtn135 = new System.Windows.Forms.RadioButton();
            this.rdbtn105 = new System.Windows.Forms.RadioButton();
            this.rdbtn180 = new System.Windows.Forms.RadioButton();
            this.rdbtn120 = new System.Windows.Forms.RadioButton();
            this.rdbtn150 = new System.Windows.Forms.RadioButton();
            this.rdbtn60 = new System.Windows.Forms.RadioButton();
            this.rdbtn90 = new System.Windows.Forms.RadioButton();
            this.rdbtn45 = new System.Windows.Forms.RadioButton();
            this.rdbtn75 = new System.Windows.Forms.RadioButton();
            this.rdbtn30 = new System.Windows.Forms.RadioButton();
            this.rdbtnSuresiz = new System.Windows.Forms.RadioButton();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSaatUcreti = new System.Windows.Forms.ComboBox();
            this.tblSaatUcretiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetCafeDataSet = new CafeOtomasyonu.InternetCafeDataSet();
            this.tbl_SaatUcretiTableAdapter = new CafeOtomasyonu.InternetCafeDataSetTableAdapters.Tbl_SaatUcretiTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMasaDegistir = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaatUcretiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiÇağırToolStripMenuItem,
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem,
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem,
            this.masadegistirmeistegigonder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(299, 100);
            // 
            // yöneticiÇağırToolStripMenuItem
            // 
            this.yöneticiÇağırToolStripMenuItem.Name = "yöneticiÇağırToolStripMenuItem";
            this.yöneticiÇağırToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.yöneticiÇağırToolStripMenuItem.Text = "Yönetici Çağır";
            this.yöneticiÇağırToolStripMenuItem.Click += new System.EventHandler(this.yöneticiÇağırToolStripMenuItem_Click);
            // 
            // süresizMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süresizMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süresiz Masa Açma İsteği Gönder";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click);
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süreli Masa Açma İsteği Gönder";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem2.Text = "30";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem3.Text = "45";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem4.Text = "60";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem5.Text = "75";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem6.Text = "90";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem7.Text = "105";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem8.Text = "120";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem9.Text = "135";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem10.Text = "150";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem11.Text = "165";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem12.Text = "180";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // masadegistirmeistegigonder
            // 
            this.masadegistirmeistegigonder.Name = "masadegistirmeistegigonder";
            this.masadegistirmeistegigonder.Size = new System.Drawing.Size(298, 24);
            this.masadegistirmeistegigonder.Text = "Masa Değiştirme İsteği Gönder";
            this.masadegistirmeistegigonder.Click += new System.EventHandler(this.masadegistirmeistegigonder_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HareketID,
            this.KullaniciID,
            this._MasaID,
            this.Masaa,
            this.İstekTuru,
            this._Aciklama,
            this.Tarihh});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(959, 152);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HareketID
            // 
            this.HareketID.Text = "IstekID";
            // 
            // KullaniciID
            // 
            this.KullaniciID.Text = "Kullanıcı ID";
            // 
            // _MasaID
            // 
            this._MasaID.Text = "Masa ID";
            // 
            // Masaa
            // 
            this.Masaa.Text = "Masa";
            // 
            // İstekTuru
            // 
            this.İstekTuru.Text = "İstek Türü";
            // 
            // _Aciklama
            // 
            this._Aciklama.Text = "Açıklama";
            // 
            // Tarihh
            // 
            this.Tarihh.Text = "Tarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Masa_ID,
            this._Masa,
            this.AcilisTuru,
            this.BaslamaSaati,
            this.BitisSaati,
            this.Sure,
            this.Tutar,
            this._Tarih,
            this.Hesapla,
            this.MasaKapat});
            this.dataGridView1.Location = new System.Drawing.Point(9, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 184);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SepetID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Masa_ID
            // 
            this.Masa_ID.DataPropertyName = "MasaID";
            this.Masa_ID.HeaderText = "Masa_ID";
            this.Masa_ID.MinimumWidth = 6;
            this.Masa_ID.Name = "Masa_ID";
            this.Masa_ID.ReadOnly = true;
            // 
            // _Masa
            // 
            this._Masa.DataPropertyName = "Masa";
            this._Masa.FillWeight = 53.04812F;
            this._Masa.HeaderText = "Masa";
            this._Masa.MinimumWidth = 6;
            this._Masa.Name = "_Masa";
            this._Masa.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.FillWeight = 53.04812F;
            this.AcilisTuru.HeaderText = "Açılış Türü(dk)";
            this.AcilisTuru.MinimumWidth = 6;
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "Baslangic";
            this.BaslamaSaati.FillWeight = 53.04812F;
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.MinimumWidth = 6;
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            // 
            // BitisSaati
            // 
            this.BitisSaati.FillWeight = 53.04812F;
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.MinimumWidth = 6;
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            // 
            // Sure
            // 
            this.Sure.FillWeight = 53.04812F;
            this.Sure.HeaderText = "Süre(Saat)";
            this.Sure.MinimumWidth = 6;
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.FillWeight = 53.04812F;
            this.Tutar.HeaderText = "Tutar(TL)";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // _Tarih
            // 
            this._Tarih.DataPropertyName = "Tarih";
            this._Tarih.FillWeight = 53.04812F;
            this._Tarih.HeaderText = "Tarih";
            this._Tarih.MinimumWidth = 6;
            this._Tarih.Name = "_Tarih";
            this._Tarih.ReadOnly = true;
            // 
            // Hesapla
            // 
            this.Hesapla.FillWeight = 53.04812F;
            this.Hesapla.HeaderText = "Hesapla";
            this.Hesapla.MinimumWidth = 6;
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.ReadOnly = true;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.ToolTipText = "Hesaplama Yapar6";
            this.Hesapla.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            this.MasaKapat.FillWeight = 53.04812F;
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.MinimumWidth = 6;
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa Kapat";
            this.MasaKapat.ToolTipText = "Masayı Kapatır";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // cmbBosMasalar
            // 
            this.cmbBosMasalar.FormattingEnabled = true;
            this.cmbBosMasalar.Location = new System.Drawing.Point(984, 204);
            this.cmbBosMasalar.Name = "cmbBosMasalar";
            this.cmbBosMasalar.Size = new System.Drawing.Size(193, 24);
            this.cmbBosMasalar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(989, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Boş Masalar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbtn165);
            this.panel1.Controls.Add(this.rdbtn135);
            this.panel1.Controls.Add(this.rdbtn105);
            this.panel1.Controls.Add(this.rdbtn180);
            this.panel1.Controls.Add(this.rdbtn120);
            this.panel1.Controls.Add(this.rdbtn150);
            this.panel1.Controls.Add(this.rdbtn60);
            this.panel1.Controls.Add(this.rdbtn90);
            this.panel1.Controls.Add(this.rdbtn45);
            this.panel1.Controls.Add(this.rdbtn75);
            this.panel1.Controls.Add(this.rdbtn30);
            this.panel1.Controls.Add(this.rdbtnSuresiz);
            this.panel1.Location = new System.Drawing.Point(984, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 183);
            this.panel1.TabIndex = 24;
            // 
            // rdbtn165
            // 
            this.rdbtn165.AutoSize = true;
            this.rdbtn165.Location = new System.Drawing.Point(8, 142);
            this.rdbtn165.Name = "rdbtn165";
            this.rdbtn165.Size = new System.Drawing.Size(49, 20);
            this.rdbtn165.TabIndex = 36;
            this.rdbtn165.TabStop = true;
            this.rdbtn165.Text = "165";
            this.rdbtn165.UseVisualStyleBackColor = true;
            this.rdbtn165.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn135
            // 
            this.rdbtn135.AutoSize = true;
            this.rdbtn135.Location = new System.Drawing.Point(8, 116);
            this.rdbtn135.Name = "rdbtn135";
            this.rdbtn135.Size = new System.Drawing.Size(49, 20);
            this.rdbtn135.TabIndex = 35;
            this.rdbtn135.TabStop = true;
            this.rdbtn135.Text = "135";
            this.rdbtn135.UseVisualStyleBackColor = true;
            this.rdbtn135.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn105
            // 
            this.rdbtn105.AutoSize = true;
            this.rdbtn105.Location = new System.Drawing.Point(8, 90);
            this.rdbtn105.Name = "rdbtn105";
            this.rdbtn105.Size = new System.Drawing.Size(49, 20);
            this.rdbtn105.TabIndex = 34;
            this.rdbtn105.TabStop = true;
            this.rdbtn105.Text = "105";
            this.rdbtn105.UseVisualStyleBackColor = true;
            this.rdbtn105.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn180
            // 
            this.rdbtn180.AutoSize = true;
            this.rdbtn180.Location = new System.Drawing.Point(114, 142);
            this.rdbtn180.Name = "rdbtn180";
            this.rdbtn180.Size = new System.Drawing.Size(49, 20);
            this.rdbtn180.TabIndex = 33;
            this.rdbtn180.TabStop = true;
            this.rdbtn180.Text = "180";
            this.rdbtn180.UseVisualStyleBackColor = true;
            this.rdbtn180.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn120
            // 
            this.rdbtn120.AutoSize = true;
            this.rdbtn120.Location = new System.Drawing.Point(115, 90);
            this.rdbtn120.Name = "rdbtn120";
            this.rdbtn120.Size = new System.Drawing.Size(49, 20);
            this.rdbtn120.TabIndex = 32;
            this.rdbtn120.TabStop = true;
            this.rdbtn120.Text = "120";
            this.rdbtn120.UseVisualStyleBackColor = true;
            this.rdbtn120.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn150
            // 
            this.rdbtn150.AutoSize = true;
            this.rdbtn150.Location = new System.Drawing.Point(114, 116);
            this.rdbtn150.Name = "rdbtn150";
            this.rdbtn150.Size = new System.Drawing.Size(49, 20);
            this.rdbtn150.TabIndex = 31;
            this.rdbtn150.TabStop = true;
            this.rdbtn150.Text = "150";
            this.rdbtn150.UseVisualStyleBackColor = true;
            this.rdbtn150.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn60
            // 
            this.rdbtn60.AutoSize = true;
            this.rdbtn60.Location = new System.Drawing.Point(114, 38);
            this.rdbtn60.Name = "rdbtn60";
            this.rdbtn60.Size = new System.Drawing.Size(42, 20);
            this.rdbtn60.TabIndex = 30;
            this.rdbtn60.TabStop = true;
            this.rdbtn60.Text = "60";
            this.rdbtn60.UseVisualStyleBackColor = true;
            this.rdbtn60.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn90
            // 
            this.rdbtn90.AutoSize = true;
            this.rdbtn90.Location = new System.Drawing.Point(114, 64);
            this.rdbtn90.Name = "rdbtn90";
            this.rdbtn90.Size = new System.Drawing.Size(42, 20);
            this.rdbtn90.TabIndex = 29;
            this.rdbtn90.TabStop = true;
            this.rdbtn90.Text = "90";
            this.rdbtn90.UseVisualStyleBackColor = true;
            this.rdbtn90.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn45
            // 
            this.rdbtn45.AutoSize = true;
            this.rdbtn45.Location = new System.Drawing.Point(8, 38);
            this.rdbtn45.Name = "rdbtn45";
            this.rdbtn45.Size = new System.Drawing.Size(42, 20);
            this.rdbtn45.TabIndex = 28;
            this.rdbtn45.TabStop = true;
            this.rdbtn45.Text = "45";
            this.rdbtn45.UseVisualStyleBackColor = true;
            this.rdbtn45.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn75
            // 
            this.rdbtn75.AutoSize = true;
            this.rdbtn75.Location = new System.Drawing.Point(8, 64);
            this.rdbtn75.Name = "rdbtn75";
            this.rdbtn75.Size = new System.Drawing.Size(42, 20);
            this.rdbtn75.TabIndex = 28;
            this.rdbtn75.TabStop = true;
            this.rdbtn75.Text = "75";
            this.rdbtn75.UseVisualStyleBackColor = true;
            this.rdbtn75.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtn30
            // 
            this.rdbtn30.AutoSize = true;
            this.rdbtn30.Location = new System.Drawing.Point(115, 12);
            this.rdbtn30.Name = "rdbtn30";
            this.rdbtn30.Size = new System.Drawing.Size(42, 20);
            this.rdbtn30.TabIndex = 27;
            this.rdbtn30.TabStop = true;
            this.rdbtn30.Text = "30";
            this.rdbtn30.UseVisualStyleBackColor = true;
            this.rdbtn30.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdbtnSuresiz
            // 
            this.rdbtnSuresiz.AutoSize = true;
            this.rdbtnSuresiz.Location = new System.Drawing.Point(11, 12);
            this.rdbtnSuresiz.Name = "rdbtnSuresiz";
            this.rdbtnSuresiz.Size = new System.Drawing.Size(72, 20);
            this.rdbtnSuresiz.TabIndex = 26;
            this.rdbtnSuresiz.TabStop = true;
            this.rdbtnSuresiz.Text = "Süresiz";
            this.rdbtnSuresiz.UseVisualStyleBackColor = true;
            this.rdbtnSuresiz.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(1005, 418);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(160, 43);
            this.btnMasaAc.TabIndex = 25;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "images (1).jpeg");
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "images (1).jpeg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(1, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 117);
            this.button1.TabIndex = 26;
            this.button1.Text = "Masa-1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "images (1).jpeg";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(119, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 117);
            this.button2.TabIndex = 27;
            this.button2.Text = "Masa-2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "images (1).jpeg";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(238, -4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 117);
            this.button3.TabIndex = 28;
            this.button3.Text = "Masa-3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "images (1).jpeg";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(361, -4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 117);
            this.button4.TabIndex = 29;
            this.button4.Text = "Masa-4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button5
            // 
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "images (1).jpeg";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(484, -4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 117);
            this.button5.TabIndex = 30;
            this.button5.Text = "Masa-5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button6
            // 
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageKey = "images (1).jpeg";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(603, -4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 117);
            this.button6.TabIndex = 31;
            this.button6.Text = "Masa-6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button7
            // 
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ImageKey = "images (1).jpeg";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(722, -4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 117);
            this.button7.TabIndex = 32;
            this.button7.Text = "Masa-7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button8
            // 
            this.button8.ContextMenuStrip = this.contextMenuStrip1;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ImageKey = "images (1).jpeg";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(848, -4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 117);
            this.button8.TabIndex = 33;
            this.button8.Text = "Masa-8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button9
            // 
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ImageKey = "images (1).jpeg";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(973, -4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 117);
            this.button9.TabIndex = 34;
            this.button9.Text = "Masa-9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button10
            // 
            this.button10.ContextMenuStrip = this.contextMenuStrip1;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ImageKey = "images (1).jpeg";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(1088, -4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 117);
            this.button10.TabIndex = 35;
            this.button10.Text = "Masa-10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button11
            // 
            this.button11.ContextMenuStrip = this.contextMenuStrip1;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ImageKey = "images (1).jpeg";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(12, 495);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 120);
            this.button11.TabIndex = 45;
            this.button11.Text = "Masa-11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button12
            // 
            this.button12.ContextMenuStrip = this.contextMenuStrip1;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ImageKey = "images (1).jpeg";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(119, 495);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 120);
            this.button12.TabIndex = 44;
            this.button12.Text = "Masa-12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button13
            // 
            this.button13.ContextMenuStrip = this.contextMenuStrip1;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ImageKey = "images (1).jpeg";
            this.button13.ImageList = this.ımageList1;
            this.button13.Location = new System.Drawing.Point(238, 495);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 120);
            this.button13.TabIndex = 43;
            this.button13.Text = "Masa-13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button14
            // 
            this.button14.ContextMenuStrip = this.contextMenuStrip1;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ImageKey = "images (1).jpeg";
            this.button14.ImageList = this.ımageList1;
            this.button14.Location = new System.Drawing.Point(361, 492);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 120);
            this.button14.TabIndex = 42;
            this.button14.Text = "Masa-14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button15
            // 
            this.button15.ContextMenuStrip = this.contextMenuStrip1;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ImageKey = "images (1).jpeg";
            this.button15.ImageList = this.ımageList1;
            this.button15.Location = new System.Drawing.Point(484, 492);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 120);
            this.button15.TabIndex = 41;
            this.button15.Text = "Masa-15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button16
            // 
            this.button16.ContextMenuStrip = this.contextMenuStrip1;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ImageKey = "images (1).jpeg";
            this.button16.ImageList = this.ımageList1;
            this.button16.Location = new System.Drawing.Point(603, 492);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(89, 120);
            this.button16.TabIndex = 40;
            this.button16.Text = "Masa-16";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button17
            // 
            this.button17.ContextMenuStrip = this.contextMenuStrip1;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ImageKey = "images (1).jpeg";
            this.button17.ImageList = this.ımageList1;
            this.button17.Location = new System.Drawing.Point(722, 492);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(89, 120);
            this.button17.TabIndex = 39;
            this.button17.Text = "Masa-17";
            this.button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button18
            // 
            this.button18.ContextMenuStrip = this.contextMenuStrip1;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ImageKey = "images (1).jpeg";
            this.button18.ImageList = this.ımageList1;
            this.button18.Location = new System.Drawing.Point(848, 492);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 120);
            this.button18.TabIndex = 38;
            this.button18.Text = "Masa-18";
            this.button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button19
            // 
            this.button19.ContextMenuStrip = this.contextMenuStrip1;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ImageKey = "images (1).jpeg";
            this.button19.ImageList = this.ımageList1;
            this.button19.Location = new System.Drawing.Point(973, 506);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(89, 109);
            this.button19.TabIndex = 37;
            this.button19.Text = "Masa-19";
            this.button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button20
            // 
            this.button20.ContextMenuStrip = this.contextMenuStrip1;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ImageKey = "images (1).jpeg";
            this.button20.ImageList = this.ımageList1;
            this.button20.Location = new System.Drawing.Point(1076, 506);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(89, 109);
            this.button20.TabIndex = 36;
            this.button20.Text = "Masa-20";
            this.button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(989, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Saat Ücreti";
            // 
            // cmbSaatUcreti
            // 
            this.cmbSaatUcreti.DataSource = this.tblSaatUcretiBindingSource;
            this.cmbSaatUcreti.DisplayMember = "SaatUcreti";
            this.cmbSaatUcreti.FormattingEnabled = true;
            this.cmbSaatUcreti.Location = new System.Drawing.Point(984, 151);
            this.cmbSaatUcreti.Name = "cmbSaatUcreti";
            this.cmbSaatUcreti.Size = new System.Drawing.Size(193, 24);
            this.cmbSaatUcreti.TabIndex = 46;
            this.cmbSaatUcreti.ValueMember = "SaatUcretiID";
            // 
            // tblSaatUcretiBindingSource
            // 
            this.tblSaatUcretiBindingSource.DataMember = "Tbl_SaatUcreti";
            this.tblSaatUcretiBindingSource.DataSource = this.internetCafeDataSet;
            // 
            // internetCafeDataSet
            // 
            this.internetCafeDataSet.DataSetName = "InternetCafeDataSet";
            this.internetCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_SaatUcretiTableAdapter
            // 
            this.tbl_SaatUcretiTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMasaDegistir
            // 
            this.btnMasaDegistir.Location = new System.Drawing.Point(1005, 467);
            this.btnMasaDegistir.Name = "btnMasaDegistir";
            this.btnMasaDegistir.Size = new System.Drawing.Size(160, 43);
            this.btnMasaDegistir.TabIndex = 48;
            this.btnMasaDegistir.Text = "Masa Değiştir";
            this.btnMasaDegistir.UseVisualStyleBackColor = true;
            this.btnMasaDegistir.Click += new System.EventHandler(this.btnMasaDegistir_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(839, 467);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(160, 43);
            this.btnGeriAl.TabIndex = 49;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 624);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnMasaDegistir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSaatUcreti);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBosMasalar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmSatis";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaatUcretiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBosMasalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.RadioButton rdbtn165;
        private System.Windows.Forms.RadioButton rdbtn135;
        private System.Windows.Forms.RadioButton rdbtn105;
        private System.Windows.Forms.RadioButton rdbtn180;
        private System.Windows.Forms.RadioButton rdbtn120;
        private System.Windows.Forms.RadioButton rdbtn150;
        private System.Windows.Forms.RadioButton rdbtn60;
        private System.Windows.Forms.RadioButton rdbtn90;
        private System.Windows.Forms.RadioButton rdbtn45;
        private System.Windows.Forms.RadioButton rdbtn75;
        private System.Windows.Forms.RadioButton rdbtn30;
        private System.Windows.Forms.RadioButton rdbtnSuresiz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiÇağırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süresizMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem masadegistirmeistegigonder;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSaatUcreti;
        private InternetCafeDataSet internetCafeDataSet;
        private System.Windows.Forms.BindingSource tblSaatUcretiBindingSource;
        private InternetCafeDataSetTableAdapters.Tbl_SaatUcretiTableAdapter tbl_SaatUcretiTableAdapter;
        private System.Windows.Forms.ColumnHeader HareketID;
        private System.Windows.Forms.ColumnHeader KullaniciID;
        private System.Windows.Forms.ColumnHeader _MasaID;
        private System.Windows.Forms.ColumnHeader Masaa;
        private System.Windows.Forms.ColumnHeader İstekTuru;
        private System.Windows.Forms.ColumnHeader _Aciklama;
        private System.Windows.Forms.ColumnHeader Tarihh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMasaDegistir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Hesapla;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
        private System.Windows.Forms.Button btnGeriAl;
    }
}

