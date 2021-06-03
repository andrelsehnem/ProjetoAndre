
namespace Projeto_André.Foms
{
    partial class frm_login
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
            this.abas_login = new System.Windows.Forms.TabControl();
            this.aba_login = new System.Windows.Forms.TabPage();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.msk_senhaLogin = new System.Windows.Forms.MaskedTextBox();
            this.txt_userLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aba_config = new System.Windows.Forms.TabPage();
            this.msk_porta = new System.Windows.Forms.MaskedTextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_senhaServer = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usuarioServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_servidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aba_criarBd = new System.Windows.Forms.TabPage();
            this.bt_criaBd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.abas_login.SuspendLayout();
            this.aba_login.SuspendLayout();
            this.aba_config.SuspendLayout();
            this.aba_criarBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // abas_login
            // 
            this.abas_login.Controls.Add(this.aba_login);
            this.abas_login.Controls.Add(this.aba_config);
            this.abas_login.Controls.Add(this.aba_criarBd);
            this.abas_login.Location = new System.Drawing.Point(-1, -1);
            this.abas_login.Name = "abas_login";
            this.abas_login.SelectedIndex = 0;
            this.abas_login.Size = new System.Drawing.Size(266, 188);
            this.abas_login.TabIndex = 0;
            this.abas_login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.abas_login_KeyUp);
            // 
            // aba_login
            // 
            this.aba_login.Controls.Add(this.bt_fechar);
            this.aba_login.Controls.Add(this.bt_login);
            this.aba_login.Controls.Add(this.msk_senhaLogin);
            this.aba_login.Controls.Add(this.txt_userLogin);
            this.aba_login.Controls.Add(this.label2);
            this.aba_login.Controls.Add(this.label1);
            this.aba_login.Location = new System.Drawing.Point(4, 22);
            this.aba_login.Name = "aba_login";
            this.aba_login.Padding = new System.Windows.Forms.Padding(3);
            this.aba_login.Size = new System.Drawing.Size(258, 162);
            this.aba_login.TabIndex = 0;
            this.aba_login.Text = "Login";
            this.aba_login.UseVisualStyleBackColor = true;
            this.aba_login.Click += new System.EventHandler(this.aba_login_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(130, 112);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(90, 35);
            this.bt_fechar.TabIndex = 5;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(24, 112);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(90, 35);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Entrar";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // msk_senhaLogin
            // 
            this.msk_senhaLogin.Location = new System.Drawing.Point(58, 77);
            this.msk_senhaLogin.Name = "msk_senhaLogin";
            this.msk_senhaLogin.PasswordChar = '*';
            this.msk_senhaLogin.Size = new System.Drawing.Size(177, 20);
            this.msk_senhaLogin.TabIndex = 3;
            this.msk_senhaLogin.Text = "123";
            // 
            // txt_userLogin
            // 
            this.txt_userLogin.Location = new System.Drawing.Point(58, 44);
            this.txt_userLogin.Name = "txt_userLogin";
            this.txt_userLogin.Size = new System.Drawing.Size(177, 20);
            this.txt_userLogin.TabIndex = 2;
            this.txt_userLogin.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // aba_config
            // 
            this.aba_config.Controls.Add(this.msk_porta);
            this.aba_config.Controls.Add(this.bt_salvar);
            this.aba_config.Controls.Add(this.txt_banco);
            this.aba_config.Controls.Add(this.label7);
            this.aba_config.Controls.Add(this.msk_senhaServer);
            this.aba_config.Controls.Add(this.label6);
            this.aba_config.Controls.Add(this.label5);
            this.aba_config.Controls.Add(this.txt_usuarioServer);
            this.aba_config.Controls.Add(this.label4);
            this.aba_config.Controls.Add(this.txt_servidor);
            this.aba_config.Controls.Add(this.label3);
            this.aba_config.Location = new System.Drawing.Point(4, 22);
            this.aba_config.Name = "aba_config";
            this.aba_config.Padding = new System.Windows.Forms.Padding(3);
            this.aba_config.Size = new System.Drawing.Size(258, 162);
            this.aba_config.TabIndex = 1;
            this.aba_config.Text = "Configuração";
            this.aba_config.UseVisualStyleBackColor = true;
            // 
            // msk_porta
            // 
            this.msk_porta.Location = new System.Drawing.Point(126, 34);
            this.msk_porta.Mask = "0000";
            this.msk_porta.Name = "msk_porta";
            this.msk_porta.Size = new System.Drawing.Size(113, 20);
            this.msk_porta.TabIndex = 11;
            this.msk_porta.Text = "3306";
            this.msk_porta.ValidatingType = typeof(int);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(136, 114);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(90, 35);
            this.bt_salvar.TabIndex = 10;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(7, 122);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(113, 20);
            this.txt_banco.TabIndex = 9;
            this.txt_banco.Text = "bancoProjeto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Banco";
            // 
            // msk_senhaServer
            // 
            this.msk_senhaServer.Location = new System.Drawing.Point(126, 78);
            this.msk_senhaServer.Name = "msk_senhaServer";
            this.msk_senhaServer.PasswordChar = '*';
            this.msk_senhaServer.Size = new System.Drawing.Size(113, 20);
            this.msk_senhaServer.TabIndex = 7;
            this.msk_senhaServer.Text = "vssql";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuario";
            // 
            // txt_usuarioServer
            // 
            this.txt_usuarioServer.Location = new System.Drawing.Point(7, 78);
            this.txt_usuarioServer.Name = "txt_usuarioServer";
            this.txt_usuarioServer.Size = new System.Drawing.Size(113, 20);
            this.txt_usuarioServer.TabIndex = 4;
            this.txt_usuarioServer.Text = "root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Porta";
            // 
            // txt_servidor
            // 
            this.txt_servidor.Location = new System.Drawing.Point(6, 34);
            this.txt_servidor.Name = "txt_servidor";
            this.txt_servidor.Size = new System.Drawing.Size(113, 20);
            this.txt_servidor.TabIndex = 1;
            this.txt_servidor.Text = "localhost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servidor";
            // 
            // aba_criarBd
            // 
            this.aba_criarBd.Controls.Add(this.bt_criaBd);
            this.aba_criarBd.Controls.Add(this.label8);
            this.aba_criarBd.Location = new System.Drawing.Point(4, 22);
            this.aba_criarBd.Name = "aba_criarBd";
            this.aba_criarBd.Padding = new System.Windows.Forms.Padding(3);
            this.aba_criarBd.Size = new System.Drawing.Size(258, 162);
            this.aba_criarBd.TabIndex = 2;
            this.aba_criarBd.Text = "Criar Banco";
            this.aba_criarBd.UseVisualStyleBackColor = true;
            // 
            // bt_criaBd
            // 
            this.bt_criaBd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_criaBd.Location = new System.Drawing.Point(70, 85);
            this.bt_criaBd.Name = "bt_criaBd";
            this.bt_criaBd.Size = new System.Drawing.Size(107, 44);
            this.bt_criaBd.TabIndex = 1;
            this.bt_criaBd.Text = "Criar Banco de dados";
            this.bt_criaBd.UseVisualStyleBackColor = true;
            this.bt_criaBd.Click += new System.EventHandler(this.bt_criaBd_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 58);
            this.label8.TabIndex = 0;
            this.label8.Text = "Para criar o banco de dados é necessário primeiramente acessar a aba \"Configuraçã" +
    "o\" e informar os dados do servidor e o nome que será usado para o banco de dados" +
    "!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 185);
            this.Controls.Add(this.abas_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_login_KeyPress);
            this.abas_login.ResumeLayout(false);
            this.aba_login.ResumeLayout(false);
            this.aba_login.PerformLayout();
            this.aba_config.ResumeLayout(false);
            this.aba_config.PerformLayout();
            this.aba_criarBd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abas_login;
        private System.Windows.Forms.TabPage aba_login;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.MaskedTextBox msk_senhaLogin;
        private System.Windows.Forms.TextBox txt_userLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage aba_config;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_servidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_senhaServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usuarioServer;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.MaskedTextBox msk_porta;
        private System.Windows.Forms.TabPage aba_criarBd;
        private System.Windows.Forms.Button bt_criaBd;
        private System.Windows.Forms.Label label8;
    }
}