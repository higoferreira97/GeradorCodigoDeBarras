using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorCodigoDeBarras
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictCodigoSaida_Click(object sender, EventArgs e)
        {

        }

        private void Btn_gerar_Click(object sender, EventArgs e)
        {
            try
            {
                CodigoBarras.GerarCodigo(pictCodigo.Text, 2, pictCodigoSaida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar código de barras!");

            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            this.printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (var g = e.Graphics)
            using (var fnt = new Font("Courier New", 16))
            {
                g.DrawImage(this.pictCodigoSaida.Image, 20, 50);

                var caption = pictCodigo.Text;
                g.DrawString(caption, fnt, Brushes.Black, 130, 110);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                Btn_Imprimir.PerformClick();
                e.Handled = true;
            }
        }
    }
}
