﻿namespace novo_projeto_anker
{
    partial class GestaoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "B - Bloqueado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "D - Desligado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "A - Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status";
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(195, 166);
            this.n_nivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(153, 22);
            this.n_nivel.TabIndex = 18;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 166);
            this.cb_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(153, 24);
            this.cb_status.TabIndex = 17;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(195, 100);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(153, 22);
            this.tb_senha.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Senha";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 100);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(156, 22);
            this.tb_name.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 39);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.PasswordChar = '*';
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(65, 22);
            this.tb_id.TabIndex = 25;
            this.tb_id.TabStop = false;
            this.tb_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Location = new System.Drawing.Point(9, 21);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(23, 16);
            this.tb.TabIndex = 24;
            this.tb.Text = "ID ";
            this.tb.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 63);
            this.panel1.TabIndex = 26;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Maroon;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fechar.Location = new System.Drawing.Point(614, 13);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(151, 39);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar Janela";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click_1);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_excluir.Location = new System.Drawing.Point(349, 13);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(151, 39);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir Usuários";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salvar.Location = new System.Drawing.Point(179, 13);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 39);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Navy;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_novo.Location = new System.Drawing.Point(12, 13);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(151, 39);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Usuário";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(373, 39);
            this.dgv_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.RowHeadersWidth = 51;
            this.dgv_usuarios.RowTemplate.Height = 24;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(367, 256);
            this.dgv_usuarios.TabIndex = 0;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 378);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuarios";
            this.Load += new System.EventHandler(this.GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
    }
}