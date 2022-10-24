using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Jogo
    {
        public Keys Seta;

        public Keys Direcao;

        private System.Windows.Forms.Timer Temporizador;

        private Label LabelPontuacao;

        private Panel PainelFormulario;

        private int Pontos;

        private Comida objetoComida;

        private Cobrinha objetoCobra;

        private Bitmap BitmapImagemFundo;

        private Graphics GraphicsBitmapImagemFundo;

        private Graphics GraphicsPainelForm;

        public Jogo(ref System.Windows.Forms.Timer TemporizadorForm, ref Label LabelForm, ref Panel PainelForm)
        {
            Temporizador = TemporizadorForm;
            LabelPontuacao = LabelForm;
            PainelFormulario = PainelForm;

            BitmapImagemFundo = new Bitmap(428, 428);//dimensoes do Painel do Form

            objetoCobra = new Cobrinha();

            objetoComida = new Comida();

            //quando iniciar, já ir para a esquerda
            Direcao = Keys.Left;
            Seta = Keys.Left;
        }

        public void IniciarJogo()
        {
            objetoCobra.SetarPosicaoInicial();
            objetoComida.CriarComida();

            Direcao = Keys.Left;
            GraphicsBitmapImagemFundo = Graphics.FromImage(BitmapImagemFundo);
            GraphicsPainelForm = PainelFormulario.CreateGraphics();

            Temporizador.Enabled = true;
        }

        public void Tick()
        {
            if ((Seta == Keys.Left && Direcao != Keys.Right) ||  //se estiver indo para a esquerda, não poderá inverter para a direita
                (Seta == Keys.Right && Direcao != Keys.Left) || //se estiver indo para a direita, não poderá inverter para a esquerda
                (Seta == Keys.Up && Direcao != Keys.Down) || // se estiver indo para cima, não poderá inverter para baixo
                (Seta == Keys.Down && Direcao != Keys.Up)) //se estiver indo para baixo, não poderá inverter para cima
            {
                Direcao = Seta;
            }
            switch (Direcao)
            {
                case Keys.Left:
                    objetoCobra.Mover_Esquerda();
                    break;

                case Keys.Right:
                    objetoCobra.Mover_Direita();
                    break;

                case Keys.Up:
                    objetoCobra.Mover_ParaCima();
                    break;

                case Keys.Down:
                    objetoCobra.Mover_ParaBaixo();
                    break;
            }

            //limpar o rastro da cobra
            GraphicsBitmapImagemFundo.Clear(Color.Green);
            //desenhar a comida
            GraphicsBitmapImagemFundo.DrawImage(Properties.Resources.Comida, objetoComida.Localizacao.X * 15, objetoComida.Localizacao.Y * 15, 15, 15);

            bool GAMEOVER = false;

            //desenhar a cobra
            for (int i = 0; i < objetoCobra.Comprimento; i++)
            {
                if (i == 0) //posicao da cabeça da cobra
                {
                    GraphicsBitmapImagemFundo.FillEllipse(new SolidBrush(Color.White), objetoCobra.Localizacao[i].X * 15, objetoCobra.Localizacao[i].Y * 15, 15, 15);
                }
                else
                {
                    GraphicsBitmapImagemFundo.FillEllipse(new SolidBrush(Color.Black), objetoCobra.Localizacao[i].X * 15, objetoCobra.Localizacao[i].Y * 15, 15, 15);
                }

                //Verificar se a cabeça colidiu com o corpo

            if (i != 0)
                {
                    if (objetoCobra.Localizacao[i] == objetoCobra.Localizacao[0])
                    {
                        GAMEOVER = true;
                    }
                }
            }// fim for

            //resetar a imagem da tela
            GraphicsPainelForm.DrawImage(BitmapImagemFundo, 0, 0);

            VerificarColisao();

            if (GAMEOVER == true)
            {
                FinalizarJogo();
            }
        }

        void FinalizarJogo()
        {
            Temporizador.Enabled = false;
            //liberar a memoria da imagens

            GraphicsBitmapImagemFundo.Dispose();
            GraphicsPainelForm.Dispose();

            LabelPontuacao.Text = "GAME OVER!!!!!!!";
            Pontos = 0;

        }

        void VerificarColisao()
        {
            //se a cabeça da cobra encontrou a comida
            if (objetoCobra.Localizacao[0] == objetoComida.Localizacao)
            {
                objetoCobra.Comer();
                //criar uma nova posicao de comida
                objetoComida.CriarComida();

                Pontos += 1; // incrementar a pontuação

                LabelPontuacao.Text = Pontos.ToString();
            }
        }
       
    }
}
