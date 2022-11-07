using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testObserver3.Clases
{
    public  class Usuario : IObserver
    {
        private string nombre;
        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; }
        }
        public List<string> mensajes = new List<string>();

        public void Update(ISubject subject)
        {
            Producto p = subject as Producto;
            mensajes.Add(p.Nombre + " cambio de precio. Nuevo valor $" + p.Precio.ToString());
        }
    }
}
