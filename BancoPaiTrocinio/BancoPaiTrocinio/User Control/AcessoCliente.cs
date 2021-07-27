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
using BancoPaiTrocinio.Classes;

namespace BancoPaiTrocinio.User_Control
{
    public partial class AcessoCliente : UserControl {

        private static ConexaoMySql conexao = new ConexaoMySql();
        private string radioText;
        public string strGelio;
        private int buscaOn;

        public AcessoCliente() {
            InitializeComponent();

            Txt_Saldo.Enabled = false;
            Txt_NumeroConta.Enabled = false;
            Txt_NumeroAgencia.Enabled = false;
            
            Txt_Estado.Items.Clear();
            Txt_Estado.Items.Add("Acre (AC)");
            Txt_Estado.Items.Add("Alagoas(AL)");
            Txt_Estado.Items.Add("Amapá(AP)");
            Txt_Estado.Items.Add("Amazonas(AM)");
            Txt_Estado.Items.Add("Bahia(BA)");
            Txt_Estado.Items.Add("Ceará(CE)");
            Txt_Estado.Items.Add("Distrito Federal(DF)");
            Txt_Estado.Items.Add("Espírito Santo(ES)");
            Txt_Estado.Items.Add("Goiás(GO)");
            Txt_Estado.Items.Add("Maranhão(MA)");
            Txt_Estado.Items.Add("Mato Grosso(MT)");
            Txt_Estado.Items.Add("Mato Grosso do Sul(MS)");
            Txt_Estado.Items.Add("Minas Gerais(MG)");
            Txt_Estado.Items.Add("Pará(PA)");
            Txt_Estado.Items.Add("Paraíba(PB)");
            Txt_Estado.Items.Add("Paraná(PR)");
            Txt_Estado.Items.Add("Pernambuco(PE)");
            Txt_Estado.Items.Add("Piauí(PI)");
            Txt_Estado.Items.Add("Rio de Janeiro(RJ)");
            Txt_Estado.Items.Add("Rio Grande do Norte(RN)");
            Txt_Estado.Items.Add("Rio Grande do Sul(RS)");
            Txt_Estado.Items.Add("Rondônia(RO)");
            Txt_Estado.Items.Add("Roraima(RR)");
            Txt_Estado.Items.Add("Santa Catarina(SC)");
            Txt_Estado.Items.Add("São Paulo(SP)");
            Txt_Estado.Items.Add("Sergipe(SE)");
            Txt_Estado.Items.Add("Tocantins(TO)");
        }

        public string Manipula_String(string s) {
            try {
                if (this.radioText == "Conta Corrente" && TxtBusca.Text != string.Empty && buscaOn == 1) {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo
                          FROM usuario u INNER JOIN contato ct ON u.u_id = ct.ctt_id_usuario
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id
                          WHERE u.u_cpf = " + Convert.ToString(TxtBusca.Text) + ";";
                } else if (this.radioText == "Conta Poupança" && TxtBusca.Text != string.Empty && buscaOn == 1) {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id
                          WHERE u.u_cpf = " + Convert.ToString(TxtBusca.Text) + ";";
                } else if (this.radioText == "Conta Corrente") {
                    s = "SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,c.c_profissao,cb.cb_agencia, cc.cc_nr_conta_corrente, cc.cc_saldo FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id INNER JOIN cliente c ON u.u_id_cliente = c.c_id INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente INNER JOIN conta_corrente cc ON cb.cb_id_conta_corrente = cc.cc_id;";
                } else if (this.radioText == "Conta Poupança") {
                    s = @"SELECT u.u_nome,u.u_cpf,u.u_rg,u.u_cep,u.u_logradouro,u.u_complemento,
                          u.u_cidade,u.u_bairro,u.u_estado,ct.ctt_tel,ct.ctt_cel,ct.ctt_email,
                          c.c_profissao,cb.cb_agencia, cp.cp_nr_conta_poupanca, cp.cp_valor
                          FROM usuario u INNER JOIN contato ct ON u.u_ctt_id = ct.ctt_id
                          INNER JOIN cliente c ON u.u_id_cliente = c.c_id
                          INNER JOIN conta_bancaria cb ON c.c_id = cb.cb_id_cliente
                          INNER JOIN conta_poupanca cp ON cb.cb_id_conta_poupanca = cp.cp_id";
                }
            } catch (Exception e) {
                MessageBox.Show("Erro: " + e.Message);
            }
            if (buscaOn == 1) {
                buscaOn = 0;
                TxtBusca.Text = "";
            }
            return s;
        }

        private void LimparFormulario() {
            Txt_Nome.Text = "";
            Txt_CPF.Text = "";
            Txt_Rg.Text = "";
            Txt_CEP.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Complemento.Text = "";
            Txt_Cidade.Text = "";
            Txt_Bairro.Text = "";
            Txt_Estado.Text = "";
            Txt_Telefone.Text = "";
            Txt_Celular.Text = "";
            Txt_Email.Text = "";
            Txt_Profissao.Text = "";
            Txt_NumeroAgencia.Text = "";
            Txt_NumeroConta.Text = "";
            Txt_Saldo.Text = "R$ ";
            Txt_Estado.SelectedIndex = -1;
        }

        ContaCorrente LeituraFormularioContaCorrente() {
            ContaCorrente cc = new ContaCorrente();
            cc.u_nome = Txt_Nome.Text;
            cc.u_rg = Txt_Rg.Text;
            cc.u_cpf = Txt_CPF.Text;

            cc.u_cep = Txt_CEP.Text;
            cc.u_logradouro = Txt_Logradouro.Text;
            cc.u_complemento = Txt_Complemento.Text;
            cc.u_cidade = Txt_Cidade.Text;
            cc.u_bairro = Txt_Bairro.Text;
            if (Txt_Estado.SelectedIndex < 0) {
                cc.u_estado = "";
            } else {
                cc.u_estado = Txt_Estado.Items[Txt_Estado.SelectedIndex].ToString();
            }
            cc.ctt_tel = Txt_Telefone.Text;
            cc.ctt_cel = Txt_Celular.Text;
            cc.ctt_email = Txt_Email.Text;
            cc.cb_agencia = 1010;
            Random rnd = new Random();
            cc.cc_nr_conta_corrente = rnd.Next(10000000, 99999999);
            cc.cc_saldo = 100;

            cc.c_profissao = Txt_Profissao.Text;
       

            return cc;
        }

        ContaPoupanca LeituraFormularioContaPoupanca() {
            ContaPoupanca cp = new ContaPoupanca();
            cp.u_nome = Txt_Nome.Text;
            cp.u_rg = Txt_Rg.Text;
            cp.u_cpf = Txt_CPF.Text;

            cp.u_cep = Txt_CEP.Text;
            cp.u_logradouro = Txt_Logradouro.Text;
            cp.u_complemento = Txt_Complemento.Text;
            cp.u_cidade = Txt_Cidade.Text;
            cp.u_bairro = Txt_Bairro.Text;
            if (Txt_Estado.SelectedIndex < 0) {
                cp.u_estado = "";
            } else {
                cp.u_estado = Txt_Estado.Items[Txt_Estado.SelectedIndex].ToString();
            }
            cp.ctt_tel = Txt_Telefone.Text;
            cp.ctt_cel = Txt_Celular.Text;
            cp.ctt_email = Txt_Email.Text;
            cp.cb_agencia = 1010;
            Random rnd = new Random();
            cp.cp_nr_conta_poupanca = rnd.Next(1000000, 9999999);
            cp.cp_saldo = 0.00;
            cp.c_profissao = Txt_Profissao.Text;

            return cp;
        }

        private string ConfirmaBotao() {
            foreach (RadioButton r in Grp_TipoConta.Controls) {
                if (r.Checked == true) {
                    this.radioText = r.Text;
                }
            }
            return radioText;
        }

        private void AcessoCliente_Load(object sender, EventArgs e) {
            try {
                this.radioText = ConfirmaBotao();
                if (this.radioText != string.Empty) {
                    this.strGelio = Manipula_String(this.strGelio);
                    dataGridView2.DataSource = conexao.RetornaSQL(Convert.ToString(this.strGelio));
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
            LimparFormulario();
            AcessoCliente_Load(sender, e);
        }

        private void Inserir_Click(object sender, EventArgs e) {
           
            if (Txt_Nome.Text == string.Empty || Txt_Bairro.Text == string.Empty || Txt_Celular.Text == string.Empty || Txt_Cidade.Text == string.Empty || Txt_CPF.Text == string.Empty || Txt_Profissao.Text == string.Empty || Txt_Email.Text == string.Empty || Txt_CEP.Text == string.Empty || Txt_Logradouro.Text == string.Empty || Txt_Rg.Text == string.Empty ||  Txt_Telefone.Text == string.Empty || Txt_Complemento.Text == string.Empty || Txt_Estado.Text == string.Empty) {
                MessageBox.Show("É necessário preencher todos os campos!");
            } else {
                this.radioText = ConfirmaBotao();
                try {
                    if (this.radioText == "Conta Corrente") {
                        ContaCorrente cc = new ContaCorrente();
                        cc = LeituraFormularioContaCorrente();
                        cc.ValidaClasse();
                        cc.ValidaComplemento();
                        conexao.ExecutaSQL("INSERT INTO usuario (u_cpf,u_rg,u_nome,u_logradouro,u_complemento,u_bairro,u_cidade,u_estado,u_cep)VALUES('" + Convert.ToString(cc.u_cpf) + "','" + Convert.ToString(cc.u_rg) + "','" + Convert.ToString(cc.u_nome) + "','" + Convert.ToString(cc.u_logradouro) + "','" + Convert.ToString(cc.u_complemento) + "','" + Convert.ToString(cc.u_bairro) + "','" + Convert.ToString(cc.u_cidade) + "','" + Convert.ToString(cc.u_estado) + "','" + Convert.ToString(cc.u_cep) + "');");
                        DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(cc.u_cpf)}';");
                        conexao.ExecutaSQL($"INSERT INTO contato (ctt_id_usuario,ctt_tel,ctt_cel,ctt_email) VALUES ({query.Rows[0]["u_id"]},'{Convert.ToString(cc.ctt_tel)}','{Convert.ToString(cc.ctt_cel)}','{Convert.ToString(cc.ctt_email)}');");
                        DataTable query2 = conexao.RetornaSQL($"SELECT ctt_id FROM contato WHERE ctt_id_usuario = {query.Rows[0]["u_id"]};");
                        conexao.ExecutaSQL($"UPDATE usuario SET u_ctt_id = {query2.Rows[0]["ctt_id"]} WHERE u_cpf = '{Convert.ToString(cc.u_cpf)}';");
                        conexao.ExecutaSQL($"INSERT INTO cliente (c_id_usuario, c_profissao) VALUES ({Convert.ToInt32(query.Rows[0]["u_id"])},'{Convert.ToString(cc.c_profissao)}');");
                        DataTable query3 = conexao.RetornaSQL($"SELECT c_id FROM cliente WHERE c_id_usuario = {query.Rows[0]["u_id"]};");
                        conexao.ExecutaSQL($"UPDATE usuario SET u_id_cliente = {query3.Rows[0]["c_id"]} WHERE u_id = {Convert.ToInt32(query.Rows[0]["u_id"])};");
                        conexao.ExecutaSQL($"INSERT INTO conta_bancaria (cb_agencia, cb_id_cliente) VALUES ({cc.cb_agencia},{Convert.ToInt32(query3.Rows[0]["c_id"])});");
                        DataTable query4 = conexao.RetornaSQL($"SELECT cb_id FROM conta_bancaria WHERE cb_id_cliente = {query3.Rows[0]["c_id"]};");
                        conexao.ExecutaSQL($"INSERT INTO conta_corrente (cc_id_conta_bancaria,cc_nr_conta_corrente,cc_saldo) VALUES ({Convert.ToInt32(query4.Rows[0]["cb_id"])},{cc.cc_nr_conta_corrente},{cc.cc_saldo});");
                        DataTable query5 = conexao.RetornaSQL($"SELECT cc_id FROM conta_corrente WHERE cc_id_conta_bancaria = {Convert.ToInt32(query4.Rows[0]["cb_id"])};");
                        conexao.ExecutaSQL($"UPDATE conta_bancaria SET cb_id_conta_corrente = {Convert.ToInt32(query5.Rows[0]["cc_id"])} WHERE cb_id = {Convert.ToInt32(query4.Rows[0]["cb_id"])};");
                        //Add cadastro nas contas bancarias
                        LimparFormulario();
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    } else if (this.radioText == "Conta Poupança") {
                        ContaPoupanca cp = new ContaPoupanca();
                        cp = LeituraFormularioContaPoupanca();
                        cp.ValidaClasse();
                        cp.ValidaComplemento();
                        conexao.ExecutaSQL("INSERT INTO usuario (u_cpf,u_rg,u_nome,u_logradouro,u_complemento,u_bairro,u_cidade,u_estado,u_cep)VALUES('"+ Convert.ToString(cp.u_cpf) + "','" + Convert.ToString(cp.u_rg) + "','" + Convert.ToString(cp.u_nome) + "','" + Convert.ToString(cp.u_logradouro) + "','" + Convert.ToString(cp.u_complemento) + "','" + Convert.ToString(cp.u_bairro) + "','" + Convert.ToString(cp.u_cidade) + "','" + Convert.ToString(cp.u_estado) + "','" + Convert.ToString(cp.u_cep) + "');");
                        DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(cp.u_cpf)}';");
                        conexao.ExecutaSQL($"INSERT INTO contato (ctt_id_usuario,ctt_tel,ctt_cel,ctt_email) VALUES ({query.Rows[0]["u_id"]},'{Convert.ToString(cp.ctt_tel)}','{Convert.ToString(cp.ctt_cel)}','{Convert.ToString(cp.ctt_email)}');");
                        DataTable query2 = conexao.RetornaSQL($"SELECT ctt_id FROM contato WHERE ctt_id_usuario = {query.Rows[0]["u_id"]};");
                        conexao.ExecutaSQL($"UPDATE usuario SET u_ctt_id = {query2.Rows[0]["ctt_id"]} WHERE u_cpf = '{Convert.ToString(cp.u_cpf)}';");
                        conexao.ExecutaSQL($"INSERT INTO cliente (c_id_usuario, c_profissao) VALUES ({Convert.ToInt32(query.Rows[0]["u_id"])},'{Convert.ToString(cp.c_profissao)}');");
                        DataTable query3 = conexao.RetornaSQL($"SELECT c_id FROM cliente WHERE c_id_usuario = {query.Rows[0]["u_id"]};");
                        conexao.ExecutaSQL($"UPDATE usuario SET u_id_cliente = {query3.Rows[0]["c_id"]} WHERE u_id = {Convert.ToInt32(query.Rows[0]["u_id"])};");
                        conexao.ExecutaSQL($"INSERT INTO conta_bancaria (cb_agencia, cb_id_cliente) VALUES ({cp.cb_agencia},{Convert.ToInt32(query3.Rows[0]["c_id"])});");
                        DataTable query4 = conexao.RetornaSQL($"SELECT cb_id FROM conta_bancaria WHERE cb_id_cliente = {query3.Rows[0]["c_id"]};");
                        conexao.ExecutaSQL($"INSERT INTO conta_poupanca (cp_id_conta_bancaria,cp_nr_conta_poupanca,cp_valor) VALUES ({Convert.ToInt32(query4.Rows[0]["cb_id"])},{cp.cp_nr_conta_poupanca},{cp.cp_saldo});");
                        DataTable query5 = conexao.RetornaSQL($"SELECT cp_id FROM conta_poupanca WHERE cp_id_conta_bancaria = {Convert.ToInt32(query4.Rows[0]["cb_id"])};");
                        conexao.ExecutaSQL($"UPDATE conta_bancaria SET cb_id_conta_poupanca = {Convert.ToInt32(query5.Rows[0]["cp_id"])} WHERE cb_id = {Convert.ToInt32(query4.Rows[0]["cb_id"])};");
                        //Add cadastro nas contas bancarias
                        LimparFormulario();
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
               
                } catch (Exception a) {
                    MessageBox.Show(a.Message);
                }
                AcessoCliente_Load(sender, e);
            }
        }

        private void Excluir_Click(object sender, EventArgs e) {
            try {
                DataTable query = conexao.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf = {Convert.ToString(Txt_Excluir.Text)}");
                conexao.ExecutaSQL($"DELETE FROM usuario WHERE u_id = {query.Rows[0]["u_id"]};");
                AcessoCliente_Load(sender, e);
            } catch (Exception b) {
                MessageBox.Show(b.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
            LimparFormulario();

            Txt_Nome.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            Txt_CPF.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            Txt_Rg.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            Txt_CEP.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            Txt_Logradouro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            Txt_Complemento.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
            Txt_Cidade.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[6].Value);
            Txt_Bairro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[7].Value);
            Txt_Estado.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[8].Value);
            Txt_Telefone.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[9].Value);
            Txt_Celular.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            Txt_Email.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[11].Value);
            Txt_Profissao.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[12].Value);
            Txt_NumeroAgencia.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[13].Value);
            Txt_NumeroConta.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[14].Value);
            Txt_Saldo.Text = "R$ " + Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[15].Value);
        }

        private void Rdb_ContaPoupanca_CheckedChanged(object sender, EventArgs e) {
            LimparFormulario();
            AcessoCliente_Load(sender, e);
        }

        private void Rdb_ContaCorrente_CheckedChanged(object sender, EventArgs e) {
            LimparFormulario();
            AcessoCliente_Load(sender, e);
        }
    }
}
