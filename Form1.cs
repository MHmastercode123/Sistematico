using Prueba2.Data;
using System.Drawing.Printing;
using System.Xml.Linq;
using static Prueba2.Data.Prdctos;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        List<Prdctos> productos = new List<Prdctos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
       
            
            try
            {
                string nombre = txtnombre.Text;
                
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                
                int cantidad = int.Parse(txtcantidad.Text);
               
                Catdelproducto categoria = (Catdelproducto)cmboxCategoria.SelectedItem;
                
                Prdctos producto = new Prdctos(nombre, precio, cantidad, categoria);
               
                
                if (validaciodelnombre(nombre) && validaciodelprecio(precio) && validaciodelcantidad(cantidad,nombre,categoria))
                {
                    productos.Add(producto);
                    
                    listdeProductos.Items.Add(producto);
                    
                    ClearControls();
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("registro invalido");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboxCategoria.DataSource = Enum.GetValues(typeof(Catdelproducto));
        }

        private bool validaciodelnombre(string Nombre)
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("El nombre del producto es obligatorio");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validaciodelprecio(decimal precio)
        {
            if (precio > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("el precio no debe ser gratiuito");
                return false;
            }
        }

        private bool validaciodelcantidad(int cantidad, string nombre, Catdelproducto categoria)
        {
            if(cantidad < 0)
            {
             MessageBox.Show("La cantidad no debe de ser negativa");
             return false;
            }
            else if(cantidad == 0) {
            
             MessageBox.Show($"{nombre} -- {categoria} -- posee {cantidad} de unidades (Agotado)");
             return true;
            }
            else
            {
            MessageBox.Show($"{nombre} -- {categoria} -- posee {cantidad} de unidades (Disponible)");
            return true;
            }
        }

        private void ClearControls()
        {
            txtnombre.Clear();
            txtPrecio.Clear();
            txtcantidad.Clear();
            txtnombre.Focus();
        }
        
    }
}
