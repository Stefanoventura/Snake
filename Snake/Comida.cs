using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Comida
    {
        public Point Localizacao; // pontos(x,y) da localização da comida

        public void CriarComida()
        {
            //gerar numeros aleatorios entre 0 e 27 (Tamanho do espaçp do grid do jogo) = 421/15 = 28 ("quadradinhos")
            Random NumeroAleatorio = new Random();
            int x = NumeroAleatorio.Next(0, 27);
            int y = NumeroAleatorio.Next(0, 27);
            // setar a localização da comida
            Localizacao = new Point(x, y);
        }
    }
}
