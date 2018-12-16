using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCrud
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_nome.Text) && !string.IsNullOrEmpty(txt_endereco.Text))//diferente vazio
                {

                    string strSexo = null;
                    bool bln_ativo_noMomento = false;

                    if (rb_masculino.Checked)
                    {
                        strSexo = "M";
                    }
                    else
                    {
                        strSexo = "F";
                    }



                    if (rb_ativo.Checked)
                    {
                        bln_ativo_noMomento = true;
                    }
                    else
                    {
                        bln_ativo_noMomento = true;
                    }


                    Dados DAO = new Dados();

                    DAO.Gravar(txt_nome.Text, txt_endereco.Text, txt_telefone.Text, strSexo, bln_ativo_noMomento, DateTime.Now.Date);

                    MessageBox.Show("Gravado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }

            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Dados DAO = new Dados();

            DAO.Excluir(Convert.ToInt32(txt_id.Text));

            MessageBox.Show("Excluido!");
        }
    }
}
