using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.PresentacionVista
{
    public partial class PresentacionVistas : Form
    {
        public PresentacionVistas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentaListarVista());
            SubMenuVentas.Visible = true;

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProductoListarVista());
            SubMenuProducto.Visible = true;
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TipoProdListarVista());
            SubMenuProducto.Visible = false;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MarcaListarVista());
            SubMenuProducto.Visible = false;
        }

        private void btnProvee_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProveedorListarVista());
            SubMenuProducto.Visible = false;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClienteListarVista());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProveedorListarVista());
            SubMenuProveedor.Visible = true;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IngresoListarVista());
            SubMenuProveedor.Visible = false;
        }

        private void btnDetalleIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new DetalleIngListarVista());
            SubMenuProveedor.Visible = false;
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new DetalleVentaListarVista());
            SubMenuVentas.Visible = false;
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new UsuarioListarVista());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PantallaVista());
        }

        private void PresentacionVistas_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }
    }
}
