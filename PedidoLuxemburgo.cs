using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PedidoLuxemburgo : Pedido
    {
        protected override void calculaIva()
        {
            importeIva = importeSinIva * 0.17;
        }
    }
}
