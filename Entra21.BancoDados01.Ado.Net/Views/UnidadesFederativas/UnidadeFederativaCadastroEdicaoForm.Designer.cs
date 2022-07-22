namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    partial class UnidadeFederativaCadastroEdicaoForm
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSigla = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.textBoxSigla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(227, 141);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 141);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 39);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(309, 27);
            this.textBoxNome.TabIndex = 6;
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(12, 85);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(42, 20);
            this.labelSigla.TabIndex = 8;
            this.labelSigla.Text = "Sigla";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(12, 11);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(50, 20);
            this.LabelNome.TabIndex = 9;
            this.LabelNome.Text = "Nome";
            // 
            // textBoxSigla
            // 
            this.textBoxSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSigla.Location = new System.Drawing.Point(12, 108);
            this.textBoxSigla.Name = "textBoxSigla";
            this.textBoxSigla.Size = new System.Drawing.Size(309, 27);
            this.textBoxSigla.TabIndex = 10;
            // 
            // UnidadeFederativaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 182);
            this.Controls.Add(this.textBoxSigla);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "UnidadeFederativaCadastroEdicaoForm";
            this.Text = "Cadastro/edicao UF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxNome;
        private Label labelSigla;
        private Label LabelNome;
        private TextBox textBoxSigla;
    }
}