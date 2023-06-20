using Dependencias.Email;
using Dependencias.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2._0.FormsProducts
{
    public partial class FxFormaTarjeta : UserControl
    {
        public FxFormaTarjeta()
        {
            InitializeComponent();
        }

        private void btnValidarTarjeta_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
               SendEmail();
            }
        }

        private bool isValid()
        {

            return true;
        }

        private async void SendEmail()
        {
            EmailSender sender = new("caracol293@gmail.com");
            List<Carrito> yok = new List<Carrito>() { new Carrito()
            {
                ProductName = "fad",
                ProductDescription ="fkdjlaj",
                ProductPrice = 14.6m,
                Quantity = 5,
            }, new Carrito()
            {
                ProductName = "fdafaad",
                ProductDescription = "ggggg",
                ProductPrice = 17.6m,
                Quantity = 3,
            }
            };

            sender.fillRows(yok);

            sender.fillHeader(new User() { Email = "125" , Password ="dadfda" , UserName = "yomero"});

            var si = await sender.SendEmail();

            MessageBox.Show(si);

        }
    }
}
