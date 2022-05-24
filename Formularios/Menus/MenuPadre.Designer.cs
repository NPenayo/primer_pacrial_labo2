
namespace Formularios
{
    public partial class MenuPadre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPadre));
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelNavMenu = new System.Windows.Forms.Panel();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pbInventario = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pbSalon = new System.Windows.Forms.PictureBox();
            this.btnSalon = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelNavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(1832, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(1873, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelNavMenu
            // 
            this.panelNavMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelNavMenu.Controls.Add(this.pbUsuarios);
            this.panelNavMenu.Controls.Add(this.btnUsuarios);
            this.panelNavMenu.Controls.Add(this.pbInventario);
            this.panelNavMenu.Controls.Add(this.btnInventario);
            this.panelNavMenu.Controls.Add(this.pbSalon);
            this.panelNavMenu.Controls.Add(this.btnSalon);
            this.panelNavMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavMenu.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelNavMenu.Location = new System.Drawing.Point(1670, 0);
            this.panelNavMenu.Name = "panelNavMenu";
            this.panelNavMenu.Size = new System.Drawing.Size(250, 1080);
            this.panelNavMenu.TabIndex = 4;
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarios.Image")));
            this.pbUsuarios.Location = new System.Drawing.Point(19, 520);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(50, 50);
            this.pbUsuarios.TabIndex = 5;
            this.pbUsuarios.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(19, 520);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 50);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pbInventario
            // 
            this.pbInventario.BackColor = System.Drawing.Color.Transparent;
            this.pbInventario.Image = ((System.Drawing.Image)(resources.GetObject("pbInventario.Image")));
            this.pbInventario.Location = new System.Drawing.Point(19, 415);
            this.pbInventario.Name = "pbInventario";
            this.pbInventario.Size = new System.Drawing.Size(50, 50);
            this.pbInventario.TabIndex = 3;
            this.pbInventario.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(18, 415);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(220, 50);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pbSalon
            // 
            this.pbSalon.BackColor = System.Drawing.Color.Transparent;
            this.pbSalon.Image = ((System.Drawing.Image)(resources.GetObject("pbSalon.Image")));
            this.pbSalon.Location = new System.Drawing.Point(19, 310);
            this.pbSalon.Name = "pbSalon";
            this.pbSalon.Size = new System.Drawing.Size(50, 50);
            this.pbSalon.TabIndex = 1;
            this.pbSalon.TabStop = false;
            // 
            // btnSalon
            // 
            this.btnSalon.BackColor = System.Drawing.Color.Transparent;
            this.btnSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalon.FlatAppearance.BorderSize = 0;
            this.btnSalon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalon.ForeColor = System.Drawing.Color.White;
            this.btnSalon.Location = new System.Drawing.Point(19, 310);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSalon.Size = new System.Drawing.Size(220, 50);
            this.btnSalon.TabIndex = 0;
            this.btnSalon.Text = "SALON";
            this.btnSalon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalon.UseVisualStyleBackColor = false;
            this.btnSalon.Click += new System.EventHandler(this.btnSalon_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1670, 1080);
            this.panelMain.TabIndex = 5;
            // 
            // MenuPadre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelNavMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelNavMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Panel panelNavMenu;
        public System.Windows.Forms.Button btnSalon;
        public System.Windows.Forms.PictureBox pbInventario;
        public System.Windows.Forms.Button btnInventario;
        public System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.PictureBox pbUsuarios;
        public System.Windows.Forms.PictureBox pbSalon;
    }
}

