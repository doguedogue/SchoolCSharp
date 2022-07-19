using System;
using static System.Console;

namespace CoreEscuela.Util {
    public static class Printer {

        public static void DibujaLinea(int len = 10) {
            WriteLine("".PadLeft(len, '='));
        }

        public static void imprimeTitulo(string title) {
            var longitud = title.Length + 4;
            DibujaLinea(longitud);
            WriteLine("| " + title + " |");
            DibujaLinea(longitud);
        }

        public static void Beep(int hz = 1000, int time = 500, int cantidad = 1) {
            while (cantidad-- > 0) {
                System.Console.Beep(hz, time);
            }
        }

    }
}