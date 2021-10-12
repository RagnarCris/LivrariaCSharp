
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
            this.Novo = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Novo
            // 
            this.Novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Novo.BackgroundImage")));
            this.Novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Novo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Novo.Location = new System.Drawing.Point(64, 26);
            this.Novo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(84, 105);
            this.Novo.TabIndex = 0;
            this.Novo.Text = "Novo";
            this.Novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Editar
            // 
            this.Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Editar.BackgroundImage")));
            this.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Editar.Location = new System.Drawing.Point(205, 26);
            this.Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(84, 105);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salvar.BackgroundImage")));
            this.Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salvar.Location = new System.Drawing.Point(335, 26);
            this.Salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(84, 105);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "Salvar";
            this.Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelar.BackgroundImage")));
            this.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cancelar.Location = new System.Drawing.Point(473, 26);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(84, 105);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FormAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(924, 702);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Novo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAcervo";
            this.Text = "FormAcervo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Editar;
    }
}

