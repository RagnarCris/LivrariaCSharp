
namespace LivrariaCSharp
{
    partial class FormAcervo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcervo));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cbxEditora = new System.Windows.Forms.ComboBox();
            this.labelEditora = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(64, 26);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 105);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(205, 26);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 105);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(335, 26);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 105);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(473, 26);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 105);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.Location = new System.Drawing.Point(16, 168);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 4;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(16, 145);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 17);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Id";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(134, 145);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(42, 17);
            this.labelAutor.TabIndex = 7;
            this.labelAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAutor.Location = new System.Drawing.Point(134, 168);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(745, 22);
            this.txtAutor.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(16, 202);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 17);
            this.labelTitulo.TabIndex = 9;
            this.labelTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitulo.Location = new System.Drawing.Point(16, 225);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(863, 22);
            this.txtTitulo.TabIndex = 8;
            // 
            // cbxEditora
            // 
            this.cbxEditora.BackColor = System.Drawing.SystemColors.Menu;
            this.cbxEditora.FormattingEnabled = true;
            this.cbxEditora.Location = new System.Drawing.Point(16, 276);
            this.cbxEditora.Name = "cbxEditora";
            this.cbxEditora.Size = new System.Drawing.Size(173, 24);
            this.cbxEditora.TabIndex = 10;
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(16, 256);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(53, 17);
            this.labelEditora.TabIndex = 11;
            this.labelEditora.Text = "Editora";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(587, 255);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(36, 17);
            this.labelTipo.TabIndex = 13;
            this.labelTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTipo.Location = new System.Drawing.Point(587, 278);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 12;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(468, 255);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(82, 17);
            this.labelQuantidade.TabIndex = 15;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQuantidade.Location = new System.Drawing.Point(468, 278);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 14;
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(228, 255);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(33, 17);
            this.labelAno.TabIndex = 19;
            this.labelAno.Text = "Ano";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAno.Location = new System.Drawing.Point(228, 278);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 22);
            this.txtAno.TabIndex = 18;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(347, 255);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(45, 17);
            this.labelPreco.TabIndex = 21;
            this.labelPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPreco.Location = new System.Drawing.Point(347, 278);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 22);
            this.txtPreco.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPesquisar.Location = new System.Drawing.Point(88, 320);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(745, 22);
            this.txtPesquisar.TabIndex = 22;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Location = new System.Drawing.Point(839, 315);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 32);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(10, 367);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(902, 323);
            this.grid.TabIndex = 25;
            // 
            // FormAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(924, 702);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.cbxEditora);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAcervo";
            this.Text = "FormAcervo";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbxEditora;
        private System.Windows.Forms.Label labelEditora;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView grid;
    }
}

