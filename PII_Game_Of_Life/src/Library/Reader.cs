using System;
using System.IO;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Esta clase se encarga de transformar el archivo con la board inicial formada por 0s y 1s, esta responsibilidad
    /// se le es dada ya que es el experto en la informacion necesaria para traducir el archivo a un bool[,]
    /// cumple con el patron Expert.
    /// </summary>
    public class Reader
    {
        public static bool[,] Reading()
        {
            string url = "../../assets/board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            return board;
        }
    }
}