namespace taller4._3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnir = new System.Windows.Forms.Button();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite su nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(196, 26);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(223, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(443, 26);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(63, 23);
            this.btnir.TabIndex = 2;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.Btnir_Click_1);
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contador,
            this.nombre});
            this.dgvlista.Location = new System.Drawing.Point(163, 62);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(273, 259);
            this.dgvlista.TabIndex = 3;
            // 
            // contador
            // 
            this.contador.HeaderText = "#";
            this.contador.Name = "contador";
            this.contador.Width = 40;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 333);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}

