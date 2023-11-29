using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Pedido
    {
        protected double importeSinIva;
        protected double importeIva;
        protected double importeConIva;

        protected abstract void calculaIva();

        public void calculaPrecioConIva()
        {
            this.calculaIva();
            importeConIva = importeSinIva + importeIva;
        }

        public void setImporteSinIva(double importeSinIva)
        {
            this.importeSinIva = importeSinIva;
        }

        public void visualiza()
        {
            Console.WriteLine("Pedido");
            Console.WriteLine("Importe sin Iva: " + importeSinIva);
            Console.WriteLine("Importe con Iva: " + importeConIva);
        }

    }
}
