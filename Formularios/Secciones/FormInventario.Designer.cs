namespace Formularios.Secciones
{
    partial class FormInventario
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
            this.lvInventario = new System.Windows.Forms.ListView();
            this.idInventario = new System.Windows.Forms.ColumnHeader();
            this.nombreInventario = new System.Windows.Forms.ColumnHeader();
            this.stockInventario = new System.Windows.Forms.ColumnHeader();
            this.btnNuevoItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvInventario
            // 
            this.lvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInventario.BackColor = System.Drawing.Color.White;
            this.lvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idInventario,
            this.nombreInventario,
            this.stockInventario});
            this.lvInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvInventario.HideSelection = false;
            this.lvInventario.Location = new System.Drawing.Point(340, 12);
            this.lvInventario.Name = "lvInventario";
            this.lvInventario.Size = new System.Drawing.Size(411, 482);
            this.lvInventario.TabIndex = 0;
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
            this.nombreInventario.Text = "NOMBRE";
            this.nombreInventario.Width = 250;
            // 
            // stockInventario
            // 
            this.stockInventario.Text = "STOCK";
            this.stockInventario.Width = 100;
            // 
            // btnNuevoItem
            // 
            this.btnNuevoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoItem.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.btnNuevoItem.Location = new System.Drawing.Point(757, 12);
            this.btnNuevoItem.Name = "btnNuevoItem";
            this.btnNuevoItem.Size = new System.Drawing.Size(145, 40);
            this.btnNuevoItem.TabIndex = 11;
            this.btnNuevoItem.Text = "NUEVO ITEM";
            this.btnNuevoItem.UseVisualStyleBackColor = false;
            this.btnNuevoItem.Click += new System.EventHandler(this.btnNuevoItem_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.beautiful_old_uneven_wooden_table_with_two_blank_similar_cardboard_boxes_with_covers_against_white_wall_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 540);
            this.Controls.Add(this.btnNuevoItem);
            this.Controls.Add(this.lvInventario);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInventario;
        private System.Windows.Forms.ColumnHeader idInventario;
        private System.Windows.Forms.ColumnHeader nombreInventario;
        private System.Windows.Forms.ColumnHeader stockInventario;
        private System.Windows.Forms.Button btnNuevoItem;
    }
}