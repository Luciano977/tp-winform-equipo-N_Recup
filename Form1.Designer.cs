namespace TPWinForm_EquipoN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSistGest = new System.Windows.Forms.Label();
            this.lbMenuPrincipal = new System.Windows.Forms.Label();
            this.btArticulos = new System.Windows.Forms.Button();
            this.btMarcas = new System.Windows.Forms.Button();
            this.btCategorias = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSistGest
            // 
            this.lbSistGest.AutoSize = true;
            this.lbSistGest.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSistGest.Location = new System.Drawing.Point(247, 39);
            this.lbSistGest.Name = "lbSistGest";
            this.lbSistGest.Size = new System.Drawing.Size(286, 37);
            this.lbSistGest.TabIndex = 0;
            this.lbSistGest.Text = "Sistema de Gestion";
            // 
            // lbMenuPrincipal
            // 
            this.lbMenuPrincipal.AutoSize = true;
            this.lbMenuPrincipal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuPrincipal.Location = new System.Drawing.Point(311, 105);
            this.lbMenuPrincipal.Name = "lbMenuPrincipal";
            this.lbMenuPrincipal.Size = new System.Drawing.Size(164, 27);
            this.lbMenuPrincipal.TabIndex = 1;
            this.lbMenuPrincipal.Text = "Menu Principal";
            // 
            // btArticulos
            // 
            this.btArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArticulos.Location = new System.Drawing.Point(85, 193);
            this.btArticulos.Name = "btArticulos";
            this.btArticulos.Size = new System.Drawing.Size(150, 72);
            this.btArticulos.TabIndex = 2;
            this.btArticulos.Text = "Articulos";
            this.btArticulos.UseVisualStyleBackColor = true;
            this.btArticulos.Click += new System.EventHandler(this.btArticulos_Click);
            // 
            // btMarcas
            // 
            this.btMarcas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcas.Location = new System.Drawing.Point(316, 193);
            this.btMarcas.Name = "btMarcas";
            this.btMarcas.Size = new System.Drawing.Size(150, 65);
            this.btMarcas.TabIndex = 3;
            this.btMarcas.Text = "Marcas";
            this.btMarcas.UseVisualStyleBackColor = true;
            this.btMarcas.Click += new System.EventHandler(this.btMarcas_Click);
            // 
            // btCategorias
            // 
            this.btCategorias.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCategorias.Location = new System.Drawing.Point(585, 193);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(150, 65);
            this.btCategorias.TabIndex = 4;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = true;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(625, 369);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(110, 39);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 449);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.btMarcas);
            this.Controls.Add(this.btArticulos);
            this.Controls.Add(this.lbMenuPrincipal);
            this.Controls.Add(this.lbSistGest);
            this.MinimumSize = new System.Drawing.Size(820, 496);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSistGest;
        private System.Windows.Forms.Label lbMenuPrincipal;
        private System.Windows.Forms.Button btArticulos;
        private System.Windows.Forms.Button btMarcas;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Button btSalir;
    }
}

