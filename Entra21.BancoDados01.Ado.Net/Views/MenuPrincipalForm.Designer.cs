namespace Entra21.BancoDados01.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonEditoras = new System.Windows.Forms.Button();
            this.buttonPersonagens = new System.Windows.Forms.Button();
            this.buttonTiposPersonagem = new System.Windows.Forms.Button();
            this.buttonCidades = new System.Windows.Forms.Button();
            this.buttonUnidadesFederativas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.Location = new System.Drawing.Point(12, 12);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(305, 426);
            this.buttonEditoras.TabIndex = 0;
            this.buttonEditoras.Text = "Editoras";
            this.buttonEditoras.UseVisualStyleBackColor = true;
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.Location = new System.Drawing.Point(323, 12);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(305, 426);
            this.buttonPersonagens.TabIndex = 1;
            this.buttonPersonagens.Text = "Personagens";
            this.buttonPersonagens.UseVisualStyleBackColor = true;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTiposPersonagem
            // 
            this.buttonTiposPersonagem.Location = new System.Drawing.Point(634, 12);
            this.buttonTiposPersonagem.Name = "buttonTiposPersonagem";
            this.buttonTiposPersonagem.Size = new System.Drawing.Size(305, 426);
            this.buttonTiposPersonagem.TabIndex = 2;
            this.buttonTiposPersonagem.Text = "Tipos de personagens";
            this.buttonTiposPersonagem.UseVisualStyleBackColor = true;
            this.buttonTiposPersonagem.Click += new System.EventHandler(this.buttonTiposPersonagem_Click);
            // 
            // buttonCidades
            // 
            this.buttonCidades.Location = new System.Drawing.Point(480, 444);
            this.buttonCidades.Name = "buttonCidades";
            this.buttonCidades.Size = new System.Drawing.Size(305, 426);
            this.buttonCidades.TabIndex = 4;
            this.buttonCidades.Text = "Cidades";
            this.buttonCidades.UseVisualStyleBackColor = true;
            this.buttonCidades.Click += new System.EventHandler(this.buttonCidades_Click);
            // 
            // buttonUnidadesFederativas
            // 
            this.buttonUnidadesFederativas.Location = new System.Drawing.Point(169, 444);
            this.buttonUnidadesFederativas.Name = "buttonUnidadesFederativas";
            this.buttonUnidadesFederativas.Size = new System.Drawing.Size(305, 426);
            this.buttonUnidadesFederativas.TabIndex = 3;
            this.buttonUnidadesFederativas.Text = "Unidades Federativas";
            this.buttonUnidadesFederativas.UseVisualStyleBackColor = true;
            this.buttonUnidadesFederativas.Click += new System.EventHandler(this.buttonUnidadesFederativas_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 888);
            this.Controls.Add(this.buttonCidades);
            this.Controls.Add(this.buttonUnidadesFederativas);
            this.Controls.Add(this.buttonTiposPersonagem);
            this.Controls.Add(this.buttonPersonagens);
            this.Controls.Add(this.buttonEditoras);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditoras;
        private Button buttonPersonagens;
        private Button buttonTiposPersonagem;
        private Button buttonCidades;
        private Button buttonUnidadesFederativas;
    }
}