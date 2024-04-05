namespace SistemasVentas.VISTA.PresentacionVista
{
    partial class PresentacionVistas
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
            panel1 = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel2 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            SubMenuVentas = new Panel();
            btnDetalleVenta = new Button();
            SubMenuProveedor = new Panel();
            btnIngreso = new Button();
            btnDetalleIngreso = new Button();
            btnVentas = new Button();
            btnProveedor = new Button();
            SubMenuProducto = new Panel();
            btnTipoProducto = new Button();
            btnProvee = new Button();
            btnMarca = new Button();
            btnUsuario = new Button();
            btnCliente = new Button();
            btnProducto = new Button();
            btnInicio = new PictureBox();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel2.SuspendLayout();
            SubMenuVentas.SuspendLayout();
            SubMenuProveedor.SuspendLayout();
            SubMenuProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chartreuse;
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 40);
            panel1.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.Imagen2;
            btnRestaurar.Location = new Point(748, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Imagen3;
            btnMinimizar.Location = new Point(779, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.Imagen4;
            btnMaximizar.Location = new Point(810, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Imagen11;
            btnCerrar.Location = new Point(841, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(SubMenuVentas);
            panel2.Controls.Add(SubMenuProveedor);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnProveedor);
            panel2.Controls.Add(SubMenuProducto);
            panel2.Controls.Add(btnUsuario);
            panel2.Controls.Add(btnCliente);
            panel2.Controls.Add(btnProducto);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 546);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lime;
            panel7.Location = new Point(1, 436);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 34);
            panel7.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Lime;
            panel6.Location = new Point(0, 317);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 34);
            panel6.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lime;
            panel5.Location = new Point(1, 277);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 34);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lime;
            panel4.Location = new Point(3, 237);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 34);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Location = new Point(3, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 34);
            panel3.TabIndex = 2;
            // 
            // SubMenuVentas
            // 
            SubMenuVentas.Controls.Add(btnDetalleVenta);
            SubMenuVentas.Location = new Point(24, 467);
            SubMenuVentas.Name = "SubMenuVentas";
            SubMenuVentas.Size = new Size(176, 49);
            SubMenuVentas.TabIndex = 3;
            SubMenuVentas.Visible = false;
            // 
            // btnDetalleVenta
            // 
            btnDetalleVenta.BackColor = Color.FromArgb(26, 32, 40);
            btnDetalleVenta.Cursor = Cursors.Hand;
            btnDetalleVenta.FlatAppearance.BorderSize = 0;
            btnDetalleVenta.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnDetalleVenta.FlatStyle = FlatStyle.Flat;
            btnDetalleVenta.ForeColor = SystemColors.ControlLight;
            btnDetalleVenta.Location = new Point(3, 3);
            btnDetalleVenta.Name = "btnDetalleVenta";
            btnDetalleVenta.Size = new Size(170, 34);
            btnDetalleVenta.TabIndex = 6;
            btnDetalleVenta.Text = "DETALLE VENTA";
            btnDetalleVenta.UseVisualStyleBackColor = false;
            btnDetalleVenta.Click += btnDetalleVenta_Click;
            // 
            // SubMenuProveedor
            // 
            SubMenuProveedor.Controls.Add(btnIngreso);
            SubMenuProveedor.Controls.Add(btnDetalleIngreso);
            SubMenuProveedor.Location = new Point(24, 357);
            SubMenuProveedor.Name = "SubMenuProveedor";
            SubMenuProveedor.Size = new Size(176, 73);
            SubMenuProveedor.TabIndex = 4;
            SubMenuProveedor.Visible = false;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(26, 32, 40);
            btnIngreso.Cursor = Cursors.Hand;
            btnIngreso.FlatAppearance.BorderSize = 0;
            btnIngreso.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.ForeColor = SystemColors.ControlLight;
            btnIngreso.Location = new Point(15, 3);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(158, 34);
            btnIngreso.TabIndex = 6;
            btnIngreso.Text = "INGRESO";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // btnDetalleIngreso
            // 
            btnDetalleIngreso.BackColor = Color.FromArgb(26, 32, 40);
            btnDetalleIngreso.Cursor = Cursors.Hand;
            btnDetalleIngreso.FlatAppearance.BorderSize = 0;
            btnDetalleIngreso.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnDetalleIngreso.FlatStyle = FlatStyle.Flat;
            btnDetalleIngreso.ForeColor = SystemColors.ControlLight;
            btnDetalleIngreso.Location = new Point(15, 33);
            btnDetalleIngreso.Name = "btnDetalleIngreso";
            btnDetalleIngreso.Size = new Size(158, 34);
            btnDetalleIngreso.TabIndex = 4;
            btnDetalleIngreso.Text = "DETALLE INGRESO";
            btnDetalleIngreso.UseVisualStyleBackColor = false;
            btnDetalleIngreso.Click += btnDetalleIngreso_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(26, 32, 40);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = SystemColors.ControlLight;
            btnVentas.Location = new Point(3, 436);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(170, 34);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(26, 32, 40);
            btnProveedor.Cursor = Cursors.Hand;
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.ForeColor = SystemColors.ControlLight;
            btnProveedor.Location = new Point(12, 317);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(170, 34);
            btnProveedor.TabIndex = 4;
            btnProveedor.Text = "PROVEEDOR";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // SubMenuProducto
            // 
            SubMenuProducto.Controls.Add(btnTipoProducto);
            SubMenuProducto.Controls.Add(btnProvee);
            SubMenuProducto.Controls.Add(btnMarca);
            SubMenuProducto.Location = new Point(24, 131);
            SubMenuProducto.Name = "SubMenuProducto";
            SubMenuProducto.Size = new Size(176, 100);
            SubMenuProducto.TabIndex = 2;
            SubMenuProducto.Visible = false;
            // 
            // btnTipoProducto
            // 
            btnTipoProducto.BackColor = Color.FromArgb(26, 32, 40);
            btnTipoProducto.Cursor = Cursors.Hand;
            btnTipoProducto.FlatAppearance.BorderSize = 0;
            btnTipoProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnTipoProducto.FlatStyle = FlatStyle.Flat;
            btnTipoProducto.ForeColor = SystemColors.ControlLight;
            btnTipoProducto.Location = new Point(15, 3);
            btnTipoProducto.Name = "btnTipoProducto";
            btnTipoProducto.Size = new Size(158, 34);
            btnTipoProducto.TabIndex = 6;
            btnTipoProducto.Text = "TiPO PRODUCTO";
            btnTipoProducto.UseVisualStyleBackColor = false;
            btnTipoProducto.Click += btnTipoProducto_Click;
            // 
            // btnProvee
            // 
            btnProvee.BackColor = Color.FromArgb(26, 32, 40);
            btnProvee.Cursor = Cursors.Hand;
            btnProvee.FlatAppearance.BorderSize = 0;
            btnProvee.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnProvee.FlatStyle = FlatStyle.Flat;
            btnProvee.ForeColor = SystemColors.ControlLight;
            btnProvee.Location = new Point(15, 63);
            btnProvee.Name = "btnProvee";
            btnProvee.Size = new Size(158, 34);
            btnProvee.TabIndex = 5;
            btnProvee.Text = "PROVEE";
            btnProvee.UseVisualStyleBackColor = false;
            btnProvee.Click += btnProvee_Click;
            // 
            // btnMarca
            // 
            btnMarca.BackColor = Color.FromArgb(26, 32, 40);
            btnMarca.Cursor = Cursors.Hand;
            btnMarca.FlatAppearance.BorderSize = 0;
            btnMarca.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnMarca.FlatStyle = FlatStyle.Flat;
            btnMarca.ForeColor = SystemColors.ControlLight;
            btnMarca.Location = new Point(15, 33);
            btnMarca.Name = "btnMarca";
            btnMarca.Size = new Size(158, 34);
            btnMarca.TabIndex = 4;
            btnMarca.Text = "MARCA";
            btnMarca.UseVisualStyleBackColor = false;
            btnMarca.Click += btnMarca_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(26, 32, 40);
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.ForeColor = SystemColors.ControlLight;
            btnUsuario.Location = new Point(12, 277);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(170, 34);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "USUARIO";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(26, 32, 40);
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.ForeColor = SystemColors.ControlLight;
            btnCliente.Location = new Point(12, 237);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(170, 34);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "CLIENTE";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(26, 32, 40);
            btnProducto.Cursor = Cursors.Hand;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.ForeColor = SystemColors.ControlLight;
            btnProducto.Location = new Point(12, 102);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(170, 34);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "PRODUCTO";
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnInicio
            // 
            btnInicio.Image = Properties.Resources.market_upds;
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(194, 93);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.WindowFrame;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 40);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(678, 546);
            panelContenedor.TabIndex = 2;
            // 
            // PresentacionVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 586);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PresentacionVistas";
            Text = "PresentacionVistas";
            Load += PresentacionVistas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel2.ResumeLayout(false);
            SubMenuVentas.ResumeLayout(false);
            SubMenuProveedor.ResumeLayout(false);
            SubMenuProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnRestaurar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private Panel panel2;
        private Button btnProducto;
        private PictureBox btnInicio;
        private Button btnProveedor;
        private Button btnUsuario;
        private Button btnCliente;
        private Button btnVentas;
        private Panel SubMenuProveedor;
        private Button btnIngreso;
        private Button btnDetalleIngreso;
        private Panel SubMenuProducto;
        private Button btnTipoProducto;
        private Button btnProvee;
        private Button btnMarca;
        private Panel SubMenuVentas;
        private Button btnDetalleVenta;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panelContenedor;
    }
}