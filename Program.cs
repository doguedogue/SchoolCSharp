﻿using System;
using CoreEscuela.Entidades;

namespace Etapa1 {
    class Program {
        static void Main(string[] args) {
            var miescuela = new Escuela("iavhc", 1995);
            miescuela.Pais = "GT";
            miescuela.Ciudad = "GT";
            miescuela.AñoCreación = 1965;
            miescuela.TiposEscuela = TiposEscuela.Primaria;
            Console.WriteLine(miescuela);
        }
    }
}