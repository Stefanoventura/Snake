using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    public partial class Form1 : Form
    {
        Jogo objectojogo;
        public Form1()
        {
            InitializeComponent();

            objectojogo = new Jogo(ref timerjogos, ref labPontos, ref panelPrincipal);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
            {
                objectojogo.Seta = e.KeyCode;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            objectojogo.IniciarJogo();
        }

        private void Timerjogos_Tick(object sender, EventArgs e)
        {
            objectojogo.Tick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
