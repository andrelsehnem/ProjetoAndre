
namespace Projeto_André.Forms
{
    partial class frm_novoCliente
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_funcionario = new System.Windows.Forms.GroupBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_funcionario = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msk_numero = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.group_funcionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(288, 356);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(104, 45);
            this.bt_cancelar.TabIndex = 0;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 25);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(287, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // group_funcionario
            // 
            this.group_funcionario.Controls.Add(this.txt_senha);
            this.group_funcionario.Controls.Add(this.label4);
            this.group_funcionario.Controls.Add(this.txt_usuario);
            this.group_funcionario.Controls.Add(this.label3);
            this.group_funcionario.Enabled = false;
            this.group_funcionario.Location = new System.Drawing.Point(12, 281);
            this.group_funcionario.Name = "group_funcionario";
            this.group_funcionario.Size = new System.Drawing.Size(149, 120);
            this.group_funcionario.TabIndex = 5;
            this.group_funcionario.TabStop = false;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(7, 81);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(136, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(7, 37);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(136, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário";
            // 
            // check_funcionario
            // 
            this.check_funcionario.AutoSize = true;
            this.check_funcionario.Location = new System.Drawing.Point(12, 267);
            this.check_funcionario.Name = "check_funcionario";
            this.check_funcionario.Size = new System.Drawing.Size(81, 17);
            this.check_funcionario.TabIndex = 6;
            this.check_funcionario.Text = "Funcionário";
            this.check_funcionario.UseVisualStyleBackColor = true;
            this.check_funcionario.CheckedChanged += new System.EventHandler(this.check_funcionario_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de Nascimento";
            // 
            // msk_nascimento
            // 
            this.msk_nascimento.Location = new System.Drawing.Point(153, 74);
            this.msk_nascimento.Mask = "00/00/0000";
            this.msk_nascimento.Name = "msk_nascimento";
            this.msk_nascimento.Size = new System.Drawing.Size(104, 20);
            this.msk_nascimento.TabIndex = 8;
            this.msk_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefone";
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(274, 74);
            this.msk_telefone.Mask = "(99) 00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(118, 20);
            this.msk_telefone.TabIndex = 10;
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(12, 74);
            this.msk_cpf.Mask = "00000000000";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(122, 20);
            this.msk_cpf.TabIndex = 11;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(319, 9);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 12;
            this.Codigo.Text = "Codigo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(320, 25);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(72, 20);
            this.txt_codigo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Endereço";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(12, 125);
            this.txt_endereco.MaxLength = 50;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(287, 20);
            this.txt_endereco.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número";
            // 
            // msk_numero
            // 
            this.msk_numero.Location = new System.Drawing.Point(320, 125);
            this.msk_numero.Mask = "00000";
            this.msk_numero.Name = "msk_numero";
            this.msk_numero.Size = new System.Drawing.Size(72, 20);
            this.msk_numero.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Complemento";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(12, 179);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(181, 20);
            this.txt_complemento.TabIndex = 19;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(211, 179);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(181, 20);
            this.txt_bairro.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cidade";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(12, 232);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(287, 20);
            this.txt_cidade.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(320, 232);
            this.txt_uf.MaxLength = 2;
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(72, 20);
            this.txt_uf.TabIndex = 25;
            this.txt_uf.Leave += new System.EventHandler(this.txt_uf_Leave);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(288, 301);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(104, 45);
            this.bt_adicionar.TabIndex = 26;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // frm_novoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 416);
            this.ControlBox = false;
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.msk_numero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk_nascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check_funcionario);
            this.Controls.Add(this.group_funcionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_novoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.TopMost = true;
            this.group_funcionario.ResumeLayout(false);
            this.group_funcionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_funcionario;
        private System.Windows.Forms.CheckBox check_funcionario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_nascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_telefone;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msk_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Button bt_adicionar;
    }
}