namespace Formularios.Secciones
{
    partial class FormUsuarios
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
            this.lvEmpleados = new System.Windows.Forms.ListView();
            this.idEmpleado = new System.Windows.Forms.ColumnHeader();
            this.nombreEmpleado = new System.Windows.Forms.ColumnHeader();
            this.apellidoEmpleado = new System.Windows.Forms.ColumnHeader();
            this.dniEmpleado = new System.Windows.Forms.ColumnHeader();
            this.fntoEmpleado = new System.Windows.Forms.ColumnHeader();
            this.rolEmpleado = new System.Windows.Forms.ColumnHeader();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.panelEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEmpleados
            // 
            this.lvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idEmpleado,
            this.nombreEmpleado,
            this.apellidoEmpleado,
            this.dniEmpleado,
            this.fntoEmpleado,
            this.rolEmpleado});
            this.lvEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvEmpleados.HideSelection = false;
            this.lvEmpleados.Location = new System.Drawing.Point(12, 262);
            this.lvEmpleados.Name = "lvEmpleados";
            this.lvEmpleados.Size = new System.Drawing.Size(881, 266);
            this.lvEmpleados.TabIndex = 0;
            this.lvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lvEmpleados.View = System.Windows.Forms.View.Details;
            this.lvEmpleados.DoubleClick += new System.EventHandler(this.lvEmpleados_DoubleClick);
            // 
            // idEmpleado
            // 
            this.idEmpleado.Text = "ID";
            this.idEmpleado.Width = 100;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.Text = "Nombre";
            this.nombreEmpleado.Width = 150;
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.Text = "Apellido";
            this.apellidoEmpleado.Width = 150;
            // 
            // dniEmpleado
            // 
            this.dniEmpleado.Text = "DNI";
            this.dniEmpleado.Width = 150;
            // 
            // fntoEmpleado
            // 
            this.fntoEmpleado.Text = "Fecha de Nacimiento";
            this.fntoEmpleado.Width = 180;
            // 
            // rolEmpleado
            // 
            this.rolEmpleado.Text = "Rol";
            this.rolEmpleado.Width = 150;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(89)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.panelEmpleados.Controls.Add(this.btnCrearEmpleado);
            this.panelEmpleados.Controls.Add(this.lvEmpleados);
            this.panelEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmpleados.Location = new System.Drawing.Point(0, 0);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(908, 540);
            this.panelEmpleados.TabIndex = 1;
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(696, 185);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(197, 40);
            this.btnCrearEmpleado.TabIndex = 10;
            this.btnCrearEmpleado.Text = "NUEVO EMPLEADO";
            this.btnCrearEmpleado.UseVisualStyleBackColor = false;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.closeup_friends_toasting_with_beer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1151, 540);
            this.Controls.Add(this.panelEmpleados);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.panelEmpleados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEmpleados;
        private System.Windows.Forms.ColumnHeader idEmpleado;
        private System.Windows.Forms.ColumnHeader nombreEmpleado;
        private System.Windows.Forms.ColumnHeader apellidoEmpleado;
        private System.Windows.Forms.ColumnHeader dniEmpleado;
        private System.Windows.Forms.ColumnHeader fntoEmpleado;
        private System.Windows.Forms.ColumnHeader rolEmpleado;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button btnCrearEmpleado;
    }
}