﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Produto
    {
        private string nome;
        private int id;
        private double preco;
        Fornecedor fornecedor = new Fornecedor();

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        internal Fornecedor Fornecedor
        {
            get
            {
                return fornecedor;
            }

            set
            {
                fornecedor = value;
            }
        }

        public Produto(string nome, int id, double preco, Fornecedor fornecedor)
        {
            this.Nome = nome;
            this.Id = id;
            this.Preco = preco;
            this.Fornecedor = fornecedor;
        }
        public Produto()
        {

        }
    }
}
