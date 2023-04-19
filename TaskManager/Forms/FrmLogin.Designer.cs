namespace TaskManager.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Bloco = new System.Windows.Forms.Panel();
            this.lblSenhaEsquecida = new System.Windows.Forms.Label();
            this.lblLoginInexistente = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tituloPanel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Bloco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Bloco
            // 
            this.Bloco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Bloco.BackColor = System.Drawing.Color.White;
            this.Bloco.Controls.Add(this.lblSenhaEsquecida);
            this.Bloco.Controls.Add(this.lblLoginInexistente);
            this.Bloco.Controls.Add(this.btnLogin);
            this.Bloco.Controls.Add(this.label3);
            this.Bloco.Controls.Add(this.txtSenha);
            this.Bloco.Controls.Add(this.lblEmail);
            this.Bloco.Controls.Add(this.txtEmail);
            this.Bloco.Controls.Add(this.tituloPanel);
            this.Bloco.Location = new System.Drawing.Point(228, 203);
            this.Bloco.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.Bloco.Name = "Bloco";
            this.Bloco.Size = new System.Drawing.Size(551, 466);
            this.Bloco.TabIndex = 2;
            // 
            // lblSenhaEsquecida
            // 
            this.lblSenhaEsquecida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSenhaEsquecida.AutoSize = true;
            this.lblSenhaEsquecida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSenhaEsquecida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSenhaEsquecida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSenhaEsquecida.Location = new System.Drawing.Point(28, 292);
            this.lblSenhaEsquecida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaEsquecida.Name = "lblSenhaEsquecida";
            this.lblSenhaEsquecida.Size = new System.Drawing.Size(279, 24);
            this.lblSenhaEsquecida.TabIndex = 17;
            this.lblSenhaEsquecida.Text = "Esqueceu a senha? Clique aqui";
            this.lblSenhaEsquecida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginInexistente
            // 
            this.lblLoginInexistente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoginInexistente.AutoSize = true;
            this.lblLoginInexistente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginInexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInexistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLoginInexistente.Location = new System.Drawing.Point(121, 411);
            this.lblLoginInexistente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginInexistente.Name = "lblLoginInexistente";
            this.lblLoginInexistente.Size = new System.Drawing.Size(286, 25);
            this.lblLoginInexistente.TabIndex = 16;
            this.lblLoginInexistente.Text = "Não tem cadastro? Registrar-se";
            this.lblLoginInexistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginInexistente.Click += new System.EventHandler(this.lblLoginInexistente_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(188, 357);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 44);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(27, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtSenha.Location = new System.Drawing.Point(32, 249);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(480, 38);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.Text = "Inserir sua senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblEmail.Location = new System.Drawing.Point(27, 116);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(285, 30);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtEmail.Location = new System.Drawing.Point(29, 149);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(483, 38);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Inserir seu e-mail";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // tituloPanel
            // 
            this.tituloPanel.BackColor = System.Drawing.Color.Transparent;
            this.tituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.tituloPanel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tituloPanel.Location = new System.Drawing.Point(0, 0);
            this.tituloPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(551, 73);
            this.tituloPanel.TabIndex = 0;
            this.tituloPanel.Text = "Login";
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Bloco);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Bloco.ResumeLayout(false);
            this.Bloco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Bloco;
        private System.Windows.Forms.Label lblSenhaEsquecida;
        private System.Windows.Forms.Label lblLoginInexistente;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label tituloPanel;
    }
}