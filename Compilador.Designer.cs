namespace Compilador
{
    partial class FrmCompilador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFuente = new System.Windows.Forms.RichTextBox();
            this.grpPFuente = new System.Windows.Forms.GroupBox();
            this.txNumLineaFuente = new System.Windows.Forms.RichTextBox();
            this.grpTokens = new System.Windows.Forms.GroupBox();
            this.txtLineaTokens = new System.Windows.Forms.RichTextBox();
            this.txtTokens = new System.Windows.Forms.RichTextBox();
            this.limpiarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeSimbolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSimbolos = new System.Windows.Forms.GroupBox();
            this.dtgSimbolos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpErrores = new System.Windows.Forms.GroupBox();
            this.dtgErrores = new System.Windows.Forms.DataGridView();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpPFuente.SuspendLayout();
            this.grpTokens.SuspendLayout();
            this.grpSimbolos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSimbolos)).BeginInit();
            this.grpErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1361, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abriToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abriToolStripMenuItem
            // 
            this.abriToolStripMenuItem.Name = "abriToolStripMenuItem";
            this.abriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abriToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaFuenteToolStripMenuItem,
            this.tokensToolStripMenuItem,
            this.tablaDeSimbolosToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarTodoToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.verToolStripMenuItem.Text = "Herramientas";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // txtFuente
            // 
            this.txtFuente.Location = new System.Drawing.Point(84, 19);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(518, 443);
            this.txtFuente.TabIndex = 1;
            this.txtFuente.Text = "";
            // 
            // grpPFuente
            // 
            this.grpPFuente.Controls.Add(this.txNumLineaFuente);
            this.grpPFuente.Controls.Add(this.txtFuente);
            this.grpPFuente.Location = new System.Drawing.Point(33, 39);
            this.grpPFuente.Name = "grpPFuente";
            this.grpPFuente.Size = new System.Drawing.Size(624, 484);
            this.grpPFuente.TabIndex = 2;
            this.grpPFuente.TabStop = false;
            this.grpPFuente.Text = "Programa fuente";
            // 
            // txNumLineaFuente
            // 
            this.txNumLineaFuente.Location = new System.Drawing.Point(20, 20);
            this.txNumLineaFuente.Name = "txNumLineaFuente";
            this.txNumLineaFuente.Size = new System.Drawing.Size(58, 442);
            this.txNumLineaFuente.TabIndex = 2;
            this.txNumLineaFuente.Text = "";
            // 
            // grpTokens
            // 
            this.grpTokens.Controls.Add(this.txtLineaTokens);
            this.grpTokens.Controls.Add(this.txtTokens);
            this.grpTokens.Location = new System.Drawing.Point(708, 39);
            this.grpTokens.Name = "grpTokens";
            this.grpTokens.Size = new System.Drawing.Size(629, 484);
            this.grpTokens.TabIndex = 3;
            this.grpTokens.TabStop = false;
            this.grpTokens.Text = "Tokens";
            // 
            // txtLineaTokens
            // 
            this.txtLineaTokens.Location = new System.Drawing.Point(18, 20);
            this.txtLineaTokens.Name = "txtLineaTokens";
            this.txtLineaTokens.Size = new System.Drawing.Size(58, 442);
            this.txtLineaTokens.TabIndex = 2;
            this.txtLineaTokens.Text = "";
            // 
            // txtTokens
            // 
            this.txtTokens.Location = new System.Drawing.Point(82, 20);
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.Size = new System.Drawing.Size(518, 443);
            this.txtTokens.TabIndex = 1;
            this.txtTokens.Text = "";
            // 
            // limpiarTodoToolStripMenuItem
            // 
            this.limpiarTodoToolStripMenuItem.Name = "limpiarTodoToolStripMenuItem";
            this.limpiarTodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limpiarTodoToolStripMenuItem.Text = "Limpiar todo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar análisis léxico";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oscuroToolStripMenuItem,
            this.claroToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // oscuroToolStripMenuItem
            // 
            this.oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            this.oscuroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oscuroToolStripMenuItem.Text = "Oscuro";
            // 
            // claroToolStripMenuItem
            // 
            this.claroToolStripMenuItem.Name = "claroToolStripMenuItem";
            this.claroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.claroToolStripMenuItem.Text = "Claro";
            // 
            // programaFuenteToolStripMenuItem
            // 
            this.programaFuenteToolStripMenuItem.Name = "programaFuenteToolStripMenuItem";
            this.programaFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programaFuenteToolStripMenuItem.Text = "Programa fuente";
            // 
            // tokensToolStripMenuItem
            // 
            this.tokensToolStripMenuItem.Name = "tokensToolStripMenuItem";
            this.tokensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tokensToolStripMenuItem.Text = "Tokens";
            // 
            // tablaDeSimbolosToolStripMenuItem
            // 
            this.tablaDeSimbolosToolStripMenuItem.Name = "tablaDeSimbolosToolStripMenuItem";
            this.tablaDeSimbolosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablaDeSimbolosToolStripMenuItem.Text = "Tabla de símbolos ";
            // 
            // grpSimbolos
            // 
            this.grpSimbolos.Controls.Add(this.dtgSimbolos);
            this.grpSimbolos.Location = new System.Drawing.Point(773, 552);
            this.grpSimbolos.Name = "grpSimbolos";
            this.grpSimbolos.Size = new System.Drawing.Size(564, 269);
            this.grpSimbolos.TabIndex = 5;
            this.grpSimbolos.TabStop = false;
            this.grpSimbolos.Text = "Tabla de símbolos";
            // 
            // dtgSimbolos
            // 
            this.dtgSimbolos.AllowUserToAddRows = false;
            this.dtgSimbolos.AllowUserToDeleteRows = false;
            this.dtgSimbolos.BackgroundColor = System.Drawing.Color.White;
            this.dtgSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombreid,
            this.token});
            this.dtgSimbolos.Location = new System.Drawing.Point(21, 19);
            this.dtgSimbolos.Name = "dtgSimbolos";
            this.dtgSimbolos.ReadOnly = true;
            this.dtgSimbolos.RowHeadersWidth = 51;
            this.dtgSimbolos.Size = new System.Drawing.Size(525, 244);
            this.dtgSimbolos.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // nombreid
            // 
            this.nombreid.HeaderText = "Nombre";
            this.nombreid.MinimumWidth = 6;
            this.nombreid.Name = "nombreid";
            this.nombreid.ReadOnly = true;
            this.nombreid.Width = 125;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.MinimumWidth = 6;
            this.token.Name = "token";
            this.token.ReadOnly = true;
            this.token.Width = 125;
            // 
            // grpErrores
            // 
            this.grpErrores.Controls.Add(this.dtgErrores);
            this.grpErrores.Location = new System.Drawing.Point(33, 552);
            this.grpErrores.Name = "grpErrores";
            this.grpErrores.Size = new System.Drawing.Size(564, 269);
            this.grpErrores.TabIndex = 6;
            this.grpErrores.TabStop = false;
            this.grpErrores.Text = "Tabla de errores";
            // 
            // dtgErrores
            // 
            this.dtgErrores.AllowUserToAddRows = false;
            this.dtgErrores.AllowUserToDeleteRows = false;
            this.dtgErrores.BackgroundColor = System.Drawing.Color.White;
            this.dtgErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linea,
            this.error,
            this.desc});
            this.dtgErrores.Location = new System.Drawing.Point(21, 19);
            this.dtgErrores.Name = "dtgErrores";
            this.dtgErrores.ReadOnly = true;
            this.dtgErrores.RowHeadersWidth = 51;
            this.dtgErrores.Size = new System.Drawing.Size(525, 244);
            this.dtgErrores.TabIndex = 3;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.MinimumWidth = 6;
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            this.linea.Width = 125;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.MinimumWidth = 6;
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Width = 125;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 125;
            // 
            // FrmCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 833);
            this.Controls.Add(this.grpErrores);
            this.Controls.Add(this.grpSimbolos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpTokens);
            this.Controls.Add(this.grpPFuente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCompilador";
            this.Text = "Compilador XD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPFuente.ResumeLayout(false);
            this.grpTokens.ResumeLayout(false);
            this.grpSimbolos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSimbolos)).EndInit();
            this.grpErrores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtFuente;
        private System.Windows.Forms.GroupBox grpPFuente;
        private System.Windows.Forms.RichTextBox txNumLineaFuente;
        private System.Windows.Forms.GroupBox grpTokens;
        private System.Windows.Forms.RichTextBox txtLineaTokens;
        private System.Windows.Forms.RichTextBox txtTokens;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem limpiarTodoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem programaFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeSimbolosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claroToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSimbolos;
        private System.Windows.Forms.DataGridView dtgSimbolos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreid;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.GroupBox grpErrores;
        private System.Windows.Forms.DataGridView dtgErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}

