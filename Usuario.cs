using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            Pedido pedidoEspaña = new PedidoEspaña();
            pedidoEspaña.setImporteSinIva(3123123123123.12312);
            pedidoEspaña.calculaPrecioConIva();
            pedidoEspaña.visualiza();

            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoLuxemburgo.setImporteSinIva(3123123123123.12312);
            pedidoLuxemburgo.calculaPrecioConIva();
            pedidoLuxemburgo.visualiza();
        }
    }
}
