﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlX
{
    public partial class FormAgendarCompra : Form
    {

        static IDao db = new DAO.ProdutoDao();
        static List<Object> ps = db.ListAll();
        private ComprarDao cd = new ComprarDao();
        double qntdEstoque;

        public FormAgendarCompra()
        {
            //int idCompra = cd.GetId();
            InitializeComponent();
            lbNumCompra.Text = "Pedido de Compra N° " + cd.GetId();
            dtEntrega.MinDate = DateTime.Today;
            Auto_Complete();
            BtComplete();
        }

        private void BtComplete()
        {
            if (dgvItensCompra.RowCount <= 0)
            {
                btDelItemCompra.Enabled = false;
                btRemoverTudo.Enabled = false;
                btComprar.Enabled = false;
            }
            else
            {
                btDelItemCompra.Enabled = true;
                btRemoverTudo.Enabled = true;
                btComprar.Enabled = true;
            }
            if (txId.Text == "" || txNome.Text == "" || txQntdCompra.Text == "" || txPrecoCompra.Text == "")
                btAdd.Enabled = false;
            else
                btAdd.Enabled = true;
        }

        private void Auto_Complete()
        {
            txNome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            //Adiciona sugestão de nomes ao digitar no TextBox
            foreach (Produto p in ps)
            {
                col.Add(p.Nome);
            }

            txNome.AutoCompleteCustomSource = col;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            double qtdCompra = double.Parse(txQntdCompra.Text); //Quantidade que sera comprada
            double precoCompra = double.Parse(txPrecoCompra.Text);
            int idProd = int.Parse(txId.Text);//Id do produto a ser adicionado a venda

            foreach (Produto p in ps)
            {
                if (p.Id == idProd)
                {
                    //Preço da compra (QTD * PREÇO UNITARIO)
                    double precoCompraTotal = qtdCompra * precoCompra;
                    //Adicionando ao Data Grid View
                    dgvItensCompra.Rows.Add(p.Id, p.Nome, qtdCompra, p.TipoUn, precoCompra, precoCompraTotal);
                    //Valor Total Recebe o valor ja existente, caso esteja NULL, recebe 0
                    double vTotal = lbValorShow.Text == "" ? 0 : double.Parse(lbValorShow.Text);
                    //O Label com o Valor Total recebe ele mesmo, mais o Preço de Venda do item em questão
                    lbValorShow.Text = Convert.ToString(vTotal + precoCompraTotal);

                    Limpar();
                    BtComplete();

                }
            }
        }

        private void Limpar()
        {
            txNome.Text = "";
            txId.Text = "";
            lbPrecoShow.Text = "";
            lbQntdEstoqueShow.Text = "";
            txPrecoCompra.Text = "";
            txQntdCompra.Text = "";

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txQntdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',')   //Se o usuario inserir uma virgula
                if (txQntdCompra.Text.Contains(",") || txQntdCompra.Text.Equals(""))//Checa se o usuario ja inseriu uma virgula previamente
                    e.Handled = true; // Caso ja exista uma virgula, outra não será aceita 
        }

        private void txPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',')   //Se o usuario inserir uma virgula
                if (txPrecoCompra.Text.Contains(",") || txPrecoCompra.Text.Equals(""))//Checa se o usuario ja inseriu uma virgula previamente
                    e.Handled = true; // Caso ja exista uma virgula, outra não será aceita 
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            foreach (Produto p in ps)
                if (txNome.Text.Trim() == p.Nome)
                {
                    txId.Text = Convert.ToString(p.Id);
                    lbPrecoShow.Text = Convert.ToString(p.Preco);
                    lbQntdEstoqueShow.Text = Convert.ToString(p.Qntd) + " " + p.TipoUn;
                    txQntdCompra.Text = "0";
                    qntdEstoque = p.Qntd;
                }
            BtComplete();
        }

        private void txQntdCompra_TextChanged(object sender, EventArgs e)
        {
            BtComplete();
        }

        private void btDelItemCompra_Click(object sender, EventArgs e)
        {
            if (dgvItensCompra.RowCount > 0)
            {
                int idProd = int.Parse(dgvItensCompra.Rows[dgvItensCompra.CurrentRow.Index].Cells[0].Value.ToString());
                double qntdProd = double.Parse(dgvItensCompra.Rows[dgvItensCompra.CurrentRow.Index].Cells[2].Value.ToString());
                double precoTotalProd = double.Parse(dgvItensCompra.Rows[dgvItensCompra.CurrentRow.Index].Cells[5].Value.ToString());
                double vTotal = double.Parse(lbValorShow.Text);

                foreach (Produto p in ps)
                {
                    if (p.Id == idProd)
                    {
                        lbValorShow.Text = Convert.ToString(vTotal - precoTotalProd);
                        dgvItensCompra.Rows.RemoveAt(dgvItensCompra.CurrentRow.Index);
                        BtComplete();
                        Limpar();
                    }
                }
            }
        }

        private void btRemoverTudo_Click(object sender, EventArgs e)
        {
            dgvItensCompra.Rows.Clear();
            ps = db.ListAll();
            Limpar();
            lbValorShow.Text = "";
            BtComplete();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            try
            {
                Comprar compra = new Comprar();
                for (int i = 0; i < dgvItensCompra.RowCount; i++)
                {
                    int idProduto = int.Parse(dgvItensCompra.Rows[dgvItensCompra.Rows[i].Index].Cells[0].Value.ToString());
                    foreach (Produto p in ps)
                    {
                        if (p.Id == idProduto)
                        {
                            //Na tabela compras, não importa a Quantidade no estoque e o preço de venda do produto
                            //No lugar, iremos salvar o preço unitario de compra e a quantidade comprada para no futuro
                            //Mostrar esses dados no histórico
                            p.Preco = double.Parse(dgvItensCompra.Rows[dgvItensCompra.Rows[i].Index].Cells[4].Value.ToString());
                            p.Qntd = double.Parse(dgvItensCompra.Rows[dgvItensCompra.Rows[i].Index].Cells[2].Value.ToString());
                            compra.Itens.Add(p);
                        }
                    }
                }
                compra.Id = cd.GetId();
                compra.Status = 0; //Compra não finalizada, produtos agendados !
                compra.Valor = double.Parse(lbValorShow.Text);
                compra.DataCompra = dtCompra.Value;
                compra.DataEntrega = dtEntrega.Value;
                MessageBox.Show("O Pedido de compra de número " + compra.Id + " foi agendado com sucesso !\nVerifique em 'Compras Agendadas' e finalize a compra quando ela for entregue!", "Compra Agendada com Sucesso!");
                cd.Adicionar(compra);
                this.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show("ERRO:" + x,"Compra não agendada!");
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            formEstoque formSearch = new formEstoque();
            formSearch.pnButtons.Visible = false;
            formSearch.btMenu.Text = "Voltar";
            formSearch.ShowDialog(this);
        }
    }
}