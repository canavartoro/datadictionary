namespace WarehouseManagementDictionary
{
    partial class FormDictionary
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
            this.btnschemafile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtschemafile = new System.Windows.Forms.TextBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewTables = new System.Windows.Forms.ListView();
            this.columnHeaderSira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtnamespace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtschema = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXpo = new System.Windows.Forms.RadioButton();
            this.rdbUyum = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnschemafile
            // 
            this.btnschemafile.Location = new System.Drawing.Point(691, 10);
            this.btnschemafile.Name = "btnschemafile";
            this.btnschemafile.Size = new System.Drawing.Size(75, 23);
            this.btnschemafile.TabIndex = 0;
            this.btnschemafile.Text = "Gözat";
            this.btnschemafile.UseVisualStyleBackColor = true;
            this.btnschemafile.Click += new System.EventHandler(this.btnschemafile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel";
            // 
            // txtschemafile
            // 
            this.txtschemafile.Location = new System.Drawing.Point(71, 12);
            this.txtschemafile.Name = "txtschemafile";
            this.txtschemafile.Size = new System.Drawing.Size(614, 20);
            this.txtschemafile.TabIndex = 2;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(68, 227);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(232, 68);
            this.btnimport.TabIndex = 3;
            this.btnimport.Text = "İçeri al";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(306, 227);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(232, 68);
            this.btnexport.TabIndex = 3;
            this.btnexport.Text = "Dışa aktar";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 366);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 393);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewTables);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewTables
            // 
            this.listViewTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSira,
            this.columnHeaderAdi,
            this.columnHeaderAciklama,
            this.columnHeaderPrefix});
            this.listViewTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTables.FullRowSelect = true;
            this.listViewTables.GridLines = true;
            this.listViewTables.Location = new System.Drawing.Point(3, 3);
            this.listViewTables.Name = "listViewTables";
            this.listViewTables.Size = new System.Drawing.Size(580, 361);
            this.listViewTables.TabIndex = 0;
            this.listViewTables.UseCompatibleStateImageBehavior = false;
            this.listViewTables.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSira
            // 
            this.columnHeaderSira.Text = "Sıra";
            this.columnHeaderSira.Width = 90;
            // 
            // columnHeaderAdi
            // 
            this.columnHeaderAdi.Text = "Tablo Adı";
            this.columnHeaderAdi.Width = 170;
            // 
            // columnHeaderAciklama
            // 
            this.columnHeaderAciklama.Text = "Açıklama";
            this.columnHeaderAciklama.Width = 160;
            // 
            // columnHeaderPrefix
            // 
            this.columnHeaderPrefix.Text = "Prefix";
            this.columnHeaderPrefix.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtnamespace
            // 
            this.txtnamespace.Location = new System.Drawing.Point(109, 86);
            this.txtnamespace.Name = "txtnamespace";
            this.txtnamespace.Size = new System.Drawing.Size(329, 20);
            this.txtnamespace.TabIndex = 5;
            this.txtnamespace.Text = "WHM.Module.BusinessObjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "namespace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "schema";
            // 
            // txtschema
            // 
            this.txtschema.Location = new System.Drawing.Point(109, 112);
            this.txtschema.Name = "txtschema";
            this.txtschema.Size = new System.Drawing.Size(329, 20);
            this.txtschema.TabIndex = 5;
            this.txtschema.Text = "public";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXpo);
            this.groupBox1.Controls.Add(this.rdbUyum);
            this.groupBox1.Location = new System.Drawing.Point(547, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbXpo
            // 
            this.rdbXpo.AutoSize = true;
            this.rdbXpo.Location = new System.Drawing.Point(21, 48);
            this.rdbXpo.Name = "rdbXpo";
            this.rdbXpo.Size = new System.Drawing.Size(75, 17);
            this.rdbXpo.TabIndex = 0;
            this.rdbXpo.TabStop = true;
            this.rdbXpo.Text = "XPO Class";
            this.rdbXpo.UseVisualStyleBackColor = true;
            // 
            // rdbUyum
            // 
            this.rdbUyum.AutoSize = true;
            this.rdbUyum.Checked = true;
            this.rdbUyum.Location = new System.Drawing.Point(21, 28);
            this.rdbUyum.Name = "rdbUyum";
            this.rdbUyum.Size = new System.Drawing.Size(80, 17);
            this.rdbUyum.TabIndex = 0;
            this.rdbUyum.TabStop = true;
            this.rdbUyum.Text = "Uyum Class";
            this.rdbUyum.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(691, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Gözat";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yol";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(71, 35);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(614, 20);
            this.txtpath.TabIndex = 2;
            // 
            // FormDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 792);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtschema);
            this.Controls.Add(this.txtnamespace);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.txtschemafile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnschemafile);
            this.Name = "FormDictionary";
            this.Text = "Warehouse Management Dictionary";
            this.Load += new System.EventHandler(this.FormDictionary_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnschemafile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtschemafile;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewTables;
        private System.Windows.Forms.ColumnHeader columnHeaderSira;
        private System.Windows.Forms.ColumnHeader columnHeaderAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderAciklama;
        private System.Windows.Forms.ColumnHeader columnHeaderPrefix;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtnamespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtschema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbXpo;
        private System.Windows.Forms.RadioButton rdbUyum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpath;
    }
}