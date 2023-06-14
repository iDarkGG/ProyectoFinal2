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
    public partial class FacturacionFx : Form
    {
        public FacturacionFx()
        {
            InitializeComponent();

            fxFormaDePagoEfectivo1.BringToFront();

        }

        private void fxPagoEfectivo2_Load(object sender, EventArgs e)
        {

        }

        private void checkTarjetaDeCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTarjetaDeCredito.Checked == true)
            {
                fxFormaDePagoTarjeta1.BringToFront();
            }
            else
            {
                fxFormaDePagoEfectivo1.BringToFront();
            }
        }

        private void FacturacionFx_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
