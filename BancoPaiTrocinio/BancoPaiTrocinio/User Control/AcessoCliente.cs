using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoPaiTrocinio.Conexões;

namespace BancoPaiTrocinio.User_Control
{
    public partial class AcessoCliente : UserControl {

        private static ConexaoMySql conexao;
        private string radioText;
        public string strGelio;
        private int buscaOn;
        public Boolean jp;

        public AcessoCliente() {
            InitializeComponent();
        }

        public string Manipula_String(string s) {
            try {
                if (radioText == "Conta Corrente" && TxtBusca.Text != string.Empty && buscaOn == 1) {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id_conta_bancaria
                          WHERE u.u_cpf = " + Convert.ToString(TxtBusca.Text) + ";";
                } else if (radioText == "Conta Poupança" && TxtBusca.Text != string.Empty && buscaOn == 1) {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id_conta_bancaria
                          WHERE u.u_cpf = " + Convert.ToString(TxtBusca.Text) + ";";
                } else if (radioText == "Conta Corrente") {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id_conta_bancaria;";
                } else if (radioText == "Conta Poupança") {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id_usuadio
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id_usuario
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id_conta_bancaria";
                }
            } catch (Exception e) {
                MessageBox.Show("Erro: " + e.Message);
            }
            if (buscaOn == 1) {
                buscaOn = 0;
            }
            return s;
        }

        private string ConfirmaBotao() {
            foreach (RadioButton r in Grp_TipoConta.Controls) {
                if (r.Checked) {
                    radioText = r.Text;
                }
            }
            return radioText;
        }

        private void AcessoCliente_Load(object sender, EventArgs e) {
            try {
                radioText = ConfirmaBotao();
                if (radioText != string.Empty) {
                    strGelio = Manipula_String(strGelio);
                    dataGridView2.DataSource = conexao.RetornaSQL(strGelio);
                } else {
                    MessageBox.Show("Por favor, selecione um tipo de conta.");
                    return;
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Buscar_Click(object sender, EventArgs e) {
            if (TxtBusca.Text == string.Empty) {
                MessageBox.Show("Digite um CPF!");
            } else {
                buscaOn = 1;
                AcessoCliente_Load(sender, e);
            }
        }

        private void Atualizar_Click(object sender, EventArgs e) {
            AcessoCliente_Load(sender, e);
        }

        private void Inserir_Click(object sender, EventArgs e) {
            if (Txt_Nome.Text == string.Empty || Txt_Bairro.Text == string.Empty || Txt_Celular.Text == string.Empty || Txt_Cidade.Text == string.Empty || Txt_CPF.Text == string.Empty || Txt_Profissao.Text == string.Empty || Txt_Email.Text == string.Empty || Txt_CEP.Text == string.Empty || Txt_Logradouro.Text == string.Empty || Txt_Rg.Text == string.Empty || Txt_Saldo.Text == string.Empty || Txt_Telefone.Text == string.Empty || Txt_Complemento.Text == string.Empty || Txt_Estado.Text == string.Empty || Txt_NumeroAgencia.Text == string.Empty || Txt_NumeroConta.Text == string.Empty) {
                MessageBox.Show("É necessário preencher todos os campos!");
            } else {
                radioText = ConfirmaBotao();
                try {
                    if (radioText == "Conta Corrente") {

                    }
                } catch (Exception a) {
                    MessageBox.Show(a.Message);
                }
            }
        }
    }
}
