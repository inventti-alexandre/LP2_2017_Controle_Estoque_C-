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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formCadastroProd().ShowDialog(this);
        }

        private void Fill()
        {
            IDatabase db = new Database();
            List<Produto> ps = db.ListAll();

            dgvEstoque.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco);
            }
        
        
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            Fill();
        }
    }
}
