
namespace Projeto_André.Foms
{
    partial class frm_clientes
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
            this.bt_fechar = new System.Windows.Forms.Button();
            this.grid_clientes = new System.Windows.Forms.DataGridView();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.bt_listar = new System.Windows.Forms.Button();
            this.combo_pesquisa = new System.Windows.Forms.ComboBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.bt_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(540, 351);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(97, 39);
            this.bt_fechar.TabIndex = 0;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // grid_clientes
            // 
            this.grid_clientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_clientes.EnableHeadersVisualStyles = false;
            this.grid_clientes.Location = new System.Drawing.Point(12, 41);
            this.grid_clientes.MultiSelect = false;
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(518, 349);
            this.grid_clientes.TabIndex = 1;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(540, 41);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(97, 40);
            this.bt_adicionar.TabIndex = 2;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // combo_tipo
            // 
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Items.AddRange(new object[] {
            "Ambos",
            "Cliente",
            "Funcionário"});
            this.combo_tipo.Location = new System.Drawing.Point(372, 12);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(91, 21);
            this.combo_tipo.TabIndex = 3;
            this.combo_tipo.Text = "Ambos";
            // 
            // bt_listar
            // 
            this.bt_listar.Location = new System.Drawing.Point(469, 12);
            this.bt_listar.Name = "bt_listar";
            this.bt_listar.Size = new System.Drawing.Size(61, 23);
            this.bt_listar.TabIndex = 4;
            this.bt_listar.Text = "Listar";
            this.bt_listar.UseVisualStyleBackColor = true;
            this.bt_listar.Click += new System.EventHandler(this.bt_listar_Click);
            // 
            // combo_pesquisa
            // 
            this.combo_pesquisa.FormattingEnabled = true;
            this.combo_pesquisa.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "CPF",
            "Telefone",
            "Endereço",
            "Complemento",
            "Bairro",
            "Cidade",
            "Estado"});
            this.combo_pesquisa.Location = new System.Drawing.Point(13, 12);
            this.combo_pesquisa.Name = "combo_pesquisa";
            this.combo_pesquisa.Size = new System.Drawing.Size(107, 21);
            this.combo_pesquisa.TabIndex = 5;
            this.combo_pesquisa.Text = "Código";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(127, 12);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(239, 20);
            this.txt_pesquisa.TabIndex = 6;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(540, 88);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(97, 37);
            this.bt_excluir.TabIndex = 7;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 416);
            this.ControlBox = false;
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.combo_pesquisa);
            this.Controls.Add(this.bt_listar);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.grid_clientes);
            this.Controls.Add(this.bt_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_clientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto André";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.Button bt_listar;
        private System.Windows.Forms.DataGridView grid_clientes;
        private System.Windows.Forms.ComboBox combo_pesquisa;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button bt_excluir;
    }
}