using System;
using System.Text;
using System.Threading;
using System.IO;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Esta clase se encarga de imprimir en la consola el board, esta permite que en caso de tener que
    /// cambiar el lugar de impresion la unica clase que deba cambiar es esta, y eso solo implicaria un motivo
    /// para cambiar, por lo cual aun se mantiene el principio SRP.
    /// </summary>
    public static class Print
    {
        public static void PrintString(StringBuilder s)
        {
            Console.WriteLine(s.ToString());
            Thread.Sleep(300);
        }
    }
}