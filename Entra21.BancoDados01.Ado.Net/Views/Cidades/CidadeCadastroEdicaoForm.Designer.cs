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
            this.comboBoxUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.labelDataFundacao = new System.Windows.Forms.Label();
            this.labelPib = new System.Windows.Forms.Label();
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.dateTimePickerHoraDeFundacao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            // dateTimePickerDataFundacao
            // 
            this.dateTimePickerDataFundacao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataFundacao.Location = new System.Drawing.Point(12, 87);
            this.dateTimePickerDataFundacao.MaxDate = DateTime.Today;
            this.dateTimePickerDataFundacao.Name = "dateTimePickerDataFundacao";
            this.dateTimePickerDataFundacao.Size = new System.Drawing.Size(227, 27);
            this.dateTimePickerDataFundacao.TabIndex = 5;
            this.dateTimePickerDataFundacao.Value = new System.DateTime(2022, 7, 21, 0, 0, 0, 0);
            // 
            // labelDataFundacao
            // 
            this.labelDataFundacao.AutoSize = true;
            this.labelDataFundacao.Location = new System.Drawing.Point(12, 64);
            this.labelDataFundacao.Name = "labelDataFundacao";
            this.labelDataFundacao.Size = new System.Drawing.Size(128, 20);
            this.labelDataFundacao.TabIndex = 6;
            this.labelDataFundacao.Text = "Data de fundação";
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
            // textBoxPib
            // 
            this.textBoxPib.Location = new System.Drawing.Point(12, 202);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(465, 27);
            this.textBoxPib.TabIndex = 14;
            // 
            // dateTimePickerHoraDeFundacao
            // 
            this.dateTimePickerHoraDeFundacao.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.dateTimePickerHoraDeFundacao.CustomFormat = "HH:mm:ss";
            this.dateTimePickerHoraDeFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraDeFundacao.Location = new System.Drawing.Point(245, 87);
            this.dateTimePickerHoraDeFundacao.Name = "dateTimePickerHoraDeFundacao";
            this.dateTimePickerHoraDeFundacao.ShowUpDown = true;
            this.dateTimePickerHoraDeFundacao.Size = new System.Drawing.Size(232, 27);
            this.dateTimePickerHoraDeFundacao.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hora de fundação";
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerHoraDeFundacao);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.labelDataFundacao);
            this.Controls.Add(this.dateTimePickerDataFundacao);
            this.Controls.Add(this.comboBoxUnidadeFederativa);
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
        private ComboBox comboBoxUnidadeFederativa;
        private DateTimePicker dateTimePickerDataFundacao;
        private Label labelDataFundacao;
        private Label labelPib;
        private Label labelQuantidadeHabitantes;
        private Label labelUnidadeFederativa;
        private Label labelNome;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxPib;
        private DateTimePicker dateTimePickerHoraDeFundacao;
        private Label label1;
    }
}