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
    public partial class formCadastroProd : Form
    {        
        private IDatabase db1 = new Database();
        private Produto nProduto = new Produto();
        
        public formCadastroProd()
        {
            InitializeComponent();            
            btComplete();
            iniComboBox();
        }

        private void iniComboBox()
        {
            List<Fornecedor> produto = db1.ListAllF();
            cbFornecedor.DataSource = produto;
            foreach (Fornecedor p in produto)
            {
                cbFornecedor.DisplayMember = "nome";
                cbFornecedor.ValueMember = "id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btComplete()
        {
            if (txNome.Text.Trim() == "" || txPreco.Text.Trim() == "" || txQntd.Text.Trim() == "")
                btCadastrar.Enabled = false;
            else
                btCadastrar.Enabled = true;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            nProduto.Nome = txNome.Text;
            nProduto.Preco = double.Parse(txPreco.Text);
                
            nProduto.Qntd = int.Parse(txQntd.Text);
            btComplete();
            if (btCadastrar.Text != "Salvar")
            {
               db1.Adicionar(nProduto);                    
            }
            else if (btCadastrar.Text == "Salvar")
            {
                nProduto.Id = int.Parse(lbIdProduto.Text);
                db1.Atualizar(nProduto);
            }

            this.Dispose();           
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }

        private void txPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((Char.IsLetter(e.KeyChar)))
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',')   //Se o usuario inserir uma virgula
                if (txPreco.Text.Contains(",") || txPreco.Text.Equals(""))//Checa se o usuario ja inseriu uma virgula previamente
                    e.Handled = true; // Caso ja exista uma virgula, outra não será aceita
            
        }
    }
}
