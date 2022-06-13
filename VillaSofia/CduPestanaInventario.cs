﻿using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace VillaSofia
{
    public partial class CduPestanaInventario : UserControl
    {
        public CduPestanaInventario()
        {
            InitializeComponent();
            llenarDgvInventario();
        }

        void llenarDgvInventario()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dgvInventario.DataSource = inventario.mostrarInventarioActual();

        }
    }
}