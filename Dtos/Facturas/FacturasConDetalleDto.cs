﻿using System;

namespace Dtos.Facturas
{
    public class FacturasConDetalleDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Habitacion { get; set; }

        public bool SuplementoEntrega { get; set; }
        public DateTime Fecha { get; set; }

        public double TotalParcial { get; set; }
        public double Doblado { get; set; }
        public double Suplemento { get; set; }
        public double TotalGlobal { get; set; }
        public string Estado { get; set; }
        public ListadoObtenerDetallesFacturaDto DetallesFacturas { get; set; }
    }
}
