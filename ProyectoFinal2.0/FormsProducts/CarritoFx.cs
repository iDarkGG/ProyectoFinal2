using API.Dtos;
using Dependencias.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2._0.FormsProducts
{
    public partial class CarritoFx : UserControl
    {
        public CarritoFx()
        {
            InitializeComponent();
            
        }

        private void btnCerrarCarrito_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            
            FacturacionFx facturacionFx = new FacturacionFx();
            facturacionFx.ShowDialog();
          
          

        }

        public async void CargarProductos()
        {
            using (var cliente = new HttpClient())
            {
                var result = await cliente.GetAsync("https://localhost:7274/ApiTienda/Carrito");

                if (result.IsSuccessStatusCode)
                {
                    var products = await result.Content.ReadAsStringAsync();

                    MessageBox.Show(products);

                    var lst = JsonSerializer.Deserialize<IEnumerable<CarritoScheme>>(products);     

                    dataGridViewCarrito.DataSource =  lst.ToList();
                }else
                {
                    MessageBox.Show("Fallo en la api xd");
                }
            }
        }

        private void CarritoFx_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
