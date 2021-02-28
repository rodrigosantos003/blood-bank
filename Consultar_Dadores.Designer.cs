namespace BancoSangue
{
    partial class Consultar_Dadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Dadores));
            this.dgv_Dadores = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemóvelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeSangueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatorRHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_ManagementDataSet = new BancoSangue.BD_ManagementDataSet();
            this.table_DadosTableAdapter = new BancoSangue.BD_ManagementDataSetTableAdapters.Table_DadosTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ConsultarColheitas = new System.Windows.Forms.ToolStripMenuItem();
            this.insertData = new System.Windows.Forms.TabPage();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.txtInsertCC = new System.Windows.Forms.TextBox();
            this.txtInsertRH = new System.Windows.Forms.TextBox();
            this.txtInsertBlood = new System.Windows.Forms.TextBox();
            this.txtInsertTlm = new System.Windows.Forms.TextBox();
            this.txtInsertAddress = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchData = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchRH = new System.Windows.Forms.TextBox();
            this.txtSearchBlood = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ManagementDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.insertData.SuspendLayout();
            this.searchData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Dadores
            // 
            this.dgv_Dadores.AutoGenerateColumns = false;
            this.dgv_Dadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cCDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.telemóvelDataGridViewTextBoxColumn,
            this.tipoDeSangueDataGridViewTextBoxColumn,
            this.fatorRHDataGridViewTextBoxColumn});
            this.dgv_Dadores.DataSource = this.tableDadosBindingSource;
            this.dgv_Dadores.Location = new System.Drawing.Point(4, 367);
            this.dgv_Dadores.Name = "dgv_Dadores";
            this.dgv_Dadores.RowHeadersWidth = 60;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Dadores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Dadores.RowTemplate.Height = 24;
            this.dgv_Dadores.Size = new System.Drawing.Size(1000, 350);
            this.dgv_Dadores.TabIndex = 3;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cCDataGridViewTextBoxColumn
            // 
            this.cCDataGridViewTextBoxColumn.DataPropertyName = "CC";
            this.cCDataGridViewTextBoxColumn.HeaderText = "CC";
            this.cCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCDataGridViewTextBoxColumn.Name = "cCDataGridViewTextBoxColumn";
            this.cCDataGridViewTextBoxColumn.Width = 125;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telemóvelDataGridViewTextBoxColumn
            // 
            this.telemóvelDataGridViewTextBoxColumn.DataPropertyName = "Telemóvel";
            this.telemóvelDataGridViewTextBoxColumn.HeaderText = "Telemóvel";
            this.telemóvelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telemóvelDataGridViewTextBoxColumn.Name = "telemóvelDataGridViewTextBoxColumn";
            this.telemóvelDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDeSangueDataGridViewTextBoxColumn
            // 
            this.tipoDeSangueDataGridViewTextBoxColumn.DataPropertyName = "Tipo de Sangue";
            this.tipoDeSangueDataGridViewTextBoxColumn.HeaderText = "Tipo de Sangue";
            this.tipoDeSangueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDeSangueDataGridViewTextBoxColumn.Name = "tipoDeSangueDataGridViewTextBoxColumn";
            this.tipoDeSangueDataGridViewTextBoxColumn.Width = 125;
            // 
            // fatorRHDataGridViewTextBoxColumn
            // 
            this.fatorRHDataGridViewTextBoxColumn.DataPropertyName = "Fator RH";
            this.fatorRHDataGridViewTextBoxColumn.HeaderText = "Fator RH";
            this.fatorRHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatorRHDataGridViewTextBoxColumn.Name = "fatorRHDataGridViewTextBoxColumn";
            this.fatorRHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableDadosBindingSource
            // 
            this.tableDadosBindingSource.DataMember = "Table_Dados";
            this.tableDadosBindingSource.DataSource = this.bD_ManagementDataSet;
            // 
            // bD_ManagementDataSet
            // 
            this.bD_ManagementDataSet.DataSetName = "BD_ManagementDataSet";
            this.bD_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_DadosTableAdapter
            // 
            this.table_DadosTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tsmi_ConsultarColheitas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloquearToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.menuToolStripMenuItem.Text = "Fechar";
            // 
            // bloquearToolStripMenuItem
            // 
            this.bloquearToolStripMenuItem.Name = "bloquearToolStripMenuItem";
            this.bloquearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.bloquearToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.bloquearToolStripMenuItem.Text = "Bloquear";
            this.bloquearToolStripMenuItem.Click += new System.EventHandler(this.bloquearToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tsmi_ConsultarColheitas
            // 
            this.tsmi_ConsultarColheitas.Name = "tsmi_ConsultarColheitas";
            this.tsmi_ConsultarColheitas.Size = new System.Drawing.Size(192, 24);
            this.tsmi_ConsultarColheitas.Text = "Consultar Nº de Colheitas";
            this.tsmi_ConsultarColheitas.Click += new System.EventHandler(this.tsmi_ConsultarColheitas_Click);
            // 
            // insertData
            // 
            this.insertData.BackColor = System.Drawing.Color.SeaShell;
            this.insertData.Controls.Add(this.txtInsertName);
            this.insertData.Controls.Add(this.txtInsertCC);
            this.insertData.Controls.Add(this.txtInsertRH);
            this.insertData.Controls.Add(this.txtInsertBlood);
            this.insertData.Controls.Add(this.txtInsertTlm);
            this.insertData.Controls.Add(this.txtInsertAddress);
            this.insertData.Controls.Add(this.textBox8);
            this.insertData.Controls.Add(this.textBox9);
            this.insertData.Controls.Add(this.label11);
            this.insertData.Controls.Add(this.label10);
            this.insertData.Controls.Add(this.btnInsert);
            this.insertData.Controls.Add(this.label4);
            this.insertData.Controls.Add(this.label5);
            this.insertData.Controls.Add(this.label6);
            this.insertData.Controls.Add(this.label7);
            this.insertData.Controls.Add(this.label8);
            this.insertData.Controls.Add(this.label9);
            this.insertData.Location = new System.Drawing.Point(4, 34);
            this.insertData.Name = "insertData";
            this.insertData.Padding = new System.Windows.Forms.Padding(3);
            this.insertData.Size = new System.Drawing.Size(991, 292);
            this.insertData.TabIndex = 0;
            this.insertData.Text = "Introduzir Dados";
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(178, 31);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(471, 30);
            this.txtInsertName.TabIndex = 5;
            this.txtInsertName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertCC
            // 
            this.txtInsertCC.Location = new System.Drawing.Point(178, 68);
            this.txtInsertCC.Name = "txtInsertCC";
            this.txtInsertCC.Size = new System.Drawing.Size(471, 30);
            this.txtInsertCC.TabIndex = 6;
            this.txtInsertCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertRH
            // 
            this.txtInsertRH.Location = new System.Drawing.Point(178, 240);
            this.txtInsertRH.Name = "txtInsertRH";
            this.txtInsertRH.Size = new System.Drawing.Size(471, 30);
            this.txtInsertRH.TabIndex = 10;
            this.txtInsertRH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertBlood
            // 
            this.txtInsertBlood.Location = new System.Drawing.Point(178, 201);
            this.txtInsertBlood.Name = "txtInsertBlood";
            this.txtInsertBlood.Size = new System.Drawing.Size(471, 30);
            this.txtInsertBlood.TabIndex = 9;
            this.txtInsertBlood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertTlm
            // 
            this.txtInsertTlm.Location = new System.Drawing.Point(178, 154);
            this.txtInsertTlm.Name = "txtInsertTlm";
            this.txtInsertTlm.Size = new System.Drawing.Size(471, 30);
            this.txtInsertTlm.TabIndex = 8;
            this.txtInsertTlm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertAddress
            // 
            this.txtInsertAddress.Location = new System.Drawing.Point(178, 113);
            this.txtInsertAddress.Name = "txtInsertAddress";
            this.txtInsertAddress.Size = new System.Drawing.Size(471, 30);
            this.txtInsertAddress.TabIndex = 7;
            this.txtInsertAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(114, -35);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(219, 30);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(114, -72);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(219, 30);
            this.textBox9.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "CC:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.MintCream;
            this.btnInsert.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.Location = new System.Drawing.Point(736, 102);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(249, 88);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Introduzir";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fator RH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Sangue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telemóvel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Morada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-50, -35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "CC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-50, -75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome:";
            // 
            // searchData
            // 
            this.searchData.BackColor = System.Drawing.Color.SeaShell;
            this.searchData.Controls.Add(this.label1);
            this.searchData.Controls.Add(this.label2);
            this.searchData.Controls.Add(this.txtSearchRH);
            this.searchData.Controls.Add(this.txtSearchBlood);
            this.searchData.Controls.Add(this.txtSearchName);
            this.searchData.Controls.Add(this.label3);
            this.searchData.Location = new System.Drawing.Point(4, 34);
            this.searchData.Name = "searchData";
            this.searchData.Padding = new System.Windows.Forms.Padding(3);
            this.searchData.Size = new System.Drawing.Size(991, 292);
            this.searchData.TabIndex = 1;
            this.searchData.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fator RH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de Sangue:";
            // 
            // txtSearchRH
            // 
            this.txtSearchRH.BackColor = System.Drawing.Color.White;
            this.txtSearchRH.ForeColor = System.Drawing.Color.Black;
            this.txtSearchRH.Location = new System.Drawing.Point(9, 241);
            this.txtSearchRH.Name = "txtSearchRH";
            this.txtSearchRH.Size = new System.Drawing.Size(979, 30);
            this.txtSearchRH.TabIndex = 2;
            this.txtSearchRH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchRH.TextChanged += new System.EventHandler(this.txtSearchRH_TextChanged);
            // 
            // txtSearchBlood
            // 
            this.txtSearchBlood.BackColor = System.Drawing.Color.White;
            this.txtSearchBlood.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBlood.Location = new System.Drawing.Point(9, 148);
            this.txtSearchBlood.Name = "txtSearchBlood";
            this.txtSearchBlood.Size = new System.Drawing.Size(979, 30);
            this.txtSearchBlood.TabIndex = 1;
            this.txtSearchBlood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBlood.TextChanged += new System.EventHandler(this.txtSearchBlood_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.White;
            this.txtSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchName.Location = new System.Drawing.Point(9, 49);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(979, 30);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchData);
            this.tabControl1.Controls.Add(this.insertData);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 330);
            this.tabControl1.TabIndex = 4;
            // 
            // Consultar_Dadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgv_Dadores);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Consultar_Dadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Dadores";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ManagementDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.insertData.ResumeLayout(false);
            this.insertData.PerformLayout();
            this.searchData.ResumeLayout(false);
            this.searchData.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Dadores;
        private BD_ManagementDataSet bD_ManagementDataSet;
        private System.Windows.Forms.BindingSource tableDadosBindingSource;
        private BD_ManagementDataSetTableAdapters.Table_DadosTableAdapter table_DadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemóvelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeSangueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatorRHDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ConsultarColheitas;
        private System.Windows.Forms.TabPage insertData;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.TextBox txtInsertCC;
        private System.Windows.Forms.TextBox txtInsertRH;
        private System.Windows.Forms.TextBox txtInsertBlood;
        private System.Windows.Forms.TextBox txtInsertTlm;
        private System.Windows.Forms.TextBox txtInsertAddress;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage searchData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchRH;
        private System.Windows.Forms.TextBox txtSearchBlood;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}