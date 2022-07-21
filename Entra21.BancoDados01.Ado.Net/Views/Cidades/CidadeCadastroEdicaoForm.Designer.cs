namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeCadastroEdicaoForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeHabitantes = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPib = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.labelDataFundacao = new System.Windows.Forms.Label();
            this.labelPib = new System.Windows.Forms.Label();
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 34);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(465, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxQuantidadeHabitantes
            // 
            this.textBoxQuantidadeHabitantes.Location = new System.Drawing.Point(12, 255);
            this.textBoxQuantidadeHabitantes.Name = "textBoxQuantidadeHabitantes";
            this.textBoxQuantidadeHabitantes.Size = new System.Drawing.Size(465, 27);
            this.textBoxQuantidadeHabitantes.TabIndex = 1;
            // 
            // maskedTextBoxPib
            // 
            this.maskedTextBoxPib.Location = new System.Drawing.Point(12, 197);
            this.maskedTextBoxPib.Mask = "R$ 000.000.000.000,00";
            this.maskedTextBoxPib.Name = "maskedTextBoxPib";
            this.maskedTextBoxPib.Size = new System.Drawing.Size(465, 27);
            this.maskedTextBoxPib.TabIndex = 3;
            // 
            // comboBoxUnidadeFederativa
            // 
            this.comboBoxUnidadeFederativa.DisplayMember = "Nome";
            this.comboBoxUnidadeFederativa.FormatString = "g";
            this.comboBoxUnidadeFederativa.FormattingEnabled = true;
            this.comboBoxUnidadeFederativa.Location = new System.Drawing.Point(12, 142);
            this.comboBoxUnidadeFederativa.Name = "comboBoxUnidadeFederativa";
            this.comboBoxUnidadeFederativa.Size = new System.Drawing.Size(465, 28);
            this.comboBoxUnidadeFederativa.TabIndex = 4;
            // 
            // dateTimePickerDataHoraFundacao
            // 
            this.dateTimePickerDataHoraFundacao.Location = new System.Drawing.Point(12, 87);
            this.dateTimePickerDataHoraFundacao.Name = "dateTimePickerDataHoraFundacao";
            this.dateTimePickerDataHoraFundacao.Size = new System.Drawing.Size(465, 27);
            this.dateTimePickerDataHoraFundacao.TabIndex = 5;
            // 
            // labelDataFundacao
            // 
            this.labelDataFundacao.AutoSize = true;
            this.labelDataFundacao.Location = new System.Drawing.Point(12, 64);
            this.labelDataFundacao.Name = "labelDataFundacao";
            this.labelDataFundacao.Size = new System.Drawing.Size(174, 20);
            this.labelDataFundacao.TabIndex = 6;
            this.labelDataFundacao.Text = "Data e hora de fundação";
            // 
            // labelPib
            // 
            this.labelPib.AutoSize = true;
            this.labelPib.Location = new System.Drawing.Point(12, 174);
            this.labelPib.Name = "labelPib";
            this.labelPib.Size = new System.Drawing.Size(30, 20);
            this.labelPib.TabIndex = 7;
            this.labelPib.Text = "PIB";
            // 
            // labelQuantidadeHabitantes
            // 
            this.labelQuantidadeHabitantes.AutoSize = true;
            this.labelQuantidadeHabitantes.Location = new System.Drawing.Point(12, 232);
            this.labelQuantidadeHabitantes.Name = "labelQuantidadeHabitantes";
            this.labelQuantidadeHabitantes.Size = new System.Drawing.Size(181, 20);
            this.labelQuantidadeHabitantes.TabIndex = 8;
            this.labelQuantidadeHabitantes.Text = "Quantidade de habitantes";
            // 
            // labelUnidadeFederativa
            // 
            this.labelUnidadeFederativa.AutoSize = true;
            this.labelUnidadeFederativa.Location = new System.Drawing.Point(12, 119);
            this.labelUnidadeFederativa.Name = "labelUnidadeFederativa";
            this.labelUnidadeFederativa.Size = new System.Drawing.Size(138, 20);
            this.labelUnidadeFederativa.TabIndex = 10;
            this.labelUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 11);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 11;
            this.labelNome.Text = "Nome";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(383, 304);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 304);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 342);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.labelDataFundacao);
            this.Controls.Add(this.dateTimePickerDataHoraFundacao);
            this.Controls.Add(this.comboBoxUnidadeFederativa);
            this.Controls.Add(this.maskedTextBoxPib);
            this.Controls.Add(this.textBoxQuantidadeHabitantes);
            this.Controls.Add(this.textBoxNome);
            this.Name = "CidadeCadastroEdicaoForm";
            this.Text = "Cidade Cadastro/Edição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxQuantidadeHabitantes;
        private MaskedTextBox maskedTextBoxPib;
        private ComboBox comboBoxUnidadeFederativa;
        private DateTimePicker dateTimePickerDataHoraFundacao;
        private Label labelDataFundacao;
        private Label labelPib;
        private Label labelQuantidadeHabitantes;
        private Label labelUnidadeFederativa;
        private Label labelNome;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}