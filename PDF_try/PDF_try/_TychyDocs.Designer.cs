namespace PDF_try
{
    partial class _TychyDocs
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
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("i");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("mwp");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "mwt"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("ot");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("s");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("stech");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("wxy");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("gps");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("k");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("opio");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("osio");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("owxyz");
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("so");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("wzg");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("wps");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("dzp");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("obw");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("obp");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_TychyDocs));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnKopiujZPodfolderow = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.gbKatalogi = new System.Windows.Forms.GroupBox();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.txtInnyDokument = new System.Windows.Forms.TextBox();
            this.btnInnyDokument = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumer = new System.Windows.Forms.TextBox();
            this.tbKerg = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFolder = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbKatalogi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 767);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRotateRight);
            this.splitContainer1.Panel1.Controls.Add(this.btnRotate180);
            this.splitContainer1.Panel1.Controls.Add(this.btnRotateLeft);
            this.splitContainer1.Panel1.Controls.Add(this.btnKopiujZPodfolderow);
            this.splitContainer1.Panel1.Controls.Add(this.btnStatus);
            this.splitContainer1.Panel1.Controls.Add(this.gbKatalogi);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbNumer);
            this.splitContainer1.Panel1.Controls.Add(this.tbKerg);
            this.splitContainer1.Panel1.Controls.Add(this.lblFolder);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.btnFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axAcroPDF1);
            this.splitContainer1.Size = new System.Drawing.Size(1632, 767);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.TabIndex = 15;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(531, 133);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(43, 26);
            this.btnRotateRight.TabIndex = 19;
            this.btnRotateRight.Text = "+90";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(483, 133);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(45, 26);
            this.btnRotate180.TabIndex = 18;
            this.btnRotate180.Text = "180";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(437, 133);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(43, 26);
            this.btnRotateLeft.TabIndex = 4;
            this.btnRotateLeft.Text = "-90";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnKopiujZPodfolderow
            // 
            this.btnKopiujZPodfolderow.Location = new System.Drawing.Point(9, 39);
            this.btnKopiujZPodfolderow.Name = "btnKopiujZPodfolderow";
            this.btnKopiujZPodfolderow.Size = new System.Drawing.Size(231, 23);
            this.btnKopiujZPodfolderow.TabIndex = 17;
            this.btnKopiujZPodfolderow.Text = "Kopiuj pliki z podfolderów";
            this.btnKopiujZPodfolderow.UseVisualStyleBackColor = true;
            this.btnKopiujZPodfolderow.Click += new System.EventHandler(this.btnKopiujZPodfolderow_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(437, 15);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(137, 103);
            this.btnStatus.TabIndex = 16;
            this.btnStatus.Text = "STATUS";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // gbKatalogi
            // 
            this.gbKatalogi.Controls.Add(this.btnLoadFromFile);
            this.gbKatalogi.Controls.Add(this.txtInnyDokument);
            this.gbKatalogi.Controls.Add(this.btnInnyDokument);
            this.gbKatalogi.Controls.Add(this.listView1);
            this.gbKatalogi.Location = new System.Drawing.Point(9, 425);
            this.gbKatalogi.Name = "gbKatalogi";
            this.gbKatalogi.Size = new System.Drawing.Size(565, 334);
            this.gbKatalogi.TabIndex = 15;
            this.gbKatalogi.TabStop = false;
            this.gbKatalogi.Text = "Wykonaj akcję:";
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(428, 292);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFromFile.TabIndex = 3;
            this.btnLoadFromFile.Text = "menu z pliku";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // txtInnyDokument
            // 
            this.txtInnyDokument.Location = new System.Drawing.Point(88, 292);
            this.txtInnyDokument.Name = "txtInnyDokument";
            this.txtInnyDokument.Size = new System.Drawing.Size(83, 20);
            this.txtInnyDokument.TabIndex = 2;
            this.txtInnyDokument.Text = "ORG";
            this.txtInnyDokument.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInnyDokument
            // 
            this.btnInnyDokument.Location = new System.Drawing.Point(7, 290);
            this.btnInnyDokument.Name = "btnInnyDokument";
            this.btnInnyDokument.Size = new System.Drawing.Size(75, 23);
            this.btnInnyDokument.TabIndex = 1;
            this.btnInnyDokument.Text = "inny";
            this.btnInnyDokument.UseVisualStyleBackColor = true;
            this.btnInnyDokument.Click += new System.EventHandler(this.btnInnyDokument_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            listViewItem19.ToolTipText = "inny dokument";
            listViewItem20.ToolTipText = "mapa wynikowa pracy geodezyjnej";
            listViewItem21.ToolTipText = "mapa wywiadu terenowego";
            listViewItem22.ToolTipText = "okładka operatu i spis treści";
            listViewItem23.ToolTipText = "szkic polowy sytuacyjny";
            listViewItem24.ToolTipText = "sprawozdanie techniczne";
            listViewItem25.ToolTipText = "wykaz współrzędnych";
            listViewItem26.ToolTipText = "pomiar GPS";
            listViewItem27.ToolTipText = "karta ewidencyjna budynku";
            listViewItem28.ToolTipText = "protokół inwentaryzacji osnowy";
            listViewItem29.ToolTipText = "szkic inwentaryzacji osnowy";
            listViewItem30.ToolTipText = "wykaz współrzędnych osnowy";
            listViewItem31.ToolTipText = "szkic osnowy";
            listViewItem32.ToolTipText = "wykaz zmian danych ewidencyjnych";
            listViewItem33.ToolTipText = "wypis z RG lub kartoteki budynków";
            listViewItem34.ToolTipText = "dziennik pomiarowy";
            listViewItem35.ToolTipText = "obliczenie współrzednych";
            listViewItem36.ToolTipText = "obliczenie powierzchni";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36});
            this.listView1.Location = new System.Drawing.Point(7, 50);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(552, 222);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "plik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "nr P = folder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNumer
            // 
            this.tbNumer.Location = new System.Drawing.Point(140, 92);
            this.tbNumer.Name = "tbNumer";
            this.tbNumer.Size = new System.Drawing.Size(100, 20);
            this.tbNumer.TabIndex = 12;
            this.tbNumer.Text = "1";
            this.tbNumer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKerg
            // 
            this.tbKerg.Location = new System.Drawing.Point(16, 92);
            this.tbKerg.Name = "tbKerg";
            this.tbKerg.Size = new System.Drawing.Size(100, 20);
            this.tbKerg.TabIndex = 11;
            this.tbKerg.Text = "725";
            this.tbKerg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKerg.TextChanged += new System.EventHandler(this.tbKerg_TextChanged);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(122, 15);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(58, 13);
            this.lblFolder.TabIndex = 10;
            this.lblFolder.Text = "labelFolder";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file});
            this.dataGridView1.Location = new System.Drawing.Point(9, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 214);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // file
            // 
            this.file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.file.FillWeight = 200F;
            this.file.HeaderText = "Pliki PDF";
            this.file.MinimumWidth = 50;
            this.file.Name = "file";
            this.file.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(9, 10);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(107, 23);
            this.btnFolder.TabIndex = 8;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1043, 767);
            this.axAcroPDF1.TabIndex = 14;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // _TychyDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 767);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_TychyDocs";
            this.Text = "Grudziadz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._TychyDocs_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbKatalogi.ResumeLayout(false);
            this.gbKatalogi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.Button btnFolder;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumer;
        private System.Windows.Forms.TextBox tbKerg;
        private System.Windows.Forms.GroupBox gbKatalogi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.TextBox txtInnyDokument;
        private System.Windows.Forms.Button btnInnyDokument;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnKopiujZPodfolderow;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotate180;
    }
}

