namespace BasicCrud
{
    partial class FrmTeste
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.rb_feminino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.gpb_sexo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.gpb_sexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(24, 32);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(82, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(298, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(82, 73);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(298, 20);
            this.txt_endereco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone: ";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(86, 110);
            this.txt_telefone.Mask = "(999) 000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(149, 20);
            this.txt_telefone.TabIndex = 5;
            // 
            // rb_feminino
            // 
            this.rb_feminino.AutoSize = true;
            this.rb_feminino.Location = new System.Drawing.Point(72, 19);
            this.rb_feminino.Name = "rb_feminino";
            this.rb_feminino.Size = new System.Drawing.Size(71, 17);
            this.rb_feminino.TabIndex = 7;
            this.rb_feminino.TabStop = true;
            this.rb_feminino.Text = "Femonino";
            this.rb_feminino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(206, 19);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rb_masculino.TabIndex = 8;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(35, 404);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(153, 51);
            this.btn_gravar.TabIndex = 12;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // gpb_sexo
            // 
            this.gpb_sexo.Controls.Add(this.rb_feminino);
            this.gpb_sexo.Controls.Add(this.rb_masculino);
            this.gpb_sexo.Location = new System.Drawing.Point(35, 150);
            this.gpb_sexo.Name = "gpb_sexo";
            this.gpb_sexo.Size = new System.Drawing.Size(345, 100);
            this.gpb_sexo.TabIndex = 13;
            this.gpb_sexo.TabStop = false;
            this.gpb_sexo.Text = "Sexo: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ativo);
            this.groupBox1.Controls.Add(this.rb_inativo);
            this.groupBox1.Location = new System.Drawing.Point(35, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Location = new System.Drawing.Point(72, 19);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_ativo.TabIndex = 7;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Location = new System.Drawing.Point(206, 19);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(57, 17);
            this.rb_inativo.TabIndex = 8;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(205, 373);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(153, 20);
            this.txt_id.TabIndex = 15;
            this.txt_id.Text = "ID PARA EXC/ALT";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(205, 404);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(153, 51);
            this.btn_excluir.TabIndex = 16;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // FrmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 552);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_sexo);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeste";
            this.gpb_sexo.ResumeLayout(false);
            this.gpb_sexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.RadioButton rb_feminino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.GroupBox gpb_sexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_excluir;
    }
}