using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2._0
{
    public partial class APPFx : Form
    {
        public APPFx()
        {
            InitializeComponent();
            SidePanel.Height = btnInicio.Height;
            fxInicio1.BringToFront();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            fxInicio1.BringToFront();

        }

        private void btnProcesadores_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProcesadores.Height;
            SidePanel.Top = btnProcesadores.Top;
            fxProcesadores1.BringToFront();
        }
    }
}
