﻿using System;
using System.Runtime.Serialization;


namespace ServicioLotoUCAB.Servicio.Entidades
{
    [DataContract]
    [Serializable]
    public class BalanceBanca
    {
        [DataMember(Order = 1)]
        public int id_usuario { get; set; }

        [DataMember(Order = 2)]
        public string usuario { get; set; }

        [DataMember(Order = 3)]
        public double monto_total_vendido { get; set; }

        [DataMember(Order = 4)]
        public double monto_total_pagado { get; set; }

        [DataMember(Order = 5)]
        public double monto_total_pendiente { get; set; }

        [DataMember(Order = 6)]
        public double porcentaje_comision { get; set; }

        [DataMember(Order = 7)]
        public double monto_comision { get; set; }

        [DataMember(Order = 8)]
        public double saldo { get; set; }

    }
}
