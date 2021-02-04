using System;

namespace OperationLibrary
{
    public class Gestione
    {
        public static int Somma(int a, int b)
        {
            return a + b;
        }
        public static int Sottrazione(int a, int b)
        {
            return a - b;
        }
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }
        public static double Divisione(double a, double b)
        {
            double risultato;
            if (b == 0)
            {
                risultato = Double.NaN;
            }
            else
            {
                risultato = a / b;
            }
            return risultato;
        }
    }
}
