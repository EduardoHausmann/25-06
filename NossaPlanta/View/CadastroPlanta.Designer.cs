namespace View
{
    partial class CadastroPlanta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.mtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtbPeso = new System.Windows.Forms.MaskedTextBox();
            this.dgvPlantas = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAtualiza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(9, 69);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(46, 19);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // mtbAltura
            // 
            this.mtbAltura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbAltura.Location = new System.Drawing.Point(9, 98);
            this.mtbAltura.Mask = "9.99";
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.Size = new System.Drawing.Size(173, 26);
            this.mtbAltura.TabIndex = 2;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(9, 144);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 19);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(9, 207);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 29);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mtbPeso
            // 
            this.mtbPeso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPeso.Location = new System.Drawing.Point(9, 166);
            this.mtbPeso.Mask = "999.99";
            this.mtbPeso.Name = "mtbPeso";
            this.mtbPeso.Size = new System.Drawing.Size(173, 26);
            this.mtbPeso.TabIndex = 3;
            // 
            // dgvPlantas
            // 
            this.dgvPlantas.AllowUserToAddRows = false;
            this.dgvPlantas.AllowUserToDeleteRows = false;
            this.dgvPlantas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnAltura,
            this.ColumnPeso});
            this.dgvPlantas.Location = new System.Drawing.Point(202, 70);
            this.dgvPlantas.Name = "dgvPlantas";
            this.dgvPlantas.ReadOnly = true;
            this.dgvPlantas.RowHeadersVisible = false;
            this.dgvPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlantas.Size = new System.Drawing.Size(424, 166);
            this.dgvPlantas.TabIndex = 7;
            this.dgvPlantas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlantas_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 170;
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.Name = "ColumnAltura";
            this.ColumnAltura.ReadOnly = true;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "Peso";
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(198, 33);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(46, 19);
            this.lblBusca.TabIndex = 0;
            this.lblBusca.Text = "Busca";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(250, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(270, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(103, 207);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(88, 29);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(97, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 19);
            this.lblId.TabIndex = 10;
            this.lblId.Visible = false;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualiza.Location = new System.Drawing.Point(538, 27);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(88, 29);
            this.btnAtualiza.TabIndex = 11;
            this.btnAtualiza.Text = "Refresh";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // CadastroPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 244);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.mtbPeso);
            this.Controls.Add(this.mtbAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvPlantas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPlanta";
            this.Text = "Cadstro Plantas";
            this.Load += new System.EventHandler(this.CadastroPlanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.MaskedTextBox mtbAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mtbPeso;
        private System.Windows.Forms.DataGridView dgvPlantas;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeso;
        private System.Windows.Forms.Button btnAtualiza;
    }
}

