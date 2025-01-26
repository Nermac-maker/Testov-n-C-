using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestovaniC
{
    public class Kalkulacka
    {
        int a = 5;
        int b = 6;
        /// <summary>
        /// Metoda secte dve cisla a vrátí výsledek
        /// </summary>
        /// param name="a">První číslo</param>
        /// param name="b">Druhé číslo</param>
        /// <returns>součet prvního a druhého čísla</returns>
        public int Secti() { return a + b; }
        /// <summary>
        /// Metoda odečte dvě čísla a vrátí výsledek
        /// </summary>
        /// <returns></returns>
        public int Odecitani() { return a - b; }
        /// <summary>
        /// Metoda vynásobí dvě čísla a vrátí výsledek
        /// </summary>
        /// <returns></returns>
        public int Nasobeni() { return a * b; }
        /// <summary>
        /// Metoda vydělí dvě čísla a vrátí výsledek
        /// </summary>
        /// <returns></returns>
        public int Deleni() { return a / b; }
        

    }
}
