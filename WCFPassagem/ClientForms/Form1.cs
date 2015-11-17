using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientForms.ServiceReference1;

namespace ClientForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                new ClienteServiceClient().Add(
                                        new Cliente()
                                                    {
                                                        Nome = txtNome.Text,
                                                        Cpf = txtCpf.Text
                                                    });
                 
                MessageBox.Show("Cliente Cadastrado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Cadastrar o Cliente");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCpf.Text = new ClienteServiceClient()
                                                .Buscar(txtNome.Text).Cpf;
        }


    }
}
