using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ProyectoFinal2._0
{
    public partial class APPFx : Form
    {
        public APPFx()
        {
            InitializeComponent();
            SidePanel.Height = btnInicio.Height;
            fxInicio3.BringToFront();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            fxInicio3.BringToFront();
        }

        private void btnProcesadores_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProcesadores.Height;
            SidePanel.Top = btnProcesadores.Top;
            fxProcesadores3.BringToFront();
        }

        private void btnTarjetaGraficas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTarjetaGraficas.Height;
            SidePanel.Top = btnTarjetaGraficas.Top;
            fxTarjetasGraficas2.BringToFront();

        }

        private void btnMemoriaRam_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMemoriaRam.Height;
            SidePanel.Top = btnMemoriaRam.Top;
            fxMemoriasRam2.BringToFront();
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSSD.Height;
            SidePanel.Top = btnSSD.Top;
            fxssd2.BringToFront();
        }

        private void btnFuenteDePoder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFuenteDePoder.Height;
            SidePanel.Top = btnFuenteDePoder.Top;
            fxFuentesDePoder2.BringToFront();
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCase.Height;
            SidePanel.Top = btnCase.Top;
            fxCase2.BringToFront();
        }

        private void btnMonitores_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMonitores.Height;
            SidePanel.Top = btnMonitores.Top;
            fxMonitores2.BringToFront();
        }

        private void btnTecladoyMause_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTecladoyMause.Height;
            SidePanel.Top = btnTecladoyMause.Top;
            fxTecladoMause2.BringToFront();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            carritoFx2.BringToFront();
        }

        private void btnPlacasMadre_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPlacasMadre.Height;
            SidePanel.Top = btnPlacasMadre.Top;
            fxPlacasMadres1.BringToFront();
        }
    }
}
