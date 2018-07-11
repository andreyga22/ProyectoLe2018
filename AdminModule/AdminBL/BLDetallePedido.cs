﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBL
{
    [Serializable]
    public class BLDetallePedido
    {

        public int CODIGO_PEDIDO { get; set; }
        public int CODIGO_PLATO { get; set; }
        public int CANTIDAD_PRODUCTO { get; set; }
        public BLPlato plato { get; set; }
        public BLDetallePedido()
        {

        }
    }
}
