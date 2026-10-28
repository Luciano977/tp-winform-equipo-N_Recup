namespace TPWinForm_EquipoN
{
    partial class ArtListar
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
            this.lbListadoArt = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btSalir = new System.Windows.Forms.Button();
            this.pxbArticulos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListadoArt
            // 
            this.lbListadoArt.AutoSize = true;
            this.lbListadoArt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListadoArt.Location = new System.Drawing.Point(63, 36);
            this.lbListadoArt.Name = "lbListadoArt";
            this.lbListadoArt.Size = new System.Drawing.Size(295, 37);
            this.lbListadoArt.TabIndex = 0;
            this.lbListadoArt.Text = "Listado de Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(70, 96);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(880, 246);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(1115, 377);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(140, 40);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pxbArticulos
            // 
            this.pxbArticulos.Location = new System.Drawing.Point(984, 95);
            this.pxbArticulos.Name = "pxbArticulos";
            this.pxbArticulos.Size = new System.Drawing.Size(261, 247);
            this.pxbArticulos.TabIndex = 3;
            this.pxbArticulos.TabStop = false;
            // 
            // ArtListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.pxbArticulos);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lbListadoArt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Articulos";
            this.Load += new System.EventHandler(this.MenuMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListadoArt;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.PictureBox pxbArticulos;
    }
}