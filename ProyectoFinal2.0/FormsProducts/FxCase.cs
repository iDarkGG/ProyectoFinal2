using Dependencias.Model;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ProyectoFinal2._0.FormsProducts
{
    public partial class FxCase : UserControl
    {
        public FxCase()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var txt = sender as Button;
            Carrito carrito = null;
            foreach (var panel in Controls.OfType<Panel>())
            {
                if (panel.Controls.OfType<Button>().FirstOrDefault().Name == txt.Name)
                {
                    var lbls = panel.Controls.OfType<Label>().ToList();
                    
                    carrito = new Carrito()
                    {
                        ProductName = lbls[0].Text,
                        ProductPrice = decimal.Parse(Regex.Replace(lbls[1].Text, "\\$", string.Empty)),
                        ProductDescription = lbls[2].Text,
                        Quantity = int.Parse(panel.Controls.OfType<ComboBox>().First().Text),
                    };

                    carrito.Total = carrito.ProductPrice * carrito.Quantity;

                    break;
                }
            }


            using (var cliente = new HttpClient())
            {
                var str = JsonSerializer.Serialize(carrito);
                var content = new StringContent(str, System.Text.Encoding.UTF8, "application/json");

                var result =  cliente.PostAsync("https://localhost:7274/ApiTienda/Carrito", content).Result;
                if (result.IsSuccessStatusCode) MessageBox.Show("Producto agregado", "Agregado");
                else MessageBox.Show("error no agregada " + result.StatusCode.ToString());
            }

            

       
        }

        private async void FxCase_Load(object sender, EventArgs e)
        {
            using (var cliente = new HttpClient())
            {
                var result = await cliente.GetAsync("https://localhost:7274/ApiTienda/Carrito");

                if (result.IsSuccessStatusCode)
                {
                    var products = await result.Content.ReadAsStringAsync();

                    MessageBox.Show(products);

                    var lst = JsonSerializer.Deserialize<IEnumerable<ProductScheme>>(products);


                    fillComboBox(lst);

                }
                else
                {
                    MessageBox.Show("Fallo en la api xd");
                }
            }
        }


        private void fillComboBox(IEnumerable<ProductScheme> lst)
        {
            
        }


    }




}
