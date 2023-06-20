using System.Text.Json;

namespace ProyectoFinal2._0.FormsProducts
{
    public partial class FxMemoriasRam : UserControl
    {
        public FxMemoriasRam()
        {
            InitializeComponent();
            using (var cliente = new HttpClient())
            {
                var result = cliente.GetAsync("https://localhost:7274/ApiTienda/Carrito").Result;

                if (result.IsSuccessStatusCode)
                {
                    var products = result.Content.ReadAsStringAsync().Result;

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
            var si = lst.ToList();
            ComboBox cbo = null;

            foreach (var panel in Controls.OfType<Panel>())
            {
                for (int i = 21; i < 27; i++)
                {
                    if (panel.Controls.OfType<Label>().FirstOrDefault().Text == si[i].productName)
                    {
                        cbo = panel.Controls.OfType<ComboBox>().First();
                        for (int j = 16; j <= si[0].productStock; j++)
                            cbo.Items.Add(j);
                        
                        break;
                    }
                }
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
