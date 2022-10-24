using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Cobrinha
    {
        public int Comprimento;

        public Point[] Localizacao;//pontos (x,y) da localização da cobrinha

        public Cobrinha()
        {
            Localizacao = new Point[28 * 28]; // a cobrinha pode ter o comprimento máximo de 28x28 

            SetarPosicaoInicial(); //setar posicao inicial da cobrinha
        }

        public void SetarPosicaoInicial()
        {
            //Iniciar a posicao da cobrinha no centro da tela
            Comprimento = 5;
            for (int i=0; i < Comprimento; i++)
            {
                Localizacao[i].X = 12;
                Localizacao[i].Y = 12;
            }
        }

        public void DeslocarPosicao()
        {
            for (int i = Comprimento - 1; i > 0; i--)
            {
                Localizacao[i] = Localizacao[i - 1];
            }
        }

        public void Mover_ParaCima()
        {
            DeslocarPosicao();
            Localizacao[0].Y--;
            
            //Verificar se a cabeça da cobrinha chegou no topo da janela
            if (Localizacao[0].Y < 0)
            {
                Localizacao[0].Y += 28;
            }
        }

        public void Mover_ParaBaixo()
        {
            DeslocarPosicao();
            Localizacao[0].Y++;

            //verificar se a cabeça da cobrinha chegou na parte inferior da janela
            if (Localizacao[0].Y > 27)
            {
                Localizacao[0].Y -= 28;
            }
        }

        public void Mover_Direita()
        {
            DeslocarPosicao();
            Localizacao[0].X++;

            //verificar se a cabeça da cobrinha chegou na parte inferior da janela
            if (Localizacao[0].X > 27)
            {
                Localizacao[0].X -= 28;
            }
        }

        public void Mover_Esquerda()
        {
            DeslocarPosicao();
            Localizacao[0].X--;

            //verificar se a cabeça da cobrinha chegou no topo da janela
            if (Localizacao[0].X < 0)
            {
                Localizacao[0].X += 28;
            }
        }

        public void Comer()
        {
            //aumentar o tamanho da cobrinha
            Comprimento++;
        }
    }
}
