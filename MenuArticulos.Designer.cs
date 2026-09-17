namespace TPWinForm_EquipoN
{
    partial class MenuArticulos
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
            this.lbMenuArticulos = new System.Windows.Forms.Label();
            this.btListArt = new System.Windows.Forms.Button();
            this.btBusqArt = new System.Windows.Forms.Button();
            this.btAgregarArticulos = new System.Windows.Forms.Button();
            this.btModArt = new System.Windows.Forms.Button();
            this.btEliminarArt = new System.Windows.Forms.Button();
            this.btDetArt = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMenuArticulos
            // 
            this.lbMenuArticulos.AutoSize = true;
            this.lbMenuArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuArticulos.Location = new System.Drawing.Point(253, 25);
            this.lbMenuArticulos.Name = "lbMenuArticulos";
            this.lbMenuArticulos.Size = new System.Drawing.Size(274, 37);
            this.lbMenuArticulos.TabIndex = 0;
            this.lbMenuArticulos.Text = "Menu de Articulos";
            // 
            // btListArt
            // 
            this.btListArt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListArt.Location = new System.Drawing.Point(121, 78);
            this.btListArt.Name = "btListArt";
            this.btListArt.Size = new System.Drawing.Size(210, 80);
            this.btListArt.TabIndex = 1;
            this.btListArt.Text = "Listar Articulos";
            this.btListArt.UseVisualStyleBackColor = true;
            // 
            // btBusqArt
            // 
            this.btBusqArt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusqArt.Location = new System.Drawing.Point(121, 190);
            this.btBusqArt.Name = "btBusqArt";
            this.btBusqArt.Size = new System.Drawing.Size(210, 80);
            this.btBusqArt.TabIndex = 2;
            this.btBusqArt.Text = "Busqueda de Articulos";
            this.btBusqArt.UseVisualStyleBackColor = true;
            // 
            // btAgregarArticulos
            // 
            this.btAgregarArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarArticulos.Location = new System.Drawing.Point(121, 307);
            this.btAgregarArticulos.Name = "btAgregarArticulos";
            this.btAgregarArticulos.Size = new System.Drawing.Size(210, 80);
            this.btAgregarArticulos.TabIndex = 3;
            this.btAgregarArticulos.Text = "Agregar Articulos";
            this.btAgregarArticulos.UseVisualStyleBackColor = true;
            // 
            // btModArt
            // 
            this.btModArt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModArt.Location = new System.Drawing.Point(486, 78);
            this.btModArt.Name = "btModArt";
            this.btModArt.Size = new System.Drawing.Size(210, 80);
            this.btModArt.TabIndex = 4;
            this.btModArt.Text = "Modificar Articulos";
            this.btModArt.UseVisualStyleBackColor = true;
            // 
            // btEliminarArt
            // 
            this.btEliminarArt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarArt.Location = new System.Drawing.Point(486, 190);
            this.btEliminarArt.Name = "btEliminarArt";
            this.btEliminarArt.Size = new System.Drawing.Size(210, 80);
            this.btEliminarArt.TabIndex = 5;
            this.btEliminarArt.Text = "Eliminar Articulos";
            this.btEliminarArt.UseVisualStyleBackColor = true;
            // 
            // btDetArt
            // 
            this.btDetArt.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetArt.Location = new System.Drawing.Point(486, 307);
            this.btDetArt.Name = "btDetArt";
            this.btDetArt.Size = new System.Drawing.Size(210, 80);
            this.btDetArt.TabIndex = 6;
            this.btDetArt.Text = "Detalles de Articulos";
            this.btDetArt.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(584, 429);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(112, 42);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MenuArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 483);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btDetArt);
            this.Controls.Add(this.btEliminarArt);
            this.Controls.Add(this.btModArt);
            this.Controls.Add(this.btAgregarArticulos);
            this.Controls.Add(this.btBusqArt);
            this.Controls.Add(this.btListArt);
            this.Controls.Add(this.lbMenuArticulos);
            this.Name = "MenuArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenuArticulos;
        private System.Windows.Forms.Button btListArt;
        private System.Windows.Forms.Button btBusqArt;
        private System.Windows.Forms.Button btAgregarArticulos;
        private System.Windows.Forms.Button btModArt;
        private System.Windows.Forms.Button btEliminarArt;
        private System.Windows.Forms.Button btDetArt;
        private System.Windows.Forms.Button btSalir;
    }
}