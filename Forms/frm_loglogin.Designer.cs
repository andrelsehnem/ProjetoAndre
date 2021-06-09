
namespace Projeto_André.Forms
{
    partial class frm_loglogin
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
            this.grid_login = new System.Windows.Forms.DataGridView();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_periodo1 = new System.Windows.Forms.DateTimePicker();
            this.data_periodo2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_login)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_login
            // 
            this.grid_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_login.Location = new System.Drawing.Point(13, 60);
            this.grid_login.MultiSelect = false;
            this.grid_login.Name = "grid_login";
            this.grid_login.ReadOnly = true;
            this.grid_login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_login.Size = new System.Drawing.Size(389, 297);
            this.grid_login.TabIndex = 0;
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Items.AddRange(new object[] {
            "Todos"});
            this.combo_usuarios.Location = new System.Drawing.Point(64, 33);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(129, 21);
            this.combo_usuarios.TabIndex = 1;
            this.combo_usuarios.Text = "Todos";
            this.combo_usuarios.SelectedIndexChanged += new System.EventHandler(this.combo_usuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Período";
            // 
            // data_periodo1
            // 
            this.data_periodo1.CustomFormat = "yyyy-MM-dd";
            this.data_periodo1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_periodo1.Location = new System.Drawing.Point(64, 7);
            this.data_periodo1.Name = "data_periodo1";
            this.data_periodo1.Size = new System.Drawing.Size(82, 20);
            this.data_periodo1.TabIndex = 4;
            // 
            // data_periodo2
            // 
            this.data_periodo2.CustomFormat = "yyyy-MM-dd";
            this.data_periodo2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_periodo2.Location = new System.Drawing.Point(204, 7);
            this.data_periodo2.Name = "data_periodo2";
            this.data_periodo2.Size = new System.Drawing.Size(82, 20);
            this.data_periodo2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "até";
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.Location = new System.Drawing.Point(211, 33);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(75, 23);
            this.bt_filtrar.TabIndex = 7;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = true;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // frm_loglogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 371);
            this.Controls.Add(this.bt_filtrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_periodo2);
            this.Controls.Add(this.data_periodo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_usuarios);
            this.Controls.Add(this.grid_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_loglogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Login";
            this.Load += new System.EventHandler(this.frm_loglogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_login;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_periodo1;
        private System.Windows.Forms.DateTimePicker data_periodo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_filtrar;
    }
}