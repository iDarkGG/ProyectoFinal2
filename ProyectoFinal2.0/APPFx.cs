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
            fxInicio2.BringToFront();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            fxInicio2.BringToFront();
        }

        private void btnProcesadores_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProcesadores.Height;
            SidePanel.Top = btnProcesadores.Top;
            fxProcesadores2.BringToFront();
        }

        private void btnTarjetaGraficas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTarjetaGraficas.Height;
            SidePanel.Top = btnTarjetaGraficas.Top;
            fxTarjetasGraficas1.BringToFront();

        }

        private void btnMemoriaRam_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMemoriaRam.Height;
            SidePanel.Top = btnMemoriaRam.Top;
            fxMemoriasRam1.BringToFront();
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSSD.Height;
            SidePanel.Top = btnSSD.Top;
            fxssd1.BringToFront();
        }

        private void btnFuenteDePoder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFuenteDePoder.Height;
            SidePanel.Top = btnFuenteDePoder.Top;
            fxFuentesDePoder1.BringToFront();
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCase.Height;
            SidePanel.Top = btnCase.Top;
            fxCase1.BringToFront();
        }

        private void btnMonitores_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMonitores.Height;
            SidePanel.Top = btnMonitores.Top;
            fxMonitores1.BringToFront();
        }

        private void btnTecladoyMause_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTecladoyMause.Height;
            SidePanel.Top = btnTecladoyMause.Top;
            fxTecladoMause1.BringToFront();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            carritoFx1.BringToFront();
        }
    }
}
