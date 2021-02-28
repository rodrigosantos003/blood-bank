namespace BancoSangue
{
    partial class N_Colheitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N_Colheitas));
            this.dgv_Colheitas = new System.Windows.Forms.DataGridView();
            this.bD_ManagementDataSet = new BancoSangue.BD_ManagementDataSet();
            this.tableDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_DadosTableAdapter = new BancoSangue.BD_ManagementDataSetTableAdapters.Table_DadosTableAdapter();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnTotal_A = new System.Windows.Forms.Button();
            this.btnTotal_B = new System.Windows.Forms.Button();
            this.btnTotal_AB = new System.Windows.Forms.Button();
            this.btnTotal_O = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Colheitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDadosBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Colheitas
            // 
            this.dgv_Colheitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Colheitas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Colheitas.Location = new System.Drawing.Point(0, 371);
            this.dgv_Colheitas.Name = "dgv_Colheitas";
            this.dgv_Colheitas.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Colheitas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Colheitas.RowTemplate.Height = 24;
            this.dgv_Colheitas.Size = new System.Drawing.Size(1006, 350);
            this.dgv_Colheitas.TabIndex = 0;
            // 
            // bD_ManagementDataSet
            // 
            this.bD_ManagementDataSet.DataSetName = "BD_ManagementDataSet";
            this.bD_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDadosBindingSource
            // 
            this.tableDadosBindingSource.DataMember = "Table_Dados";
            this.tableDadosBindingSource.DataSource = this.bD_ManagementDataSet;
            // 
            // table_DadosTableAdapter
            // 
            this.table_DadosTableAdapter.ClearBeforeFill = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(12, 53);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(150, 60);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "Total de Colheitas";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnTotal_A
            // 
            this.btnTotal_A.Location = new System.Drawing.Point(214, 53);
            this.btnTotal_A.Name = "btnTotal_A";
            this.btnTotal_A.Size = new System.Drawing.Size(150, 60);
            this.btnTotal_A.TabIndex = 12;
            this.btnTotal_A.Text = "Total Tipo A";
            this.btnTotal_A.UseVisualStyleBackColor = true;
            this.btnTotal_A.Click += new System.EventHandler(this.btnTotal_A_Click);
            // 
            // btnTotal_B
            // 
            this.btnTotal_B.Location = new System.Drawing.Point(418, 53);
            this.btnTotal_B.Name = "btnTotal_B";
            this.btnTotal_B.Size = new System.Drawing.Size(150, 60);
            this.btnTotal_B.TabIndex = 13;
            this.btnTotal_B.Text = "Total Tipo B";
            this.btnTotal_B.UseVisualStyleBackColor = true;
            this.btnTotal_B.Click += new System.EventHandler(this.btnTotal_B_Click);
            // 
            // btnTotal_AB
            // 
            this.btnTotal_AB.Location = new System.Drawing.Point(629, 53);
            this.btnTotal_AB.Name = "btnTotal_AB";
            this.btnTotal_AB.Size = new System.Drawing.Size(150, 60);
            this.btnTotal_AB.TabIndex = 14;
            this.btnTotal_AB.Text = "Total Tipo AB";
            this.btnTotal_AB.UseVisualStyleBackColor = true;
            this.btnTotal_AB.Click += new System.EventHandler(this.btnTotal_AB_Click);
            // 
            // btnTotal_O
            // 
            this.btnTotal_O.Location = new System.Drawing.Point(844, 53);
            this.btnTotal_O.Name = "btnTotal_O";
            this.btnTotal_O.Size = new System.Drawing.Size(150, 60);
            this.btnTotal_O.TabIndex = 15;
            this.btnTotal_O.Text = "Total Tipo O";
            this.btnTotal_O.UseVisualStyleBackColor = true;
            this.btnTotal_O.Click += new System.EventHandler(this.btnTotal_O_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 30);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem1,
            this.bloquearToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.voltarToolStripMenuItem.Text = "Fechar";
            // 
            // voltarToolStripMenuItem1
            // 
            this.voltarToolStripMenuItem1.Name = "voltarToolStripMenuItem1";
            this.voltarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.voltarToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.voltarToolStripMenuItem1.Text = "Voltar";
            this.voltarToolStripMenuItem1.Click += new System.EventHandler(this.voltarToolStripMenuItem1_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoSangue.Properties.Resources.blood;
            this.pictureBox1.Location = new System.Drawing.Point(413, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(360, 165);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(84, 32);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(568, 165);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(32, 32);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "0";
            // 
            // N_Colheitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTotal_O);
            this.Controls.Add(this.btnTotal_AB);
            this.Controls.Add(this.btnTotal_B);
            this.Controls.Add(this.btnTotal_A);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.dgv_Colheitas);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "N_Colheitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nº de Colheitas";
            this.Load += new System.EventHandler(this.N_Colheitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Colheitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDadosBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Colheitas;
        private BD_ManagementDataSet bD_ManagementDataSet;
        private System.Windows.Forms.BindingSource tableDadosBindingSource;
        private BD_ManagementDataSetTableAdapters.Table_DadosTableAdapter table_DadosTableAdapter;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnTotal_A;
        private System.Windows.Forms.Button btnTotal_B;
        private System.Windows.Forms.Button btnTotal_AB;
        private System.Windows.Forms.Button btnTotal_O;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
    }
}