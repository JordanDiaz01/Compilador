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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeSimbolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFuente = new System.Windows.Forms.RichTextBox();
            this.grpPFuente = new System.Windows.Forms.GroupBox();
            this.txtNumLineaFuente = new System.Windows.Forms.RichTextBox();
            this.grpTokens = new System.Windows.Forms.GroupBox();
            this.txtLineaTokens = new System.Windows.Forms.RichTextBox();
            this.txtTokens = new System.Windows.Forms.RichTextBox();
            this.btnAnalisisLexico = new System.Windows.Forms.Button();
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
            this.grpVariables = new System.Windows.Forms.GroupBox();
            this.dtgVariables = new System.Windows.Forms.DataGridView();
            this.idvar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpPFuente.SuspendLayout();
            this.grpTokens.SuspendLayout();
            this.grpSimbolos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSimbolos)).BeginInit();
            this.grpErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrores)).BeginInit();
            this.grpVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1815, 28);
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
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abriToolStripMenuItem
            // 
            this.abriToolStripMenuItem.Name = "abriToolStripMenuItem";
            this.abriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abriToolStripMenuItem.Text = "Abrir";
            this.abriToolStripMenuItem.Click += new System.EventHandler(this.abriToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaFuenteToolStripMenuItem,
            this.tokensToolStripMenuItem,
            this.tablaDeSimbolosToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // programaFuenteToolStripMenuItem
            // 
            this.programaFuenteToolStripMenuItem.Name = "programaFuenteToolStripMenuItem";
            this.programaFuenteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.programaFuenteToolStripMenuItem.Text = "Programa fuente";
            this.programaFuenteToolStripMenuItem.Click += new System.EventHandler(this.programaFuenteToolStripMenuItem_Click);
            // 
            // tokensToolStripMenuItem
            // 
            this.tokensToolStripMenuItem.Name = "tokensToolStripMenuItem";
            this.tokensToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tokensToolStripMenuItem.Text = "Tokens";
            this.tokensToolStripMenuItem.Click += new System.EventHandler(this.tokensToolStripMenuItem_Click);
            // 
            // tablaDeSimbolosToolStripMenuItem
            // 
            this.tablaDeSimbolosToolStripMenuItem.Name = "tablaDeSimbolosToolStripMenuItem";
            this.tablaDeSimbolosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tablaDeSimbolosToolStripMenuItem.Text = "Tabla de símbolos ";
            this.tablaDeSimbolosToolStripMenuItem.Click += new System.EventHandler(this.tablaDeSimbolosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarTodoToolStripMenuItem,
            this.temaToolStripMenuItem,
            this.documentacionToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.verToolStripMenuItem.Text = "Herramientas";
            // 
            // limpiarTodoToolStripMenuItem
            // 
            this.limpiarTodoToolStripMenuItem.Name = "limpiarTodoToolStripMenuItem";
            this.limpiarTodoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.limpiarTodoToolStripMenuItem.Text = "Limpiar todo";
            this.limpiarTodoToolStripMenuItem.Click += new System.EventHandler(this.limpiarTodoToolStripMenuItem_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oscuroToolStripMenuItem,
            this.claroToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // oscuroToolStripMenuItem
            // 
            this.oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            this.oscuroToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.oscuroToolStripMenuItem.Text = "Oscuro";
            this.oscuroToolStripMenuItem.Click += new System.EventHandler(this.oscuroToolStripMenuItem_Click);
            // 
            // claroToolStripMenuItem
            // 
            this.claroToolStripMenuItem.Name = "claroToolStripMenuItem";
            this.claroToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.claroToolStripMenuItem.Text = "Claro";
            this.claroToolStripMenuItem.Click += new System.EventHandler(this.claroToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtFuente
            // 
            this.txtFuente.BackColor = System.Drawing.Color.Black;
            this.txtFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuente.ForeColor = System.Drawing.Color.Lime;
            this.txtFuente.Location = new System.Drawing.Point(112, 23);
            this.txtFuente.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(689, 544);
            this.txtFuente.TabIndex = 1;
            this.txtFuente.Text = "";
            this.txtFuente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFuente_KeyDown);
            this.txtFuente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuente_KeyPress);
            // 
            // grpPFuente
            // 
            this.grpPFuente.Controls.Add(this.txtNumLineaFuente);
            this.grpPFuente.Controls.Add(this.txtFuente);
            this.grpPFuente.Location = new System.Drawing.Point(44, 48);
            this.grpPFuente.Margin = new System.Windows.Forms.Padding(4);
            this.grpPFuente.Name = "grpPFuente";
            this.grpPFuente.Padding = new System.Windows.Forms.Padding(4);
            this.grpPFuente.Size = new System.Drawing.Size(832, 596);
            this.grpPFuente.TabIndex = 2;
            this.grpPFuente.TabStop = false;
            this.grpPFuente.Text = "Programa fuente";
            // 
            // txtNumLineaFuente
            // 
            this.txtNumLineaFuente.BackColor = System.Drawing.Color.Black;
            this.txtNumLineaFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLineaFuente.ForeColor = System.Drawing.Color.Lime;
            this.txtNumLineaFuente.Location = new System.Drawing.Point(27, 25);
            this.txtNumLineaFuente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumLineaFuente.Name = "txtNumLineaFuente";
            this.txtNumLineaFuente.ReadOnly = true;
            this.txtNumLineaFuente.Size = new System.Drawing.Size(76, 543);
            this.txtNumLineaFuente.TabIndex = 2;
            this.txtNumLineaFuente.Text = "";
            // 
            // grpTokens
            // 
            this.grpTokens.Controls.Add(this.txtLineaTokens);
            this.grpTokens.Controls.Add(this.txtTokens);
            this.grpTokens.Location = new System.Drawing.Point(944, 48);
            this.grpTokens.Margin = new System.Windows.Forms.Padding(4);
            this.grpTokens.Name = "grpTokens";
            this.grpTokens.Padding = new System.Windows.Forms.Padding(4);
            this.grpTokens.Size = new System.Drawing.Size(839, 596);
            this.grpTokens.TabIndex = 3;
            this.grpTokens.TabStop = false;
            this.grpTokens.Text = "Tokens";
            // 
            // txtLineaTokens
            // 
            this.txtLineaTokens.BackColor = System.Drawing.Color.Black;
            this.txtLineaTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineaTokens.ForeColor = System.Drawing.Color.Lime;
            this.txtLineaTokens.Location = new System.Drawing.Point(24, 25);
            this.txtLineaTokens.Margin = new System.Windows.Forms.Padding(4);
            this.txtLineaTokens.Name = "txtLineaTokens";
            this.txtLineaTokens.ReadOnly = true;
            this.txtLineaTokens.Size = new System.Drawing.Size(76, 543);
            this.txtLineaTokens.TabIndex = 2;
            this.txtLineaTokens.Text = "";
            // 
            // txtTokens
            // 
            this.txtTokens.BackColor = System.Drawing.Color.Black;
            this.txtTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTokens.ForeColor = System.Drawing.Color.Lime;
            this.txtTokens.Location = new System.Drawing.Point(109, 25);
            this.txtTokens.Margin = new System.Windows.Forms.Padding(4);
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.ReadOnly = true;
            this.txtTokens.Size = new System.Drawing.Size(689, 544);
            this.txtTokens.TabIndex = 1;
            this.txtTokens.Text = "";
            // 
            // btnAnalisisLexico
            // 
            this.btnAnalisisLexico.BackColor = System.Drawing.Color.Black;
            this.btnAnalisisLexico.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnAnalisisLexico.Location = new System.Drawing.Point(815, 0);
            this.btnAnalisisLexico.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalisisLexico.Name = "btnAnalisisLexico";
            this.btnAnalisisLexico.Size = new System.Drawing.Size(169, 28);
            this.btnAnalisisLexico.TabIndex = 4;
            this.btnAnalisisLexico.Text = "Iniciar análisis léxico";
            this.btnAnalisisLexico.UseVisualStyleBackColor = false;
            this.btnAnalisisLexico.Click += new System.EventHandler(this.btnAnalisisLexico_Click);
            // 
            // grpSimbolos
            // 
            this.grpSimbolos.Controls.Add(this.dtgSimbolos);
            this.grpSimbolos.Location = new System.Drawing.Point(1188, 679);
            this.grpSimbolos.Margin = new System.Windows.Forms.Padding(4);
            this.grpSimbolos.Name = "grpSimbolos";
            this.grpSimbolos.Padding = new System.Windows.Forms.Padding(4);
            this.grpSimbolos.Size = new System.Drawing.Size(595, 331);
            this.grpSimbolos.TabIndex = 5;
            this.grpSimbolos.TabStop = false;
            this.grpSimbolos.Text = "Tabla de símbolos";
            // 
            // dtgSimbolos
            // 
            this.dtgSimbolos.AllowUserToAddRows = false;
            this.dtgSimbolos.AllowUserToDeleteRows = false;
            this.dtgSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSimbolos.BackgroundColor = System.Drawing.Color.Black;
            this.dtgSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombreid,
            this.token});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSimbolos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSimbolos.GridColor = System.Drawing.Color.White;
            this.dtgSimbolos.Location = new System.Drawing.Point(8, 16);
            this.dtgSimbolos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSimbolos.Name = "dtgSimbolos";
            this.dtgSimbolos.ReadOnly = true;
            this.dtgSimbolos.RowHeadersWidth = 51;
            this.dtgSimbolos.Size = new System.Drawing.Size(571, 300);
            this.dtgSimbolos.TabIndex = 3;
            this.dtgSimbolos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgSimbolos_RowsAdded);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nombreid
            // 
            this.nombreid.HeaderText = "Nombre";
            this.nombreid.MinimumWidth = 6;
            this.nombreid.Name = "nombreid";
            this.nombreid.ReadOnly = true;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.MinimumWidth = 6;
            this.token.Name = "token";
            this.token.ReadOnly = true;
            // 
            // grpErrores
            // 
            this.grpErrores.Controls.Add(this.dtgErrores);
            this.grpErrores.Location = new System.Drawing.Point(44, 679);
            this.grpErrores.Margin = new System.Windows.Forms.Padding(4);
            this.grpErrores.Name = "grpErrores";
            this.grpErrores.Padding = new System.Windows.Forms.Padding(4);
            this.grpErrores.Size = new System.Drawing.Size(615, 331);
            this.grpErrores.TabIndex = 6;
            this.grpErrores.TabStop = false;
            this.grpErrores.Text = "Tabla de errores";
            // 
            // dtgErrores
            // 
            this.dtgErrores.AllowUserToAddRows = false;
            this.dtgErrores.AllowUserToDeleteRows = false;
            this.dtgErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgErrores.BackgroundColor = System.Drawing.Color.Black;
            this.dtgErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linea,
            this.error,
            this.desc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgErrores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgErrores.GridColor = System.Drawing.Color.White;
            this.dtgErrores.Location = new System.Drawing.Point(28, 23);
            this.dtgErrores.Margin = new System.Windows.Forms.Padding(4);
            this.dtgErrores.Name = "dtgErrores";
            this.dtgErrores.ReadOnly = true;
            this.dtgErrores.RowHeadersWidth = 51;
            this.dtgErrores.Size = new System.Drawing.Size(572, 293);
            this.dtgErrores.TabIndex = 3;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.MinimumWidth = 6;
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.MinimumWidth = 6;
            this.error.Name = "error";
            this.error.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // grpVariables
            // 
            this.grpVariables.Controls.Add(this.dtgVariables);
            this.grpVariables.Location = new System.Drawing.Point(667, 679);
            this.grpVariables.Margin = new System.Windows.Forms.Padding(4);
            this.grpVariables.Name = "grpVariables";
            this.grpVariables.Padding = new System.Windows.Forms.Padding(4);
            this.grpVariables.Size = new System.Drawing.Size(513, 331);
            this.grpVariables.TabIndex = 7;
            this.grpVariables.TabStop = false;
            this.grpVariables.Text = "Tabla de variables";
            // 
            // dtgVariables
            // 
            this.dtgVariables.AllowUserToAddRows = false;
            this.dtgVariables.AllowUserToDeleteRows = false;
            this.dtgVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVariables.BackgroundColor = System.Drawing.Color.Black;
            this.dtgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvar,
            this.tipo,
            this.variables,
            this.valor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVariables.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVariables.GridColor = System.Drawing.Color.White;
            this.dtgVariables.Location = new System.Drawing.Point(8, 23);
            this.dtgVariables.Margin = new System.Windows.Forms.Padding(4);
            this.dtgVariables.Name = "dtgVariables";
            this.dtgVariables.ReadOnly = true;
            this.dtgVariables.RowHeadersWidth = 51;
            this.dtgVariables.Size = new System.Drawing.Size(497, 293);
            this.dtgVariables.TabIndex = 0;
            // 
            // idvar
            // 
            this.idvar.HeaderText = "Id";
            this.idvar.MinimumWidth = 6;
            this.idvar.Name = "idvar";
            this.idvar.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // variables
            // 
            this.variables.HeaderText = "Nombre";
            this.variables.MinimumWidth = 6;
            this.variables.Name = "variables";
            this.variables.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // documentacionToolStripMenuItem
            // 
            this.documentacionToolStripMenuItem.Name = "documentacionToolStripMenuItem";
            this.documentacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.documentacionToolStripMenuItem.Text = "Documentacion";
            this.documentacionToolStripMenuItem.Click += new System.EventHandler(this.documentacionToolStripMenuItem_Click);
            // 
            // FrmCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1815, 1025);
            this.Controls.Add(this.grpVariables);
            this.Controls.Add(this.grpErrores);
            this.Controls.Add(this.grpSimbolos);
            this.Controls.Add(this.btnAnalisisLexico);
            this.Controls.Add(this.grpTokens);
            this.Controls.Add(this.grpPFuente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.grpVariables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVariables)).EndInit();
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
        private System.Windows.Forms.RichTextBox txtNumLineaFuente;
        private System.Windows.Forms.GroupBox grpTokens;
        private System.Windows.Forms.RichTextBox txtLineaTokens;
        private System.Windows.Forms.RichTextBox txtTokens;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem limpiarTodoToolStripMenuItem;
        private System.Windows.Forms.Button btnAnalisisLexico;
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
        private System.Windows.Forms.GroupBox grpVariables;
        private System.Windows.Forms.DataGridView dtgVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn variables;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.ToolStripMenuItem documentacionToolStripMenuItem;
    }
}

