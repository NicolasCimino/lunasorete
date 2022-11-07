using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testObserver3.Clases;

namespace testObserver3
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();
        List<Usuario> usuarios = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(textBox1.Text, float.Parse(textBox2.Text));
            productos.Add(producto);
            ActulizarProductos();
        }

        public void ActulizarProductos() 
        {
            listBox1.DataSource = null;
            listBox1.DataSource = productos;
            listBox1.DisplayMember = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Producto p = listBox1.SelectedItem as Producto;
           p.Precio = float.Parse(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = textBox5.Text;
            usuarios.Add(usuario);
            ActulizarUsuarios();
        }

        public void ActulizarUsuarios()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = usuarios;
            listBox2.DisplayMember = "Nombre";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario u = listBox2.SelectedItem as Usuario;
            Producto p = listBox1.SelectedItem as Producto;
            if (!p.suscriptores.Contains(u))
            {
                p.Agregar(u);

            }
            else { MessageBox.Show("aca"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = listBox2.SelectedItem as Usuario;
            listBox3.DataSource = null;
            listBox3.DataSource = usuario.mensajes;
        }
    }
}
