namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    partial class PacientesForm
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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.LabelNome = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelImc = new System.Windows.Forms.Label();
            this.dataGridViewInformacoes = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(357, 33);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(679, 223);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(99, 29);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(257, 33);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(457, 45);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(50, 20);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(457, 98);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(49, 20);
            this.labelAltura.TabIndex = 4;
            this.labelAltura.Text = "Altura";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(457, 151);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(39, 20);
            this.labelPeso.TabIndex = 5;
            this.labelPeso.Text = "Peso";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(457, 68);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(321, 27);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(457, 121);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(321, 27);
            this.textBoxAltura.TabIndex = 7;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(457, 174);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(321, 27);
            this.textBoxPeso.TabIndex = 8;
            // 
            // labelImc
            // 
            this.labelImc.AutoSize = true;
            this.labelImc.Location = new System.Drawing.Point(457, 204);
            this.labelImc.Name = "labelImc";
            this.labelImc.Size = new System.Drawing.Size(38, 20);
            this.labelImc.TabIndex = 9;
            this.labelImc.Text = "IMC:";
            // 
            // dataGridViewInformacoes
            // 
            this.dataGridViewInformacoes.AllowUserToAddRows = false;
            this.dataGridViewInformacoes.AllowUserToDeleteRows = false;
            this.dataGridViewInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnAltura,
            this.ColumnPeso,
            this.ColumnImc});
            this.dataGridViewInformacoes.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewInformacoes.Name = "dataGridViewInformacoes";
            this.dataGridViewInformacoes.ReadOnly = true;
            this.dataGridViewInformacoes.RowHeadersWidth = 51;
            this.dataGridViewInformacoes.RowTemplate.Height = 29;
            this.dataGridViewInformacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInformacoes.Size = new System.Drawing.Size(439, 339);
            this.dataGridViewInformacoes.TabIndex = 10;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.MinimumWidth = 6;
            this.ColumnAltura.Name = "ColumnAltura";
            this.ColumnAltura.ReadOnly = true;
            this.ColumnAltura.Width = 125;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "Peso";
            this.ColumnPeso.MinimumWidth = 6;
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            this.ColumnPeso.Width = 125;
            // 
            // ColumnImc
            // 
            this.ColumnImc.HeaderText = "IMC";
            this.ColumnImc.MinimumWidth = 6;
            this.ColumnImc.Name = "ColumnImc";
            this.ColumnImc.ReadOnly = true;
            this.ColumnImc.Width = 125;
            // 
            // PacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 419);
            this.Controls.Add(this.dataGridViewInformacoes);
            this.Controls.Add(this.labelImc);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "PacientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Label LabelNome;
        private Label labelAltura;
        private Label labelPeso;
        private TextBox textBoxNome;
        private TextBox textBoxAltura;
        private TextBox textBoxPeso;
        private Label labelImc;
        private DataGridView dataGridViewInformacoes;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnAltura;
        private DataGridViewTextBoxColumn ColumnPeso;
        private DataGridViewTextBoxColumn ColumnImc;
    }
}