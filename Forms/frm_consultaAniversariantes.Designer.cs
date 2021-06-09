
namespace Projeto_André.Forms
{
    partial class frm_consultaAniversariantes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.data_inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_fim = new System.Windows.Forms.DateTimePicker();
            this.bt_filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(330, 382);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(101, 40);
            this.bt_fechar.TabIndex = 1;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // data_inicio
            // 
            this.data_inicio.CustomFormat = "yyyy-MM-dd";
            this.data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_inicio.Location = new System.Drawing.Point(34, 13);
            this.data_inicio.Name = "data_inicio";
            this.data_inicio.Size = new System.Drawing.Size(83, 20);
            this.data_inicio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Até";
            // 
            // data_fim
            // 
            this.data_fim.CustomFormat = "yyyy-MM-dd";
            this.data_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_fim.Location = new System.Drawing.Point(157, 12);
            this.data_fim.Name = "data_fim";
            this.data_fim.Size = new System.Drawing.Size(84, 20);
            this.data_fim.TabIndex = 5;
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.Location = new System.Drawing.Point(330, 10);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(101, 23);
            this.bt_filtrar.TabIndex = 6;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = true;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // frm_consultaAniversariantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 430);
            this.ControlBox = false;
            this.Controls.Add(this.bt_filtrar);
            this.Controls.Add(this.data_fim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_inicio);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_consultaAniversariantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aniversariantes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_consultaAniversariantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.DateTimePicker data_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_fim;
        private System.Windows.Forms.Button bt_filtrar;
    }
}