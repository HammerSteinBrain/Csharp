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
    public partial class Form1 : Form
    {
        ContactEntities db = new ContactEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contactsBindingSource.DataSource = db.Contacts.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(null);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactsBindingSource.DataSource = db.Contacts.ToList();

                //foreach (Contacts c in db.Contacts.ToList())
                //{
                //    MessageBox.Show(c.ID + "\n" + c.ContactName + "\n" + c.Email + "\n" + c.Address);
                //}
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (contactsBindingSource.Current == null)
            {
                return;
            }

            using (frmAddEditContact frm = new frmAddEditContact(contactsBindingSource.Current as Contacts))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    contactsBindingSource.DataSource = db.Contacts.ToList();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (contactsBindingSource.Current != null)
            {
                if (MessageBox.Show("Tem certeza que quer deletar?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Contacts.Remove(contactsBindingSource.Current as Contacts);
                    contactsBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
