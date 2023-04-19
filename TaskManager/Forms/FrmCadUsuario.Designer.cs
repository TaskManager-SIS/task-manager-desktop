namespace TaskManager.Forms
{
    partial class FrmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsuario));
            this.Bloco = new System.Windows.Forms.Panel();
            this.lblLoginExistente = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.txtSenhaConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tituloPanel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Bloco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Bloco
            // 
            this.Bloco.BackColor = System.Drawing.Color.White;
            this.Bloco.Controls.Add(this.lblLoginExistente);
            this.Bloco.Controls.Add(this.btnCriarConta);
            this.Bloco.Controls.Add(this.txtSenhaConfirm);
            this.Bloco.Controls.Add(this.label2);
            this.Bloco.Controls.Add(this.label3);
            this.Bloco.Controls.Add(this.txtSenha);
            this.Bloco.Controls.Add(this.label1);
            this.Bloco.Controls.Add(this.lblEmail);
            this.Bloco.Controls.Add(this.txtEmail);
            this.Bloco.Controls.Add(this.lblNome);
            this.Bloco.Controls.Add(this.txtNome);
            this.Bloco.Controls.Add(this.tituloPanel);
            this.Bloco.Location = new System.Drawing.Point(228, 203);
            this.Bloco.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.Bloco.Name = "Bloco";
            this.Bloco.Size = new System.Drawing.Size(551, 635);
            this.Bloco.TabIndex = 2;
            // 
            // lblLoginExistente
            // 
            this.lblLoginExistente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginExistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLoginExistente.Location = new System.Drawing.Point(110, 574);
            this.lblLoginExistente.Name = "lblLoginExistente";
            this.lblLoginExistente.Size = new System.Drawing.Size(330, 38);
            this.lblLoginExistente.TabIndex = 16;
            this.lblLoginExistente.Text = "Já tem cadastro? Realizar login";
            this.lblLoginExistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginExistente.Click += new System.EventHandler(this.lblLoginExistente_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCriarConta.ForeColor = System.Drawing.Color.White;
            this.btnCriarConta.Location = new System.Drawing.Point(162, 526);
            this.btnCriarConta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(227, 44);
            this.btnCriarConta.TabIndex = 15;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = false;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // txtSenhaConfirm
            // 
            this.txtSenhaConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenhaConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtSenhaConfirm.Location = new System.Drawing.Point(29, 457);
            this.txtSenhaConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaConfirm.MaxLength = 100;
            this.txtSenhaConfirm.Multiline = true;
            this.txtSenhaConfirm.Name = "txtSenhaConfirm";
            this.txtSenhaConfirm.PasswordChar = '*';
            this.txtSenhaConfirm.Size = new System.Drawing.Size(492, 34);
            this.txtSenhaConfirm.TabIndex = 14;
            this.txtSenhaConfirm.Text = "Confirme sua senha";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(28, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Confirmar senha";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(28, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtSenha.Location = new System.Drawing.Point(29, 351);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(492, 34);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.Text = "Inserir sua senha";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(27, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-mail";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(285, 30);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtEmail.Location = new System.Drawing.Point(29, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(492, 34);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Inserir seu e-mail";
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblNome.Location = new System.Drawing.Point(28, 105);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(253, 30);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtNome.Location = new System.Drawing.Point(29, 139);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(492, 34);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Inserir seu nome";
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.Color.Transparent;
            this.tituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.tituloPanel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tituloPanel.Location = new System.Drawing.Point(0, 0);
            this.tituloPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(551, 65);
            this.tituloPanel.TabIndex = 0;
            this.tituloPanel.Text = "Cadastrar-se";
            this.tituloPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(228, 51);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(551, 94);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1006, 895);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Bloco);
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar usuário - TaskManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadUsuario_FormClosed);
            this.Bloco.ResumeLayout(false);
            this.Bloco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Bloco;
        private System.Windows.Forms.Label lblLoginExistente;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.TextBox txtSenhaConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label tituloPanel;
    }
}