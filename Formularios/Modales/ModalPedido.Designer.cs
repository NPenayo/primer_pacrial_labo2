namespace Formularios.Modales
{
    partial class ModalPedido
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lvInventario = new System.Windows.Forms.ListView();
            this.idInventario = new System.Windows.Forms.ColumnHeader();
            this.nombreInventario = new System.Windows.Forms.ColumnHeader();
            this.precioInventario = new System.Windows.Forms.ColumnHeader();
            this.lvPedido = new System.Windows.Forms.ListView();
            this.idPedido = new System.Windows.Forms.ColumnHeader();
            this.nombrePedido = new System.Windows.Forms.ColumnHeader();
            this.cantidadPedido = new System.Windows.Forms.ColumnHeader();
            this.precioPedido = new System.Windows.Forms.ColumnHeader();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.btnAceptar.Location = new System.Drawing.Point(485, 459);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 40);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.btnCancelar.Location = new System.Drawing.Point(661, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lvInventario
            // 
            this.lvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idInventario,
            this.nombreInventario,
            this.precioInventario});
            this.lvInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvInventario.HideSelection = false;
            this.lvInventario.Location = new System.Drawing.Point(12, 49);
            this.lvInventario.Name = "lvInventario";
            this.lvInventario.Size = new System.Drawing.Size(301, 379);
            this.lvInventario.TabIndex = 12;
            this.lvInventario.UseCompatibleStateImageBehavior = false;
            this.lvInventario.View = System.Windows.Forms.View.Details;
            this.lvInventario.DoubleClick += new System.EventHandler(this.lvInventario_DoubleClick);
            // 
            // idInventario
            // 
            this.idInventario.Text = "ID";
            // 
            // nombreInventario
            // 
            this.nombreInventario.Text = "Nombre";
            this.nombreInventario.Width = 180;
            // 
            // precioInventario
            // 
            this.precioInventario.Text = "Precio";
            // 
            // lvPedido
            // 
            this.lvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPedido,
            this.nombrePedido,
            this.cantidadPedido,
            this.precioPedido});
            this.lvPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(424, 49);
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(382, 379);
            this.lvPedido.TabIndex = 13;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            this.lvPedido.View = System.Windows.Forms.View.Details;
            this.lvPedido.DoubleClick += new System.EventHandler(this.lvPedido_DoubleClick);
            // 
            // idPedido
            // 
            this.idPedido.Text = "ID";
            // 
            // nombrePedido
            // 
            this.nombrePedido.Text = "Nombre";
            this.nombrePedido.Width = 180;
            // 
            // cantidadPedido
            // 
            this.cantidadPedido.Text = "Cantidad";
            this.cantidadPedido.Width = 80;
            // 
            // precioPedido
            // 
            this.precioPedido.Text = "Precio";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.ForeColor = System.Drawing.Color.White;
            this.lblInventario.Location = new System.Drawing.Point(12, 9);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(94, 18);
            this.lblInventario.TabIndex = 16;
            this.lblInventario.Text = "INVENTARIO";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.ForeColor = System.Drawing.Color.White;
            this.lblPedido.Location = new System.Drawing.Point(505, 9);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(60, 18);
            this.lblPedido.TabIndex = 17;
            this.lblPedido.Text = "PEDIDO";
            // 
            // ModalPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(818, 531);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lvPedido);
            this.Controls.Add(this.lvInventario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModalPedido";
            this.Text = "ModalAgregarPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvInventario;
        private System.Windows.Forms.ListView lvPedido;
        private System.Windows.Forms.ColumnHeader idPedido;
        private System.Windows.Forms.ColumnHeader nombrePedido;
        private System.Windows.Forms.ColumnHeader precioPedido;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.ColumnHeader idInventario;
        private System.Windows.Forms.ColumnHeader nombreInventario;
        private System.Windows.Forms.ColumnHeader precioInventario;
        private System.Windows.Forms.ColumnHeader cantidadPedido;
    }
}