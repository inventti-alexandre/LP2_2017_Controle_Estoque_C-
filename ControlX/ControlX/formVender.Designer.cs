﻿namespace ControlX
{
    partial class FormVender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVender));
            this.pnForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDelItemVenda = new System.Windows.Forms.Button();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.txQntdVenda = new System.Windows.Forms.TextBox();
            this.lbPrecoShow = new System.Windows.Forms.Label();
            this.lbQntdEstoqueShow = new System.Windows.Forms.Label();
            this.lbQntdVenda = new System.Windows.Forms.Label();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbQntdEstoque = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbReais = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gpVendas = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btMenu = new System.Windows.Forms.Button();
            this.pnBtVender = new System.Windows.Forms.Panel();
            this.btVender = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pnForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnCabecalho.SuspendLayout();
            this.pnBtCad.SuspendLayout();
            this.pnTotal.SuspendLayout();
            this.gpVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pnBtVender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnForm.Controls.Add(this.panel1);
            this.pnForm.Controls.Add(this.pnCabecalho);
            this.pnForm.Controls.Add(this.pnTotal);
            this.pnForm.Controls.Add(this.gpVendas);
            this.pnForm.Controls.Add(this.pnMenu);
            this.pnForm.Controls.Add(this.pnBtVender);
            this.pnForm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnForm.Location = new System.Drawing.Point(12, 8);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(423, 405);
            this.pnForm.TabIndex = 8;
            this.pnForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnForm_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDelItemVenda);
            this.panel1.Location = new System.Drawing.Point(331, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 26);
            this.panel1.TabIndex = 17;
            // 
            // btDelItemVenda
            // 
            this.btDelItemVenda.Location = new System.Drawing.Point(0, 3);
            this.btDelItemVenda.Name = "btDelItemVenda";
            this.btDelItemVenda.Size = new System.Drawing.Size(75, 23);
            this.btDelItemVenda.TabIndex = 0;
            this.btDelItemVenda.Text = "Remover";
            this.btDelItemVenda.UseVisualStyleBackColor = true;
            this.btDelItemVenda.Click += new System.EventHandler(this.btDelItemVenda_Click);
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCabecalho.Controls.Add(this.txQntdVenda);
            this.pnCabecalho.Controls.Add(this.lbPrecoShow);
            this.pnCabecalho.Controls.Add(this.lbQntdEstoqueShow);
            this.pnCabecalho.Controls.Add(this.lbQntdVenda);
            this.pnCabecalho.Controls.Add(this.pnBtCad);
            this.pnCabecalho.Controls.Add(this.txId);
            this.pnCabecalho.Controls.Add(this.lbId);
            this.pnCabecalho.Controls.Add(this.txNome);
            this.pnCabecalho.Controls.Add(this.lbNome);
            this.pnCabecalho.Controls.Add(this.lbQntdEstoque);
            this.pnCabecalho.Controls.Add(this.lbPreco);
            this.pnCabecalho.Location = new System.Drawing.Point(8, 9);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(406, 120);
            this.pnCabecalho.TabIndex = 16;
            // 
            // txQntdVenda
            // 
            this.txQntdVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txQntdVenda.Location = new System.Drawing.Point(345, 53);
            this.txQntdVenda.Name = "txQntdVenda";
            this.txQntdVenda.Size = new System.Drawing.Size(53, 21);
            this.txQntdVenda.TabIndex = 32;
            this.txQntdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txQntdVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQntdVenda_KeyPress);
            // 
            // lbPrecoShow
            // 
            this.lbPrecoShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPrecoShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrecoShow.Location = new System.Drawing.Point(56, 53);
            this.lbPrecoShow.Name = "lbPrecoShow";
            this.lbPrecoShow.Size = new System.Drawing.Size(70, 21);
            this.lbPrecoShow.TabIndex = 31;
            this.lbPrecoShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQntdEstoqueShow
            // 
            this.lbQntdEstoqueShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbQntdEstoqueShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQntdEstoqueShow.Location = new System.Drawing.Point(219, 53);
            this.lbQntdEstoqueShow.Name = "lbQntdEstoqueShow";
            this.lbQntdEstoqueShow.Size = new System.Drawing.Size(50, 21);
            this.lbQntdEstoqueShow.TabIndex = 30;
            this.lbQntdEstoqueShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQntdVenda
            // 
            this.lbQntdVenda.AutoSize = true;
            this.lbQntdVenda.Location = new System.Drawing.Point(275, 57);
            this.lbQntdVenda.Name = "lbQntdVenda";
            this.lbQntdVenda.Size = new System.Drawing.Size(72, 13);
            this.lbQntdVenda.TabIndex = 29;
            this.lbQntdVenda.Text = "Qtd Venda:";
            // 
            // pnBtCad
            // 
            this.pnBtCad.Controls.Add(this.btPesquisar);
            this.pnBtCad.Controls.Add(this.btLimpar);
            this.pnBtCad.Controls.Add(this.btAdd);
            this.pnBtCad.Location = new System.Drawing.Point(88, 87);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(249, 28);
            this.pnBtCad.TabIndex = 28;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.BackgroundImage = global::ControlX.Properties.Resources.search;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Help;
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(214, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(23, 22);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(5, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(87, 23);
            this.btLimpar.TabIndex = 0;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(110, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(332, 13);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(66, 21);
            this.txId.TabIndex = 1;
            this.txId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txId_KeyPress);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(300, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 26;
            this.lbId.Text = "ID:";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // txNome
            // 
            this.txNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(46, 13);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(235, 21);
            this.txNome.TabIndex = 0;
            this.txNome.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(4, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 25;
            this.lbNome.Text = "Nome:";
            // 
            // lbQntdEstoque
            // 
            this.lbQntdEstoque.AutoSize = true;
            this.lbQntdEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQntdEstoque.Location = new System.Drawing.Point(132, 55);
            this.lbQntdEstoque.Name = "lbQntdEstoque";
            this.lbQntdEstoque.Size = new System.Drawing.Size(81, 13);
            this.lbQntdEstoque.TabIndex = 23;
            this.lbQntdEstoque.Text = "Qtd Estoque:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(4, 55);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(44, 13);
            this.lbPreco.TabIndex = 22;
            this.lbPreco.Text = "Preço:";
            // 
            // pnTotal
            // 
            this.pnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTotal.Controls.Add(this.lbReais);
            this.pnTotal.Controls.Add(this.lbValorTotal);
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(18, 341);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(171, 26);
            this.pnTotal.TabIndex = 15;
            // 
            // lbReais
            // 
            this.lbReais.Location = new System.Drawing.Point(43, 1);
            this.lbReais.Name = "lbReais";
            this.lbReais.Size = new System.Drawing.Size(27, 21);
            this.lbReais.TabIndex = 16;
            this.lbReais.Text = "R$";
            this.lbReais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lbValorTotal.Location = new System.Drawing.Point(71, 2);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(90, 21);
            this.lbValorTotal.TabIndex = 15;
            this.lbValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(3, 5);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 13);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "Total:";
            // 
            // gpVendas
            // 
            this.gpVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpVendas.Controls.Add(this.dgvVendas);
            this.gpVendas.Location = new System.Drawing.Point(11, 135);
            this.gpVendas.Name = "gpVendas";
            this.gpVendas.Size = new System.Drawing.Size(403, 200);
            this.gpVendas.TabIndex = 14;
            this.gpVendas.TabStop = false;
            this.gpVendas.Text = "Produtos da venda";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.coLPreco});
            this.dgvVendas.Location = new System.Drawing.Point(5, 19);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(391, 175);
            this.dgvVendas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 45F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 20F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Qtd.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // coLPreco
            // 
            this.coLPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.coLPreco.DefaultCellStyle = dataGridViewCellStyle2;
            this.coLPreco.FillWeight = 30F;
            this.coLPreco.HeaderText = "Preço Total";
            this.coLPreco.Name = "coLPreco";
            this.coLPreco.ReadOnly = true;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.Controls.Add(this.btMenu);
            this.pnMenu.Location = new System.Drawing.Point(16, 371);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(98, 29);
            this.pnMenu.TabIndex = 11;
            // 
            // btMenu
            // 
            this.btMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(5, 3);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(70, 23);
            this.btMenu.TabIndex = 0;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // pnBtVender
            // 
            this.pnBtVender.Controls.Add(this.btVender);
            this.pnBtVender.Controls.Add(this.btCancelar);
            this.pnBtVender.Location = new System.Drawing.Point(207, 371);
            this.pnBtVender.Name = "pnBtVender";
            this.pnBtVender.Size = new System.Drawing.Size(207, 29);
            this.pnBtVender.TabIndex = 10;
            // 
            // btVender
            // 
            this.btVender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVender.Location = new System.Drawing.Point(124, 3);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(75, 23);
            this.btVender.TabIndex = 1;
            this.btVender.Text = "Finalizar";
            this.btVender.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(104, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Limpar Venda";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 425);
            this.Controls.Add(this.pnForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVender";
            this.Text = "ControlX - Vendas";
            this.pnForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnBtCad.ResumeLayout(false);
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.gpVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnBtVender.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Panel pnBtVender;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox gpVendas;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.Label lbQntdEstoque;
        private System.Windows.Forms.Label lbPreco;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnBtCad;
        public System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDelItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLPreco;
        private System.Windows.Forms.Label lbQntdVenda;
        private System.Windows.Forms.Label lbQntdEstoqueShow;
        private System.Windows.Forms.TextBox txQntdVenda;
        private System.Windows.Forms.Label lbPrecoShow;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.Label lbReais;
    }
}