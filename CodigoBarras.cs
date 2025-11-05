using GenCode128;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorCodigoDeBarras
{
    public class CodigoBarras
    {

        public static void GerarCodigo(string textCodigo, int altura, PictureBox pictSaida)
        {
            Image codigo = Code128Rendering.MakeBarcodeImage(textCodigo, altura, true);
            pictSaida.Image = codigo;
        }




    }
}
