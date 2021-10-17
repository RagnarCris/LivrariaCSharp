using System;
using LivrariaCSharp.controller;
using LivrariaCSharp.model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaCSharp
{
    public partial class FormAcervo : Form
    {
        public FormAcervo()
        {
            InitializeComponent();
            this.Text = "Controle de Acervos";
            txtId.Enabled = false;
            estadoControles(true);
            cbxEditora.DataSource = new EditoraDAO().listar();
            cbxEditora.ValueMember = "id";
            cbxEditora.DisplayMember = "nome";
            cbxEditora.SelectedIndex = 0;
            configurarTabela();
            preencherTabela(new AcervoDAO().listar());
        }

        private void estadoControles(bool e)
        {
            btnNovo.Enabled = e;
            btnEditar.Enabled = e;
            btnSalvar.Enabled = !e;

            btnCancelar.Enabled = !e;
            btnPesquisar.Enabled = e;
            txtAutor.Enabled = !e;
            txtTitulo.Enabled = !e;
            cbxEditora.Enabled = !e;
            txtAno.Enabled = !e;
            txtPreco.Enabled = !e;
            txtQuantidade.Enabled = !e;
            txtTipo.Enabled = !e;
            txtPesquisar.Enabled = e;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            estadoControles(false);
            txtId.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            cbxEditora.SelectedIndex = 0;
            txtAno.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                estadoControles(false);
            }
            else
            {
                MessageBox.Show("Selecione o acervo que deseja editar.");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            estadoControles(true);
            Acervo p = new Acervo();
            if (txtId.Text != string.Empty)
            {
                p.Id = int.Parse(txtId.Text);
            }
            p.Titulo = txtTitulo.Text;
            p.Autor = txtAutor.Text;
            p.Id_editora = ((Editora)cbxEditora.SelectedItem).Id;
            p.Preco = double.Parse(txtPreco.Text);
            p.Quantidade = int.Parse(txtQuantidade.Text);
            p.Ano = int.Parse(txtAno.Text);
            p.Tipo = int.Parse(txtTipo.Text);
            int res = -1;
            if (p.Id == 0)
            {
                res = new AcervoDAO().inserir(p);
                txtId.Text = res.ToString();
            }
            else
            {
                res = new AcervoDAO().atualizar(p);
            }

            if (res > 0)
            {
                MessageBox.Show("Operação realizada com sucesso!.");
                preencherTabela(new AcervoDAO().listar());
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a operação.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoControles(true);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;
            if (linha >= 0 && btnNovo.Enabled)
            {
                txtId.Text = grid.Rows[linha].Cells[0].Value.ToString();
                txtTitulo.Text = grid.Rows[linha].Cells[1].Value.ToString();
                txtAutor.Text = grid.Rows[linha].Cells[2].Value.ToString();
                cbxEditora.SelectedItem = grid.Rows[linha].Cells[3].Value;
                txtPreco.Text = grid.Rows[linha].Cells[4].Value.ToString();
                txtQuantidade.Text = grid.Rows[linha].Cells[5].Value.ToString();
                txtAno.Text = grid.Rows[linha].Cells[6].Value.ToString();
                txtTipo.Text = grid.Rows[linha].Cells[7].Value.ToString();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if
            (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                preencherTabela(new AcervoDAO().listar());
            }
            else
            {
                preencherTabela(new AcervoDAO().pesquisarPorTitulo(txtPesquisar.Text));
            }
        }

        private void configurarTabela()
        {
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("titulo", "Titulo");
            grid.Columns.Add("autor", "Autor");
            grid.Columns.Add("editora", "Editora");
            grid.Columns.Add("preco", "Preco");
            grid.Columns.Add("quantidade", "Qtde.");
            grid.Columns.Add("ano", "Ano");
            grid.Columns.Add("tipo", "Tipo");
            grid.Columns[0].Width = 30;
            grid.Columns[1].Width = 200;
            grid.Columns[2].Width = 100;
            grid.Columns[3].Width = 70;
            grid.Columns[4].Width = 40;
            grid.Columns[5].Width = 40;
            grid.Columns[6].Width = 40;
            grid.Columns[7].Width = 30;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
        }
        private void preencherTabela(List<Acervo> lista)
        {
            if (lista.Count > 0)
            {
                grid.Rows.Clear();
                foreach (Acervo p in lista)
                {
                    cbxEditora.SelectedValue = p.Id_editora;
                    grid.Rows.Add(new object[] { p.Id, p.Titulo, p.Autor, cbxEditora.SelectedItem, p.Preco, p.Quantidade, p.Ano, p.Tipo });
                }
                cbxEditora.SelectedIndex = 0;
            }
        }
    }
}
