namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeListagemForm
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeHabitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataDeFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiglaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(1385, 8);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(1285, 8);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(1185, 8);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 7;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnQuantidadeHabitantes,
            this.ColumnDataDeFundacao,
            this.ColumnPib,
            this.ColumnEstado,
            this.ColumnSiglaEstado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1467, 413);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 51;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 79;
            // 
            // ColumnQuantidadeHabitantes
            // 
            this.ColumnQuantidadeHabitantes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnQuantidadeHabitantes.HeaderText = "Habitantes";
            this.ColumnQuantidadeHabitantes.MinimumWidth = 6;
            this.ColumnQuantidadeHabitantes.Name = "ColumnQuantidadeHabitantes";
            this.ColumnQuantidadeHabitantes.ReadOnly = true;
            this.ColumnQuantidadeHabitantes.Width = 110;
            // 
            // ColumnDataDeFundacao
            // 
            this.ColumnDataDeFundacao.HeaderText = "Data de fundação";
            this.ColumnDataDeFundacao.MinimumWidth = 200;
            this.ColumnDataDeFundacao.Name = "ColumnDataDeFundacao";
            this.ColumnDataDeFundacao.ReadOnly = true;
            this.ColumnDataDeFundacao.Width = 500;
            // 
            // ColumnPib
            // 
            this.ColumnPib.HeaderText = "PIB";
            this.ColumnPib.MinimumWidth = 6;
            this.ColumnPib.Name = "ColumnPib";
            this.ColumnPib.ReadOnly = true;
            this.ColumnPib.Width = 300;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.MinimumWidth = 6;
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            this.ColumnEstado.Width = 200;
            // 
            // ColumnSiglaEstado
            // 
            this.ColumnSiglaEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSiglaEstado.HeaderText = "Sigla do Estado";
            this.ColumnSiglaEstado.MinimumWidth = 6;
            this.ColumnSiglaEstado.Name = "ColumnSiglaEstado";
            this.ColumnSiglaEstado.ReadOnly = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(12, 8);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(306, 29);
            this.buttonMenu.TabIndex = 10;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // CidadeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 469);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CidadeListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem cidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CidadeListagemForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidadeHabitantes;
        private DataGridViewTextBoxColumn ColumnDataDeFundacao;
        private DataGridViewTextBoxColumn ColumnPib;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn ColumnSiglaEstado;
        private Button buttonMenu;
    }
}