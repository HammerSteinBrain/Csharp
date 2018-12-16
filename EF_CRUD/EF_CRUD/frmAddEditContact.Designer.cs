namespace EF_CRUD
{
    partial class frmAddEditContact
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
            this.components = new System.ComponentModel.Container();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_nome_contato = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_addres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(338, 372);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(166, 44);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_nome_contato
            // 
            this.lbl_nome_contato.AutoSize = true;
            this.lbl_nome_contato.Location = new System.Drawing.Point(34, 37);
            this.lbl_nome_contato.Name = "lbl_nome_contato";
            this.lbl_nome_contato.Size = new System.Drawing.Size(80, 13);
            this.lbl_nome_contato.TabIndex = 1;
            this.lbl_nome_contato.Text = "Nome contato: ";
            // 
            // txt_contato
            // 
            this.txt_contato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "ContactName", true));
            this.txt_contato.Location = new System.Drawing.Point(177, 34);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(294, 20);
            this.txt_contato.TabIndex = 0;
            this.txt_contato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "PhoneNumer", true));
            this.txt_phone.Location = new System.Drawing.Point(177, 72);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(294, 20);
            this.txt_phone.TabIndex = 1;
            this.txt_phone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Email", true));
            this.txt_email.Location = new System.Drawing.Point(177, 110);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(294, 20);
            this.txt_email.TabIndex = 2;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // txt_addres
            // 
            this.txt_addres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Address", true));
            this.txt_addres.Location = new System.Drawing.Point(177, 145);
            this.txt_addres.Multiline = true;
            this.txt_addres.Name = "txt_addres";
            this.txt_addres.Size = new System.Drawing.Size(327, 134);
            this.txt_addres.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Andrees:";
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(EF_CRUD.Contacts);
            // 
            // frmAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 495);
            this.Controls.Add(this.txt_addres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.lbl_nome_contato);
            this.Controls.Add(this.btn_Save);
            this.Name = "frmAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditContact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditContact_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_nome_contato;
        private System.Windows.Forms.TextBox txt_contato;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_addres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource contactsBindingSource;
    }
}