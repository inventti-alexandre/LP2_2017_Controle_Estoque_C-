﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    interface IDatabase
    {
        void Adicionar(Produto p);

        void Atualizar(Produto p);

        Produto Ler(int idProduto);

        void Remover(int idProduto);

        List<Produto> ListAll();

        List<Produto> ListByName(string name);
    }
}