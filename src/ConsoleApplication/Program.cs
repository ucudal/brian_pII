//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /// 100 instancias de la clase Tren
            for (int i = 0; i < 100; i++) 
            {
                var train = new Train($"train{i}");
            }

            /// 10.000.000 de instancias
            for (int i = 0; i < 10000000; i++) 
            {
                var train = new Train($"train{i}");
                train.StartEngines();
            }

            ///  3 instancias de la clase Train, t1, t2, t3
            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");

            ///  t1==t2 y t2 == t3
            /// t1 no es igual a t2 ni t2 es igual a t3 porque apuntan a distintos espacios en memoria
            /// 
        }
    }
}