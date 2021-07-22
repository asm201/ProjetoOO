using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoPaiTrocinio.Classes;

namespace BancoPaiTrocinio.User_Control
{
    public partial class VerDados : UserControl
    {
        ContaCorrente clienteCorrente;
        ContaPoupanca clientePoupanca;
        public VerDados(ContaPoupanca cp = null, ContaCorrente cc = null)
        {
            InitializeComponent();
            if(cp == null)
            {
                clienteCorrente = cc;

                Nome.Text = clienteCorrente.u_nome;
                cpf.Text = clienteCorrente.u_cpf;
                rg.Text = clienteCorrente.u_rg;
                usuario.Text = clienteCorrente.u_usario;
                telefone.Text = clienteCorrente.ctt_tel;
                celular.Text = clienteCorrente.ctt_cel;
                email.Text = clienteCorrente.ctt_email;
                cep.Text = clienteCorrente.u_cep;
                logradouro.Text = clienteCorrente.u_logradouro;
                complemento.Text = clienteCorrente.u_complemento;
                bairro.Text = clienteCorrente.u_bairro;
                cidade.Text = clienteCorrente.u_cidade;
                estado.Text = clienteCorrente.u_estado;
                tipoConta.Text = "Conta Corrente";
                numeroAgencia.Text = clienteCorrente.cb_agencia.ToString();
                numeroAgencia.Text = clienteCorrente.cc_nr_conta_corrente.ToString();
                numeroAgencia.Text = "R$" + clienteCorrente.cc_saldo.ToString();
            }
            if(cc == null)
            {
                clientePoupanca = cp;

                Nome.Text = clientePoupanca.u_nome;
                cpf.Text = clientePoupanca.u_cpf;
                rg.Text = clientePoupanca.u_rg;
                usuario.Text = clientePoupanca.u_usario;
                telefone.Text = clientePoupanca.ctt_tel;
                celular.Text = clientePoupanca.ctt_cel;
                email.Text = clientePoupanca.ctt_email;
                cep.Text = clientePoupanca.u_cep;
                logradouro.Text = clientePoupanca.u_logradouro;
                complemento.Text = clientePoupanca.u_complemento;
                bairro.Text = clientePoupanca.u_bairro;
                cidade.Text = clientePoupanca.u_cidade;
                estado.Text = clientePoupanca.u_estado;
                tipoConta.Text = "Conta Poupança";
                numeroAgencia.Text = clientePoupanca.cb_agencia.ToString();
                numeroAgencia.Text = clientePoupanca.cp_nr_conta_poupanca.ToString();
                numeroAgencia.Text = "R$" + clientePoupanca.cp_saldo.ToString();
            }
        }
    }
}
