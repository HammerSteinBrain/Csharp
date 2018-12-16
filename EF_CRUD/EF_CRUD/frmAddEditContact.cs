using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CRUD
{
    public partial class frmAddEditContact : Form
    {

        ContactEntities db = new ContactEntities();


        public frmAddEditContact(Contacts objeto)
        {
            InitializeComponent();
            if (objeto == null)
            {
                contactsBindingSource.DataSource = new Contacts();

                db.Contacts.Add(contactsBindingSource.Current as Contacts);//add adiciona
            }
            else {
                contactsBindingSource.DataSource = objeto;

                db.Contacts.Attach(contactsBindingSource.Current as Contacts);//Attach = alterar
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditContact_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) {
                if (string.IsNullOrEmpty(txt_contato.Text)) {
                    MessageBox.Show("Por favor entre com seu nome de contato.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_contato.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }

            e.Cancel = false;
        }
    }
}
