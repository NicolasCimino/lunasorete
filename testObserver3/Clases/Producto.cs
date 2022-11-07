using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testObserver3.Clases
{
    public class Producto : ISubject
    {
        private string nombre;
        public string Nombre { get { return nombre; } }
        private float precio;
        public float Precio {
            get { return precio; } 
            set{ precio = value; 
            Notificar();
            }
        }
        public List<IObserver>suscriptores = new List<IObserver>();
        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public void Agregar(IObserver observer)
        {
            suscriptores.Add(observer);
        }

        public void Quitar(IObserver observer)
        {
            suscriptores.Remove(observer);
        }

        public void Notificar()
        {
            foreach(Usuario usuario in suscriptores)
            {
                usuario.Update(this);
            }
        }

    }
}
