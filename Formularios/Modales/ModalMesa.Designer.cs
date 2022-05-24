namespace Formularios.Modales
{
    partial class ModalMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalMesa));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.idPedido = new System.Windows.Forms.ColumnHeader();
            this.idEmpeleado = new System.Windows.Forms.ColumnHeader();
            this.valorPedido = new System.Windows.Forms.ColumnHeader();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnAbrirMesa = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.lblParcial = new System.Windows.Forms.Label();
            this.cbEstacionamiento = new System.Windows.Forms.CheckBox();
            this.pbPagos = new System.Windows.Forms.PictureBox();
            this.pbEstacionamiento = new System.Windows.Forms.PictureBox();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstacionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(680, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.ForeColor = System.Drawing.Color.White;
            this.lblNroMesa.Location = new System.Drawing.Point(12, 29);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(86, 18);
            this.lblNroMesa.TabIndex = 5;
            this.lblNroMesa.Text = "Mesa Nro 1";
            // 
            // lvPedidos
            // 
            this.lvPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.lvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPedido,
            this.idEmpeleado,
            this.valorPedido});
            this.lvPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPedidos.HideSelection = false;
            this.lvPedidos.Location = new System.Drawing.Point(12, 130);
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(703, 144);
            this.lvPedidos.TabIndex = 6;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            this.lvPedidos.View = System.Windows.Forms.View.Details;
            this.lvPedidos.DoubleClick += new System.EventHandler(this.lvPedidos_DoubleClick);
            // 
            // idPedido
            // 
            this.idPedido.Text = "ID";
            this.idPedido.Width = 100;
            // 
            // idEmpeleado
            // 
            this.idEmpeleado.Text = "Empleado";
            this.idEmpeleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idEmpeleado.Width = 500;
            // 
            // valorPedido
            // 
            this.valorPedido.Text = "Valor";
            this.valorPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorPedido.Width = 100;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.ForeColor = System.Drawing.Color.Snow;
            this.lblPedidos.Location = new System.Drawing.Point(12, 94);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(70, 18);
            this.lblPedidos.TabIndex = 7;
            this.lblPedidos.Text = "Pedidos :";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.btnAgregarPedido.Location = new System.Drawing.Point(570, 72);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(145, 40);
            this.btnAgregarPedido.TabIndex = 8;
            this.btnAgregarPedido.Text = "NUEVO PEDIDO";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnAbrirMesa
            // 
            this.btnAbrirMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.btnAbrirMesa.Location = new System.Drawing.Point(12, 350);
            this.btnAbrirMesa.Name = "btnAbrirMesa";
            this.btnAbrirMesa.Size = new System.Drawing.Size(145, 40);
            this.btnAbrirMesa.TabIndex = 9;
            this.btnAbrirMesa.Text = "ABRIR MESA";
            this.btnAbrirMesa.UseVisualStyleBackColor = true;
            this.btnAbrirMesa.Click += new System.EventHandler(this.btnAbrirMesa_Click);
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.btnCerrarMesa.Location = new System.Drawing.Point(12, 350);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(145, 40);
            this.btnCerrarMesa.TabIndex = 10;
            this.btnCerrarMesa.Text = "CERRAR MESA";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnCerrarMesa_Click);
            // 
            // lblParcial
            // 
            this.lblParcial.ForeColor = System.Drawing.Color.Snow;
            this.lblParcial.Location = new System.Drawing.Point(532, 298);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(183, 29);
            this.lblParcial.TabIndex = 11;
            this.lblParcial.Text = "Gastado: $ 10581";
            this.lblParcial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEstacionamiento
            // 
            this.cbEstacionamiento.AutoSize = true;
            this.cbEstacionamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.cbEstacionamiento.Location = new System.Drawing.Point(574, 364);
            this.cbEstacionamiento.Name = "cbEstacionamiento";
            this.cbEstacionamiento.Size = new System.Drawing.Size(141, 22);
            this.cbEstacionamiento.TabIndex = 13;
            this.cbEstacionamiento.Text = "Estacionamiento";
            this.cbEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // pbPagos
            // 
            this.pbPagos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPagos.BackgroundImage")));
            this.pbPagos.Location = new System.Drawing.Point(240, 350);
            this.pbPagos.Name = "pbPagos";
            this.pbPagos.Size = new System.Drawing.Size(50, 50);
            this.pbPagos.TabIndex = 15;
            this.pbPagos.TabStop = false;
            // 
            // pbEstacionamiento
            // 
            this.pbEstacionamiento.BackgroundImage = global::Formularios.Properties.Resources.coche;
            this.pbEstacionamiento.Location = new System.Drawing.Point(518, 350);
            this.pbEstacionamiento.Name = "pbEstacionamiento";
            this.pbEstacionamiento.Size = new System.Drawing.Size(50, 50);
            this.pbEstacionamiento.TabIndex = 16;
            this.pbEstacionamiento.TabStop = false;
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDebito.ForeColor = System.Drawing.Color.White;
            this.rbDebito.Location = new System.Drawing.Point(309, 326);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(70, 22);
            this.rbDebito.TabIndex = 17;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Debito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCredito.ForeColor = System.Drawing.Color.White;
            this.rbCredito.Location = new System.Drawing.Point(309, 352);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(115, 22);
            this.rbCredito.TabIndex = 18;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Credito +10%";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEfectivo.ForeColor = System.Drawing.Color.White;
            this.rbEfectivo.Location = new System.Drawing.Point(309, 378);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(81, 22);
            this.rbEfectivo.TabIndex = 19;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // ModalMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(744, 435);
            this.ControlBox = false;
            this.Controls.Add(this.rbEfectivo);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.rbDebito);
            this.Controls.Add(this.pbEstacionamiento);
            this.Controls.Add(this.pbPagos);
            this.Controls.Add(this.cbEstacionamiento);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.btnAbrirMesa);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lvPedidos);
            this.Controls.Add(this.lblNroMesa);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCerrarMesa);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModalMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalMesa";
            this.Load += new System.EventHandler(this.ModalMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstacionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.ListView lvPedidos;
        private System.Windows.Forms.ColumnHeader idPedido;
        private System.Windows.Forms.ColumnHeader idEmpeleado;
        private System.Windows.Forms.ColumnHeader valorPedido;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnAbrirMesa;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.CheckBox cbEstacionamiento;
        private System.Windows.Forms.PictureBox pbPagos;
        private System.Windows.Forms.PictureBox pbEstacionamiento;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbEfectivo;
    }
}