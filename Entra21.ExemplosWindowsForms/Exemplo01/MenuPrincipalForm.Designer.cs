namespace Entra21.ExemplosWindowsForms.Exemplo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonEnderecos = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnderecos
            // 
            this.buttonEnderecos.BackColor = System.Drawing.Color.White;
            this.buttonEnderecos.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecos.Image")));
            this.buttonEnderecos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEnderecos.Location = new System.Drawing.Point(12, 12);
            this.buttonEnderecos.Name = "buttonEnderecos";
            this.buttonEnderecos.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEnderecos.Size = new System.Drawing.Size(228, 175);
            this.buttonEnderecos.TabIndex = 0;
            this.buttonEnderecos.Text = "Endereços";
            this.buttonEnderecos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnderecos.UseVisualStyleBackColor = false;
            this.buttonEnderecos.Click += new System.EventHandler(this.buttonEnderecos_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.BackColor = System.Drawing.Color.White;
            this.buttonPacientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonPacientes.Image")));
            this.buttonPacientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPacientes.Location = new System.Drawing.Point(258, 12);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Padding = new System.Windows.Forms.Padding(10);
            this.buttonPacientes.Size = new System.Drawing.Size(228, 175);
            this.buttonPacientes.TabIndex = 1;
            this.buttonPacientes.Text = "Paciente";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPacientes.UseVisualStyleBackColor = false;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 197);
            this.Controls.Add(this.buttonPacientes);
            this.Controls.Add(this.buttonEnderecos);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEnderecos;
        private Button buttonPacientes;
    }
}